using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AweCoreDemo.Helpers
{
    public static class StrUtil
    {
        public static char[] EmptyChars = { ' ', '\r', '\n', '\t' };

        public static string GetCode(string[] lines, string startWord, string endWord)
        {
            int starti = -1, endi = -1;

            for (int i = 0; i < lines.Length; i++)
            {
                if (starti == -1)
                {
                    if (lines[i].Contains(startWord))
                    {
                        starti = i;
                    }
                }
                else
                {
                    if (lines[i].Contains(endWord))
                    {
                        endi = i;
                        break;
                    }
                }
            }

            if (starti != -1 && endi == -1) endi = lines.Length - 1;

            string[] res;
            if (endi == -1)
            {
                res = lines;
            }
            else
            {
                var alen = endi - (starti + 1);
                res = new string[alen];
                Array.Copy(lines, starti + 1, res, 0, alen);
            }

            return StrUtil.CodeLinesToStr(res);
        }

        public static IEnumerable<string> GetCommentsAbove(string src, int starti)
        {
            var linestart = GetLineStart(src, starti);
            var res = new List<string>();
            
            int lastNewLinei = -1;
            for (var i = linestart - 1; i >= 0; i--)
            {
                if (src.IsNextStr(i, "\r\n"))
                {
                    if (lastNewLinei > 0)
                    {
                        var line = src.FromTo(i + 2, lastNewLinei - 1);
                        if (line.TrimStart().StartsWith("//"))
                        {
                            res.Add(line);
                        }
                        else
                        {
                            break;
                        }
                    }

                    lastNewLinei = i;
                }
            }

            return res;
        }

        public static string ParseStrToCode(string str, string path = null)
        {
            str = str.Replace("\r", String.Empty)
                .Replace("&", "&amp;")
                .Replace("\"", "&quot;")
                .Replace("'", "&#39;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\n", "<br/>");

            var res = "<pre class='lang-java'>" + str + "</pre>";

            if (path != null)
            {
                res = "<div class='codePath'>" + path + "</div>" + res;
            }

            res = "<div class='codeWrap'>" + res + "</div>";

            return res;
        }

        public static string CodeLinesToStr(string[] res)
        {
            res = StrUtil.RemStartSpace(res);

            // add 1 empty line when first line is long
            var sb = new StringBuilder();
            if (res.Length > 0 && res[0].Length > 100)
            {
                sb.AppendLine("");
            }

            foreach (var line in res)
            {
                sb.AppendLine(line);
            }

            return sb.ToString();
        }

        public static int GetLineStart(string src, int index)
        {
            var res = 0;
            for (int i = index; i >= 0; i--)
            {
                if (src[i] == '\n')
                {
                    res = i + 1;
                    break;
                }
            }

            return res;
        }

        /// <summary>
        /// returns start index of phrase found in src string, -1 if not found
        /// </summary>
        public static int FindPhrase(string src, string[] phrase, out int endIndex)
        {
            var result = endIndex = -1;

            for (var i = 0; i < src.Length; i++)
            {
                var starti = -1;
                var endi = -1;

                for (var j = 0; j < phrase.Length; j++)
                {
                    var word = phrase[j];
                    if (src.IsNextStr(i, word))
                    {
                        if (j == 0)
                        {
                            starti = i;
                        }

                        i += word.Length;

                        var nexti = IndexOfAnyCharNotIn(src, EmptyChars, i);

                        if (nexti > 0)
                        {
                            i = nexti;
                        }
                        else
                        {
                            i = src.Length - 1;
                        }

                        if (j == phrase.Length - 1)
                        {
                            endi = i;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (endi > 0)
                {
                    endIndex = endi;
                    result = starti;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// returns start and end index of the first function name {} in src
        /// </summary>
        public static Tuple<int, int> FindMethod(string src, string[] definition)
        {
            int endi;
            
            var fstarti = StrUtil.FindPhrase(src, definition, out endi);

            if (endi < 0) return null;

            fstarti = GetLineStart(src, fstarti);

            var msti = src.IndexOf("{", endi, StringComparison.Ordinal);
            var blockEndi = src.GetBlockEnd(msti);

            return new Tuple<int, int>(fstarti, blockEndi);
        }

        public static int GetBlockEnd(this string src, int starti)
        {
            var count = 1;
            starti += 1;
            for (var i = starti; i < src.Length; i++)
            {
                if (src[i] == '{') count++;
                if (src[i] == '}') count--;

                if (count == 0)
                {
                    return i;
                }
            }

            return src.Length - 1;
        }

        public static int IndexOfAnyCharNotIn(string str, char[] excludeChars, int startAtIndx = 0)
        {
            var index = -1;
            
            for (var i = startAtIndx; i < str.Length; i++)
            {
                if (!excludeChars.Contains(str[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public static bool IsNextStr(this string source, int startIndex, string nextStr)
        {
            if (source.Length >= startIndex + nextStr.Length)
            {
                return source.Substring(startIndex, nextStr.Length) == nextStr;
            }

            return false;
        }

        /// <summary>
        /// get string from index to index (both inclusive)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="fromi"></param>
        /// <param name="toi"></param>
        /// <returns></returns>
        public static string FromTo(this string str, int fromi, int toi)
        {
            return str.Substring(fromi, toi - fromi + 1);
        }

        public static string[] RemStartSpace(string[] lines)
        {
            var res = lines;
            int? minws = null;
            foreach (var line in res)
            {
                if (line.Length == 0) continue;

                var lmin = 0;
                foreach (var ch in line)
                {
                    if (ch == ' ') lmin++;
                    else break;
                }

                if (minws == null || lmin < minws) minws = lmin;
            }

            if (minws.HasValue)
            {
                for (var i = 0; i < res.Length; i++)
                {
                    var line = res[i];
                    if (line.Length != 0)
                    {
                        res[i] = line.Substring(minws.Value);
                    }
                }
            }

            return res;
        }
    }
}