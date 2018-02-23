using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTestForTraining
{
    public class TxtRecorder
    {
        public TxtRecorder()
        {
        }

        public void TxtWrite(string message,string prefixFileName)
        {
            try
            {
                string dir = System.Environment.CurrentDirectory + $"\\{prefixFileName}\\";
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                string path = dir + DateTime.Now.ToString("yyyy-MM-dd-HH") + ".txt";
                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    //开始写入
                    sw.WriteLine(message);
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                }
                else
                {
                    var fs = File.AppendText(path);
                    fs.WriteLine($"[{DateTime.Now.ToLongTimeString()}]{message}");
                    fs.Flush();
                    fs.Close();
                }
            }
            catch (Exception ex) { }
        }
        //public void TxtWriteWarning(string message)
        //{
        //    try
        //    {
        //        string dir = System.Environment.CurrentDirectory + "\\AiTestWarning\\";
        //        if (!Directory.Exists(dir))
        //            Directory.CreateDirectory(dir);
        //        string path = dir + "Warning" + DateTime.Now.ToString("yyyy-MM-dd-HH") + ".txt";
        //        if (!File.Exists(path))
        //        {
        //            FileStream fs = new FileStream(path, FileMode.Create);
        //            StreamWriter sw = new StreamWriter(fs);
        //            //开始写入
        //            sw.WriteLine(message);
        //            //清空缓冲区
        //            sw.Flush();
        //            //关闭流
        //            sw.Close();
        //            fs.Close();
        //        }
        //        else
        //        {
        //            var fs = File.AppendText(path);
        //            fs.WriteLine($"[{DateTime.Now.ToLongTimeString()}]{message}");
        //            fs.Flush();
        //            fs.Close();
        //        }
        //    }
        //    catch (Exception ex) { }
        //}
    }
}
