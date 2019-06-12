using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareSln
{
    class Program
    {
        private static string defaultPath = "C:" + Path.DirectorySeparatorChar + "Users" + Path.DirectorySeparatorChar + "Andrei" + Path.DirectorySeparatorChar +
            "Documents" + Path.DirectorySeparatorChar + "Visual Studio 2015" + Path.DirectorySeparatorChar + "Projects" + Path.DirectorySeparatorChar +
            "BeginnersFall2017";
        public static void Main(string[] args)
        {
            CleanFolder(defaultPath);
        }

        private static void CleanFolder(string path)
        {
            string[] folders = Directory.GetDirectories(path);
            if (folders.Length == 0)
            {
                return;
            }
            foreach (string folder in folders)
            {
                if (folder == path + Path.DirectorySeparatorChar + "bin" || folder == path + Path.DirectorySeparatorChar + "obj")
                {
                    Directory.Delete(folder, true);
                }
                else
                {
                    CleanFolder(folder);
                }
            }
        }
    }
}
