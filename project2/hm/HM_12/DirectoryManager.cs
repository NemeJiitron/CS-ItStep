using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_12
{
    internal class DirectoryManager
    {
        public static void SearchByMask(string dir, string mask)
        {
            if (Directory.Exists(dir))
            {
                string[] files = Directory.GetFiles(dir, mask, SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Nonexistant path");
            }
        }
        public static void DeleteByMask(string dir, string mask)
        {
            if (Directory.Exists(dir))
            {
                string[] files = Directory.GetFiles(dir, mask, SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            else
            {
                Console.WriteLine("Nonexistant path");
            }
        }
    }
}
