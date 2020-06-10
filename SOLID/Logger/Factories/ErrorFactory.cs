using System;
using Logger.Common;
using Logger.Models.Errors;
using System.Globalization;
using Logger.Models.Contracts;
using Logger.Models.Enumeration;

namespace Logger.Factories
{
    public class ErrorFactory
    {        public IError ProduceError(string dateStr, string message, string levelStr)
        {
            DateTime dateTime;

            try
            {
                dateTime = DateTime.ParseExact(dateStr, GlobalConstants.DATE_FORMAT, CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {

                throw new ArgumentException("Invalid date format!", e);
            }

            Level level;

            bool hasParsed = Enum.TryParse<Level>(levelStr, true, out level);

            if (!hasParsed)
            {
                throw new ArgumentException("Invalid level type!");
            }

            IError error = new Error(dateTime, message, level);

            return error;

        }
    }
}
