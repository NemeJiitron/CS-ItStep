using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace project2.Exam_Practice.DictApp
{
    internal class DictFileManager
    {
        private string path;
        public DictFileManager(string path) { this.path = path; }
        public List<DictionaryManager> Load()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return JsonSerializer.Deserialize<List<DictionaryManager>>(sr.ReadToEnd());
            }
        }
        public void Save(List<DictionaryManager> dictionaries)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonSerializer.Serialize(dictionaries));
            }
        }
    }
}
