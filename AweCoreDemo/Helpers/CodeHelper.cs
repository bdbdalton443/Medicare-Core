using System;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using AweCoreDemo.Utils;

namespace AweCoreDemo.Helpers
{
    public class CodeHelper : IHtmlContent
    {
        private readonly IHtmlHelper html;
        private readonly string path;
        private string mainPath = "Controllers";
        private string[] phrase = { "public", "class" };
        private string[][] phrases;

        public CodeHelper(IHtmlHelper html, string path)
        {
            this.html = html;
            this.path = path;
        }

        public CodeHelper Util()
        {
            phrase = new[] { "public", "static", "class" };
            mainPath = "Utils";
            return this;
        }

        public CodeHelper Cont(string o)
        {
            phrase = new[] { "public", "class", o + "Controller" };
            return this;
        }

        public CodeHelper Action(string o)
        {
            phrases = new[]
            {
                new[] { "public", "IActionResult", o },
                new[] { "public", "async", "Task<IActionResult>", o }
            };

            return this;
        }

        protected string Render()
        {
            var newpath = Path.Combine(html.ServerMapPath(), mainPath, path);
            string str;
            try
            {
                str = File.ReadAllText(newpath);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            Tuple<int, int> res = null;

            if (phrases != null)
            {
                foreach (var phrs in phrases)
                {
                    var atres = StrUtil.FindMethod(str, phrs);

                    if (atres != null)
                    {
                        res = atres;
                        break;
                    }
                }
            }
            else
            {
                res = StrUtil.FindMethod(str, phrase);
            }

            var comments = StrUtil.GetCommentsAbove(str, res.Item1);

            var code = str.FromTo(res.Item1, res.Item2);

            var lines = comments.Concat(code.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)).ToArray();

            lines = StrUtil.RemStartSpace(lines);
            code = StrUtil.CodeLinesToStr(lines);
            return StrUtil.ParseStrToCode(code, path);
        }

        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            writer.Write(Render());
        }

        public override string ToString()
        {
            return Render();
        }
    }
}