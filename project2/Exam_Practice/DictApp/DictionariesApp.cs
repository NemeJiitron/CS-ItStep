using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.Exam_Practice.DictApp
{
    internal class DictionariesApp
    {
        private List<DictionaryManager> _dictionaries;
        private DictFileManager _dictFile;
        public DictionariesApp(string path)
        {
            _dictFile = new DictFileManager(path);
            _dictionaries = _dictFile.Load();
        }
        public void Run()
        {
            string choice = Menu.MainMenu(_dictionaries);
            while (choice != "-1")
            {
                switch (choice[0])
                {
                    case '1':
                        int index = int.Parse(choice[1].ToString());
                        int choice2 = Menu.DictChoice();
                        while (choice2 != 0)
                        {
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine(_dictionaries[index].ToString());
                                    break;
                                case 2:
                                    Console.WriteLine("Word: ");
                                    string w2 = Console.ReadLine();
                                    Console.WriteLine("Translation: ");
                                    string tr2 = Console.ReadLine();
                                    _dictionaries[index].AddWord(w2, tr2);
                                    Console.WriteLine("Word added");
                                    break;
                                case 3:
                                    Console.WriteLine("Word: ");
                                    string w3 = Console.ReadLine();
                                    Console.WriteLine("Translation: ");
                                    string tr3 = Console.ReadLine();
                                    if (!_dictionaries[index].AddTranslation(w3, tr3))
                                    {
                                        Console.WriteLine("Word not in the dictionary");
                                        break;
                                    }
                                    Console.WriteLine("Translation added");
                                    break;
                                case 4:
                                    Console.WriteLine("Word to replace: ");
                                    string ogWord = Console.ReadLine();
                                    Console.WriteLine("New word: ");
                                    string newWord = Console.ReadLine();
                                    if (!_dictionaries[index].ReplaceWord(ogWord, newWord))
                                    {
                                        Console.WriteLine("Word not in the dictionary");
                                    }
                                    Console.WriteLine("Word replaced");
                                    break;
                                case 5:
                                    Console.WriteLine("Word: ");
                                    string w5 = Console.ReadLine();
                                    if (_dictionaries[index].DeleteWord(w5))
                                    {
                                        Console.WriteLine("Word not in the dictionary");
                                        break;
                                    }
                                    Console.WriteLine("Word deleted");
                                    break;
                                case 6:
                                    Console.WriteLine("Word: ");
                                    string w6 = Console.ReadLine();
                                    if (_dictionaries[index].DeleteTranslation(w6))
                                    {
                                        Console.WriteLine("Word not in the dictionary");
                                        break;
                                    }
                                    Console.WriteLine("Word deleted");
                                    break;
                            }
                            choice2 = Menu.DictChoice();
                        }
                        break;
                    case '2':
                        Console.WriteLine("Dictionary type (e.g. lang1 - lang2 ):");
                        string type = Console.ReadLine();
                        while (type.Split('-').Length != 2)
                        {
                            Console.WriteLine("Dictionary type (e.g. lang1 - lang2 ):");
                            type = Console.ReadLine();
                        }
                        _dictionaries.Add(new DictionaryManager(type));
                        break;
                    case '3':
                        _dictionaries.RemoveAt(int.Parse(choice[1].ToString()));
                        break;
                    case '4':
                        _dictFile.Save(_dictionaries);
                        Console.WriteLine("Dictionaries saved");
                        break;
                }
                choice = Menu.MainMenu(_dictionaries);
            }
        }
        
    }
}
