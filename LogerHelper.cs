using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDownLoadFile
{
    internal class LogerHelper
    {
        private static string logFilePath = @"D:\TPBackup\AutoDown\log\AutoDownLoadFile.log";

        public static void WriteLog(string message)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {message}");
                }
            }
            catch (Exception ex)
            {
                // 处理异常，例如写入错误到另一个日志文件或窗口
                Console.WriteLine($"Error writing to log: {ex.Message}");
            }
        }
    }
}
