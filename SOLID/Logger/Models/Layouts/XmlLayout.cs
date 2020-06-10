﻿using Logger.Models.Contracts;
using System.Text;

namespace Logger.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format => this.GetDataFormat();
        private string GetDataFormat()
        {
            StringBuilder sb = new StringBuilder();

            sb
              .AppendLine("<log>")
                .Append("<data>{0}</date>")
                .AppendLine("<level>{1}</level>")
                .AppendLine("<message>{2}</message>")
              .AppendLine("</log>");

            return sb.ToString().TrimEnd();
        }
    }
}
