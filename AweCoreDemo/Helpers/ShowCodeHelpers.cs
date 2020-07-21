using System;
using System.IO;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using AweCoreDemo.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace AweCoreDemo.Helpers
{
    public static class ShowCodeHelpers
    {
        /// <summary>
        /// get the string value of code between the /*begin*/ and /*end*/ comment blocks  
        /// </summary>
        /// <param name="html"></param>
        /// <param name="path"> file location path</param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IHtmlContent Csrc(this IHtmlHelper html, string path, object k = null)
        {
            var startWord = "/*begin" + k + "*/";
            var endWord = "/*end" + k + "*/";

            var newpath = html.ServerMapPath() + path;
            var lines = ReadAllLines(newpath);
            var code = StrUtil.GetCode(lines, startWord, endWord);

            return new HtmlString(StrUtil.ParseStrToCode(code, path));
        }

        public static CodeHelper Util(this IHtmlHelper html, string path)
        {
            return new CodeHelper(html, path).Util();
        }

        public static CodeHelper Code(this IHtmlHelper html, string path)
        {
            return new CodeHelper(html, path);
        }

        /// <summary>
        /// get the string value of the controller code between the /*begin(key)*/ and /*end(key)*/ comment blocks 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="path"></param>
        /// <param name="k">key</param>
        /// <returns></returns>
        public static IHtmlContent Csource(this IHtmlHelper html, string path, object k = null)
        {
            var startWord = "/*begin" + k + "*/";
            var endWord = "/*end" + k + "*/";

            var newpath = Path.Combine(html.ServerMapPath(), "Controllers", path);
            var lines = ReadAllLines(newpath);

            var code = StrUtil.GetCode(lines, startWord, endWord);

            return new HtmlString(StrUtil.ParseStrToCode(code, path));
        }

        /// <summary>
        /// get the string value of js file between the /*begin*/ and /*end*/ comment blocks 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="path"></param>
        /// <param name="k">key</param>
        /// <returns></returns>
        public static IHtmlContent SourceJs(this IHtmlHelper html, string path, object k = null)
        {
            var startWord = "/*begin" + k + "*/";
            var endWord = "/*end" + k + "*/";

            var newpath = Path.Combine(html.ServerMapPath(), "Scripts", path);
            var lines = ReadAllLines(newpath);
            var code = StrUtil.GetCode(lines, startWord, endWord);

            return new HtmlString(StrUtil.ParseStrToCode(code, path));
        }

        /// <summary>
        /// get the string value of the view code located between the begin+key and end+key comment blocks
        /// </summary>
        /// <param name="html"></param>
        /// <param name="path"></param>
        /// <param name="k">key</param>
        /// <param name="wrap">wrap with div class='code'</param>
        /// <returns></returns>
        public static IHtmlContent Source(this IHtmlHelper html, string path, object k = null, bool wrap = false)
        {
            var key = k == null ? "" : k.ToString();
            var newpath = Path.Combine(html.ServerMapPath(), "Views", path);
            var lines = ReadAllLines(newpath);


            var code = path.EndsWith(".cshtml") ? StrUtil.GetCode(lines, "@*begin" + key + "*@", "@*end" + key + "*@") : StrUtil.GetCode(lines, "<%--begin" + key + "--%>", "<%--end" + key + "--%>");
            var result = StrUtil.ParseStrToCode(code, path);
            if (wrap) result = "<div class='code'>" + result + "</div>";

            return new HtmlString(result);
        }

        private static string[] ReadAllLines(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);
                return lines;
            }
            catch (Exception ex)
            {
                return new[] { ex.Message };
            }
        }

    }
}