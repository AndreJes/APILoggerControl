using APILoggerControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILoggerControl.Model
{
    public class DateOptions
    {
        public bool LogTime { get; set; }
        public string DateFormat { get; set; }
        public IList<TextDecorationOptions> TextOptions { get; set; }

        public DateOptions(params TextDecorationOptions[] options)
        {
            LogTime = true;
            DateFormat = "dd/MM/yyyy HH:mm:ss";
            TextOptions = options;
        }
    }
}
