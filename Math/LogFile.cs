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
            var path = @"Desktop\Math\";
            var fileName  = Today + " Log.txt";
            var parentpath = GetParent(path, fileName);
            
            
            //var parentpath = System.IO.Path.Combine(path, @"..\..\..\..\..\..\..");
            //var parentpath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(path).ToString()).ToString();
            return parentpath;

        }

        private static string GetParent(string parentName, string FileName)
        {
            var dir = new DirectoryInfo(parentName+FileName);
            var dirName = dir.Parent.Name;
            while (dirName != parentName)
            {
                dir = dir.Parent;
            }
            return dir.Parent.FullName + "\\" + FileName;
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
