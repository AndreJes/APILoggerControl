using SimpleWPFLogger.Enums;
using SimpleWPFLogger.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleWPFLogger.UserControls
{
    /// <summary>
    /// Interação lógica para Logger.xam
    /// </summary>
    public partial class Logger : UserControl
    {

        public Logger()
        {
            InitializeComponent();
        }

        public void PrintText(Inline text, Inline separator, DateOptions options)
        {
            try
            {

                if (options.LogTime)
                {
                    LoggerText.Inlines.Add(GetLogTime(options.DateFormat, options.TextOptions));
                }

                LoggerText.Inlines.Add(separator);
                LoggerText.Inlines.Add(text);
                LoggerText.Inlines.Add(new Run(Environment.NewLine));

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EraseAll()
        {
            try
            {
                LoggerText.Text = string.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Inline GetLogTime(string dateformat, IList<TextDecorationOptions> datedecorations)
        {
            try
            {
                Run date = new Run($"[{DateTime.Now.ToString(dateformat)}]");
                foreach (TextDecorationOptions option in datedecorations)
                {
                    switch (option)
                    {
                        case TextDecorationOptions.BOLD:
                            date.FontWeight = FontWeights.Bold;
                            break;
                        case TextDecorationOptions.ITALIC:
                            date.FontStyle = FontStyles.Italic;
                            break;
                        case TextDecorationOptions.UNDERLINED:
                            date.TextDecorations.Add(TextDecorations.Underline);
                            break;
                        default:
                            break;
                    }
                }

                return date;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
