using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Math
{
    public static class LogFile

    {
        private static string logPath()
        {
            var Today = DateTime.Now.ToString("yyyyMMdd");
            return @"Desktop\Math\" + Today + " Log.txt";
        }
        
        
            private static void CreateFile()
        {
            var path = logPath();
            
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }

        }

        public static void SaveInFile(string log)
        {
            CreateFile();

            var path = logPath();

            using (TextWriter tw = new StreamWriter(path))
            {
                tw.WriteLine("{0} - {1} Exception caught.", DateTime.Now.ToString("en-GB"), log);
                tw.Close();

            }
        }

    }
}
