using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class WriteLog
    {

        //BEGIN: grupo #1
        private static string _FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

        public static void Write(string pMessage)
        {
            string path, text;
            try
            {
                //path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Exxis_log_" + DateTime.Today.ToString("yyyyMM") + ".txt";
                path = _FolderPath + "\\Exxis_log_" + DateTime.Today.ToString("yyyyMM") + ".txt";
                text = DateTime.Now.ToString() + ". " + pMessage + Environment.NewLine;

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, text);
                }
                else
                {
                    File.AppendAllText(path, text);
                }

            }
            catch { }
        }

        private static void WriteMessage(string pMessage)
        {
            string path, text;
            try
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Exxis_message_log_" + DateTime.Today.ToString("yyyyMM") + ".txt";
                text = DateTime.Now.ToString() + ". " + pMessage + Environment.NewLine;

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, text);
                }
                else
                {
                    File.AppendAllText(path, text);
                }

            }
            catch { }
        }

        private static void WriteStackTrace(string pTrace)
        {
            string path, text;
            try
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Exxis_stacktrace_log_" + DateTime.Today.ToString("yyyyMM") + ".txt";
                text = DateTime.Now.ToString() + ". " + pTrace + Environment.NewLine;

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, text);
                }
                else
                {
                    File.AppendAllText(path, text);
                }

            }
            catch { }
        }
        //END: grupo #1

        //BEGIN: grupo #3
        public static void Write(Exception e)
        {
            try
            {
                Write("Mensaje: " + e.Message);
                Write("StackTrace: " + e.StackTrace);
            }
            catch { }
        }
        //END: grupo #3
    }
}
