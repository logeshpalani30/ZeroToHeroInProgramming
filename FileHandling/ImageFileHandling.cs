using System;
using System.IO;
using System.Text;

namespace PlayingwithCSharp.FileHandling
{
    public class ImageFileHandling
    {
        public byte[] ReadFileFromLocal(string exePath)
        {
            try
            {
                byte[] buf = new byte[1024];
                int c;

                using (FileStream fs = File.OpenRead(exePath))
                {
                    while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                    {
                        Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
                    }
                }

                return buf;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}