using System;

namespace Omu.Awem.Export
{
    /// <summary>
    /// Grid export column
    /// </summary>
    public class ExpColumn
    {
        private string header;

        /// <summary>
        /// Column Header
        /// </summary>
        public string Header
        {
            get { return header ?? Name; }
            set { header = value; }
        }

        /// <summary>
        /// Column ClientFormat or Bind property value
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Column width
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// function receives row model and ExpColumn Name, must return cell value
        /// </summary>
        public Func<object, string, string> ClientFormatFunc { get; set; }
    }
}