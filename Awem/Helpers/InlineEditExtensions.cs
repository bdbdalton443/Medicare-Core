using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class InlineEditExtensions
    {
        /// <summary>
        /// Inline hidden input for Id column, will use "Id" as name if bind or valprop is not specified
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="valProp">grid model property to get value from, when not set will use Column.Bind</param>
        /// <param name="modelProp">viewmodel property to match in the edit/create action, when not set valProp will be used</param>
        /// <returns></returns>
        public static T InlineId<T>(this T builder, string valProp = null, string modelProp = null) where T : IInlColBuilder
        {
            valProp = valProp ?? builder.Column.Bind ?? "Id";
            modelProp = modelProp ?? valProp;
            var format = "<input id='#Prefix" + modelProp + "' type='hidden' name='" + modelProp + "' value='#Value'>#Value";
            setFormat(builder, format, valProp, modelProp);
            return builder;
        }

        /// <summary>
        /// Inline hidden input
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="valProp">grid model property to get value from, when not set will use Column.Bind</param>
        /// <param name="modelProp">viewmodel property to match in the edit/create action, when not set valProp will be used</param>        
        public static T InlineHidden<T>(this T builder, string valProp = null, string modelProp = null) where T : IInlColBuilder
        {
            valProp = valProp ?? builder.Column.Bind;
            modelProp = modelProp ?? valProp;
            var format = "<input id='#Prefix" + modelProp + "' type='hidden' name='" + modelProp + "' value='#Value'>";
            setFormat(builder, format, valProp, modelProp);
            return builder;
        }

        /// <summary>
        /// set inline format for the column; value from valProp is used to replace #Value in the format
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        /// <param name="builder"></param>
        /// <param name="helper">awesome editor helper</param>
        /// <param name="valProp">grid model property to get value from, when not set will use helper's Name </param>
        /// <returns></returns>
        public static T Inline<T, TH>(this T builder, IAwesomeHelper<TH> helper, string valProp = null) where T : IInlColBuilder
        {
            helper.Svalue("#Value");
            helper.Prefix("#Prefix");

            setFormat(builder, helper, valProp);
            
            return builder;
        }

        /// <summary>
        /// set inline format for the column; value from valProp is used to replace #Value in the format
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="format">editor string format, #Value and #Prefix will be replaced, prefix is used for unique ids </param>
        /// <param name="valProp">grid model property to get value from, when not set will use Column.Bind</param>
        /// <param name="modelProp">viewmodel property to match in the edit/create action, when not set valProp will be used, used for validation only here, you set the input name in the string format</param>
        /// <returns></returns>
        public static T Inline<T>(this T builder, string format, string valProp = null, string modelProp = null) where T : IInlColBuilder
        {
            setFormat(builder, format, valProp, modelProp);
            return builder;
        }

        /// <summary>
        /// set readonly inline format for the column
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="displayFormat">display format, .Prop will be replaced with values from the grid row model </param>
        /// <param name="valProp">grid model property to get value from, when not set will use Column.Bind</param>
        /// <param name="modelProp">viewmodel property to match in the edit/create action, when not set valProp will be used, used for validation only here, you set the input name in the string format</param>
        /// <returns></returns>
        public static T InlineReadonly<T>(this T builder, string displayFormat = null, string valProp = null, string modelProp = null) where T: IInlColBuilder
        {
            valProp = valProp ?? builder.Column.Bind;
            modelProp = modelProp ?? valProp;

            displayFormat = displayFormat ?? builder.Column.ClientFormat ?? "#Value";

            var format = displayFormat + "<input type='hidden' name='" + modelProp + "' value='#Value'/>";
            
            setFormat(builder, format, valProp, modelProp);

            return builder;
        }

        /// <summary>
        /// Inline checkbox, by default will use column.Bind + "Checked" for valueProp and column.Bind for modelProp
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="valProp">grid model property to get value from, when not set will use Column.Bind</param>
        /// <param name="modelProp">viewmodel property to match in the edit/create action, when not set valProp will be used</param>
        /// <param name="cssClass">css class for the checkbox input</param>
        /// <returns></returns>
        public static T InlineBool<T>(this T builder, string valProp = null, string modelProp = null, string cssClass = "") where T : IInlColBuilder
        {
            valProp = valProp ?? builder.Column.Bind;
            modelProp = modelProp ?? valProp;

            var format = "<input type='checkbox' name='" + modelProp + "' value='true' #ValChecked class='" + cssClass + "' />";
            setFormat(builder, format, valProp, modelProp);

            return builder;
        }

        private static void setFormat(IInlColBuilder builder, string format, string valProp, string modelProp = null, string jsformat = null)
        {
            valProp = valProp ?? builder.Column.Bind;
            modelProp = modelProp ?? valProp;

            builder.AddInline(new InlElem { Format = format, ModelProp = modelProp, ValProp = valProp, JsFormat = jsformat });
        }

        private static void setFormat<T>(IInlColBuilder builder, IAwesomeHelper<T> helper, string valProp, string modelProp = null)
        {
            string format, jsformat = null;
            var prender = helper as IPartRender<object>;
            if (prender != null)
            {
                var parts = prender.GetParts();
                format = parts[0];
                jsformat = parts[1];
            }
            else
            {
                format = helper.ToString();
            }

            setFormat(builder, format, valProp ?? helper.Awe.Prop, modelProp ?? helper.Awe.Prop, jsformat);
        }
    }
}