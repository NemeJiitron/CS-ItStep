using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw8
{
    internal class File : IDisposable
    {
        string _fileName;
        string _filePath;
        string _data = string.Empty;
        bool _isOpened = false;
        public File(string fName, string fPath)
        {
            _fileName = fName;
            _filePath = fPath;
        }
        public void AddData(string data)
        {
            _data = data;
        }
        public void Open()
        {
            _isOpened = true;
        }
        public void Close()
        {
            _isOpened = true;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
            Close();
        }

        ~File()
        {
            if (_isOpened)
            {
                Close();
            }
        }
    }
}
