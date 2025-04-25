using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.Exam_Practice.DictApp
{
    internal class DictionaryManager
    {
        public Dictionary<string, List<string>> Dict { get; set; }
        public string Type { get; set; }
        public DictionaryManager(string type)
        {
            Dict = new Dictionary<string, List<string>>();
            Type = type;
        }
        public DictionaryManager()
        {
            Dict = new Dictionary<string, List<string>>();
            Type = "";
        }
        public void AddWord(string word, string translation)
        {
            if (Dict.ContainsKey(word))
            {
                Dict[word].Add(translation);
            }
            Dict.Add(word, new List<string> { translation });
        }
        public bool AddTranslation(string word, string translation)
        {
            if (Dict.ContainsKey(word))
            {
                Dict[word].Add(translation);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ReplaceWord(string word, string newWord)
        {
            if (Dict.ContainsKey(word))
            {
                List<string> translations = Dict[word];
                Dict.Remove(word);
                Dict.Add(word, translations);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteWord(string word)
        {
            return Dict.Remove(word);
        }
        public bool DeleteTranslation(string word)
        {
            if (Dict.ContainsKey(word))
            {
                Dict[word] = new List<string>();
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder($"Type: {Type}\n");
            string[] keys = Dict.Keys.ToArray();
            for (int i = 0; i < Dict.Count; i++)
            {
                builder.Append(keys[i] + " - ");
                foreach (string val in Dict[keys[i]])
                {
                    builder.Append(val + " ");
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}
