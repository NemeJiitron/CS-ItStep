using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_8
{
    internal class File : IDisposable
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Path { get; set; }
        private bool _disposed;
        public File(string name, int size, string path)
        {
            Name = name;
            Size = size;
            Path = path;
            _disposed = false;
        }
        public override string ToString()
        {
            return $"File name: {Name}\nFile size: {Size}\nFile path: {Path}\n";
        }

        public void Dispose()
        {
            _disposed = true;
            Console.WriteLine("File" + Name + " is closed.");
        }
        public void CreateGarbage()
        {
            for (int i = 0; i < 100; i++)
            {
                File f = new("", 0, "");
            }
        }
        ~File() 
        {
            if (_disposed)
            {
                return;
            }
            Console.WriteLine("File finalizier");
        }
    }
}
