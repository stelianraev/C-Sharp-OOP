using System;
using Logger.Common;
using System.Dynamic;
using System.Globalization;
using Logger.Models.Contracts;
using Logger.Models.Enumeration;

namespace Logger.Models.Appender
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout , Level level)
        {
            this.Layout = layout;
            this.Level = level;
        }
        public ILayout Layout {get; private set;}
        public Level Level { get; private set; }

        public long MessagesAppend { get; private set; }

        public void Append(IError error)
        {
            string format = this.Layout.Format;

            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formatedMessage = String.Format(format, dateTime.ToString(GlobalConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
                message,
                level.ToString());

            Console.WriteLine(formatedMessage);
            this.MessagesAppend++;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, " +
                $"Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.Level.ToString().ToUpper()}, " +
                $"Messages appended: {this.MessagesAppend}";
        }
    }
}
