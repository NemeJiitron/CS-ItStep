using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.Exam_Practice.DictApp
{
    internal class Menu
    {
        public static string MainMenu(List<DictionaryManager> dict)
        {
            Console.WriteLine(
                "1 - Choose dictionary\n" +
                "2 - Add dictionary\n" +
                "3 - Delete dictionary\n" +
                "4 - Save current program state\n" +
                "0 - Quit\n");
            int choice1 = int.Parse(Console.ReadLine());
            while (choice1 != 0)
            {
                switch (choice1)
                {
                    case 1:
                        if (dict.Count == 0)
                        {
                            Console.WriteLine("No available dictionaries");
                            break;
                        }
                        for (int i = 0; i < dict.Count; i++)
                        {
                            Console.WriteLine($"{i} - {dict[i].Type}");
                        }
                        int choice2 = int.Parse(Console.ReadLine());
                        if (choice2 >= dict.Count || choice2 < 0)
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                        return $"1{choice2}";
                        break;
                    case 2:
                        return "2";
                    case 3:
                        if (dict.Count == 0)
                        {
                            Console.WriteLine("No available dictionaries");
                            break;
                        }
                        for (int i = 0; i < dict.Count; i++)
                        {
                            Console.WriteLine($"{i} - {dict[i].Type}");
                        }
                        int choice3 = int.Parse(Console.ReadLine());
                        if (choice3 >= dict.Count || choice3 < 0)
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                        return $"3{choice3}";
                    case 4:
                        return "4";
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.WriteLine(
                    "1 - Choose dictionary\n" +
                    "2 - Add dictionary\n" +
                    "3 - Delete dictionary\n" +
                    "4 - Save current program state\n" +
                    "0 - Quit\n");
                choice1 = int.Parse(Console.ReadLine());
            }

            return "-1";
        }

        public static int DictChoice()
        {
            Console.WriteLine(
                    "1 - Show all words\n" +
                    "2 - Add word\n" +
                    "3 - Add translation\n" +
                    "4 - Replace word\n" +
                    "5 - Delete word\n" +
                    "6 - Delete translation\n" +
                    "0 - Quit\n");
            int choice2 = int.Parse(Console.ReadLine());
            while (choice2 < 0 && choice2 > 6)
            {
                Console.WriteLine(
                    "Invalid input\n\n" +
                    "1 - Show all words\n" +
                    "2 - Add word\n" +
                    "3 - Add translation\n" +
                    "4 - Replace word\n" +
                    "5 - Delete word\n" +
                    "6 - Delete translation\n" +
                    "0 - Quit\n");
                choice2 = int.Parse(Console.ReadLine());
            }
            return choice2;
            
        
        }
    }
}
