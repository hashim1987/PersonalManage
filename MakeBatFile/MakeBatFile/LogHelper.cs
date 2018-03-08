using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace MakeBatFile
{
    public class LogHelper
    {
        #region variable
        private static string logPath = @"./ErrorLog/";
        private static string errorFileName = @"ErrorLog.log";
        private static string infoFileName = @"InfoLog.log";
        //private static string maxFileSize = "1";//最大文件大小

        private static readonly object locker = new object();
        const bool methodFlag = true;

        private static LogHelper instance;
        #endregion

        #region Constructor
        private LogHelper()
        {
            lock (locker)
            {
                if (!System.IO.Directory.Exists(logPath))
                {
                    System.IO.Directory.CreateDirectory(logPath);
                }

                string errFilePath = logPath + "\\" + errorFileName;
                if (!System.IO.File.Exists(errFilePath))
                {
                    FileStream fs = System.IO.File.Create(errFilePath);
                    fs.Close();
                }

                string infoFilePath = logPath + "\\" + infoFileName;
                if (!System.IO.File.Exists(infoFilePath))
                {
                    FileStream fs = System.IO.File.Create(infoFilePath);
                    fs.Close();
                }
            }

        }
        #endregion

        public static LogHelper Instance
        {
            get 
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new LogHelper();
                        }
                    }
                }
                return instance;
            }
        }

        private void Log(string logType, string message)
        {
            try
            {
                lock (locker)
                {
                    string exStr = string.Empty;
                    StackTrace st = new StackTrace(true);
                    string method_name = st.GetFrame(2).GetMethod().Name.ToString();
                    string name_space = st.GetFrame(2).GetMethod().DeclaringType.FullName.ToString();
                    string timeStr = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string funcName = name_space + "::" + method_name;
                    string filePath;

                    switch (logType)
                    {
                        case "Error":
                            {
                                filePath = logPath + errorFileName;
                                System.IO.StreamWriter objWStream = new System.IO.StreamWriter(filePath, true, System.Text.Encoding.Default);
                                objWStream.WriteLine(timeStr + " " + funcName + ":" + message);
                                objWStream.Close();
                                objWStream = null;
                            }

                            break;
                        case "Info":
                            {
                                filePath = logPath + infoFileName;
                                System.IO.StreamWriter objWStream = new System.IO.StreamWriter(filePath, true, System.Text.Encoding.Default);
                                objWStream.WriteLine(timeStr + " " + funcName + ":" + message);
                                objWStream.Close();
                                objWStream = null;
                            }
                            break;
                        case "Debug":
                            {
                                Console.WriteLine(timeStr + " " + funcName + ":" + message);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (System.Exception ex)
            {
                string str = string.Format("LogError:{0}" + ex.Message);
                Console.WriteLine(str);
            }
        }

        public void WriteError(string message)
        {
            Log("Error", message);
        }

        public void WriteError(string message, Exception excep)
        {
            string exMsg = excep.Message;
            string tempStr = message + "  |  Exception:" + exMsg;
            Log("Error", tempStr);
        }

        public void WriteInfo(string message)
        {
            Log("Info", message);
        }

        public void WriteInfo(string message, Exception excep)
        {
            string exMsg = excep.Message;
            string tempStr = message + "  |  Exception:" + exMsg;
            Log("Info", tempStr);
        }

        public void WriteDebug(string message)
        {
            Log("Debug", message);
        }

        public void WriteDebug(string message, Exception excep)
        {
            string exMsg = excep.Message;
            string tempStr = message + "  |  Exception:" + exMsg;
            Log("Debug", tempStr);
        }
    }
}
