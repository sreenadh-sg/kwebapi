using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Hosting;


namespace KentApp.Helper
{
    public class TrackException
    {

        public static void ErrorHandle(string exMessage, string ExeFunction)
        {

            string strPath = CreateLog();
            StreamWriter sw = File.AppendText(strPath);
            sw.WriteLine("Occured at: " + ExeFunction);
            sw.WriteLine("TimeStamp: " + DateTime.Now.ToString());
            sw.WriteLine("Error: " + exMessage);
            sw.WriteLine("-------------------------------------------------------------");
            sw.Dispose();
            sw.Close();
        }
        public static void TransferMessage(String data)
        {
            string strPath = CreateLog();
            StreamWriter sw = File.AppendText(strPath);
            sw.WriteLine("Received Message: " + data);
            sw.WriteLine("TimeStamp: " + DateTime.Now.ToString());
            sw.WriteLine("-------------------------------------------------------------");
            sw.Close();
        }
       
        public static string CreateLog()
        {
            string directory = HostingEnvironment.MapPath("~/Logs/");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string filename = "DDT_LOG_" + DateTime.Now.ToString("ddMMMyyyy") + ".txt";
            string strFileOpen = directory + filename;
            string path = Path.Combine(directory, filename);
            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }
            return path;
        }

       
    }
}