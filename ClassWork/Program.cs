using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using ClassWork.CW;
using ClassWork.CW.cw6;
using ClassWork.CW.cw7;
//using ClassWork.CW.cw8;
using project2.hm.HM_9;
using static ClassWork.CW.cw3;
using static ClassWork.CW.cw5;
using static ClassWork.CW.player;
using ClassWork.CW.cw10;
using ClassWork.CW.cw11;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CW3
            //CW.cw3.vector3 vecc = new(1,1,1);
            //cw3.vector3 vec = new(1, 2, 3);
            //cw3.vector3 vec2 = new(1, 2, 3);
            //Console.WriteLine(vector3.Equals(vec, vec2));
            //Console.WriteLine(vec.GetType());
            //Console.WriteLine(vec.ToString());
            //Console.WriteLine(vec.y);
            //vec.y = 3;
            //Console.WriteLine(vec.y);
            //player player = new();
            //player.print();
            //player.MaxHealth = 1000;
            //Console.WriteLine(player.MaxHealth);
            //Console.WriteLine();

            //int val = 0;
            //cw3.init(out val);
            //Console.WriteLine(val);

            //cw3.addten(ref val);
            //Console.WriteLine(val);

            //Console.WriteLine();
            //cw3.printnums(3, 1, 2, 3, 4, 1, 32);

            //Console.WriteLine();
            //cw3.OptinParams(3, 10);
            //Console.WriteLine(cw3.Dob(10, 20));
            //Console.WriteLine(cw3.isFibonachi(144));
            #endregion
            #region CW4
            //CW.Point p1 = new(1, 2);
            //CW.Point p2 = new(6, 4);
            //CW.Point p3 = p1 + p2;
            //Console.WriteLine(p3[0] + " ; " + p3[1]);
            //p3[0] = 0;
            //p3[1] = 0;
            //Console.WriteLine(p3[0] + " ; " + p3[1]);
            #endregion
            #region CW5
            //cw5 cw = new cw5();
            //cw.print();
            #endregion
            #region CW6
            //CW6.main();
            //Practice.t1();
            //Practice.t2();
            //try
            //{
            //    CW.cw6.CreditCard card = new CW.cw6.CreditCard("313231111", "Matvey Tkachuk", "r221");
            //    card.print();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Invalid card number");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("ctor ArgumentException exception");
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region CW7
            //CW.cw7.IMovement move = new CW.cw7.Auto();
            //move.Move();
            //move.Stop();
            //Library library = new Library();
            //foreach (Book book in library)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.WriteLine("Sorting");
            //library.Sort();
            //foreach (Book book in library)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.WriteLine("Sorting by names");
            //library.Sort(new CW.cw7.AuthorNameComparer());
            //foreach(Book book in library)
            //{
            //    Console.WriteLine(book);
            //}
            //----------------------------------------PRACTICE-------------------------------------------
            //MyArray arr = new( new int[]{ 1, 2, 3, 4, 5} );
            //arr.Show("Message");
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Search(5));
            #endregion
            #region CW8
            //CW.cw8.File file = new CW.cw8.File("test", "C:\\public\\test.txt");
            //try
            //{
            //    file.Open();
            //    file.AddData("daPODSAPO");

            //}
            //catch (Exception ex) { }
            //finally
            //{
            //    file.Dispose();
            //}

            //using(CW.cw8.File file2 = new CW.cw8.File("test", "C:\\public\\test.txt"))
            //{
            //    file.Open();
            //    file.AddData("fffffffffffffffffffffff");
            //    file.AddData("aaaaaaaaaaaaaaaaaa");
            //}
            //Film film = new("IDk", "NikitaEEnt", "Fantasy", 2.40f, "1.1.1000");
            //film.CreateGarbage();
            //Console.WriteLine(film.ToString());
            //Play play = new("IDk", "NikitaEEnt", "Fantasy", 2.40f, "N.S.Knyazin");
            //play.CreateGarbage();
            //Console.WriteLine(play.ToString());
            //Console.WriteLine(System.GC.GetTotalMemory(false));
            //System.GC.Collect();
            //Console.WriteLine(System.GC.GetTotalMemory(false));
            #endregion
            #region CW9
            //Door door = new();
            //Alarm alarm = new();
            //door.OnOpenDoor += alarm.OnDoorOpen;
            //door.OpenDoor();

            //MyDelegate.Delegate del = delegate (string msg) { Console.WriteLine(msg); };
            //del("Delegaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaate+");
            //MyDelegate.Delegate del2 = (string msg) => Console.WriteLine(msg);
            //del2("Delegaaaaaaaaae+");

            #endregion
            #region CW10
            //int num = 10;
            //Console.WriteLine(num.Odd());
            //Console.WriteLine(num.Even());
            //int num2 = 17;
            //Console.WriteLine(num2.Simple());
            //string str = "munyun";
            //Console.WriteLine(str.Vowels());
            //Console.WriteLine(str.Consonants());
            //string str2 = "munyun. munyun. munyun. munyun.";
            //Console.WriteLine(str2.Sentences());
            //Person[] people = { new Person("Nikita", "Knyazin", 16), new Person("Nick", "Knyazin", 20), new Person("Nikita", "Gryazin", 9) };
            //Console.WriteLine(people.MaxAge());
            //Console.WriteLine(people.MinAge());
            //Console.WriteLine(people.Average());

            //MyArr<CW.cw10.Employee> arr = new MyArr<CW.cw10.Employee>();
            //Console.WriteLine(arr.ToString());

            #endregion
            #region CW11
            //MyStack<int> stack = new MyStack<int>();
            //stack.Add(1);
            //stack.Add(2);
            //stack.Add(3);
            //stack.Add(4);
            //stack.Add(5);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("~~~~~~~~~~~~~~~~~");
            //MyQueue<int> q = new MyQueue<int>();
            //q.Add(1);
            //q.Add(2);
            //q.Add(3);
            //q.Add(4);
            //q.Add(5);
            //Console.WriteLine(q.Peek());
            //Console.WriteLine(q.Pop());
            //Console.WriteLine(q.Pop());

            //int[] arr1 = { 2, 34, 75, -32, 40, 7 };
            //Predicate<int> criteria1 = x => x % 2 == 0;
            //Predicate<int> criteria2 = x => x > 0;
            //int[] arr2 = GenericMethods.FilterByTwoCriteria(arr1, criteria1, criteria2);
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            //Alphabet a = new Alphabet();
            //string str = "";
            //foreach (char s in a)
            //{
            //    str += s;
            //}
            //Console.WriteLine(str);
            #endregion
            #region CW12
            //using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    byte[] buffer = Encoding.UTF8.GetBytes("hello world");
            //    fs.Write(buffer, 0, buffer.Length);
            //}
            //DirectoryInfo dir = new DirectoryInfo(".");
            //Console.WriteLine(dir.FullName);
            //Console.WriteLine(dir.CreationTime);
            //FileInfo[] fileInfos = dir.GetFiles();
            //foreach (FileInfo fileInfo in fileInfos)
            //{
            //    Console.WriteLine(fileInfo.Name + " - File." + $" {fileInfo.Length} - Size");
            //}

            //            1
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
            else
            {
                throw new Exception("Wrong path");
            }

            //            2
            using (FileStream fs = new FileStream("Task2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Read":
                        List<int> list = new List<int>();
                        StreamReader sr = new StreamReader(fs);
                        string num = "";
                        while (!sr.EndOfStream)
                        {
                            char ch = (char)sr.Read();
                            if (char.IsDigit(ch))
                            {
                                num += ch;
                            }
                            else
                            {
                                list.Add(int.Parse(num));
                                num = "";
                            }
                        }
                        if (num != "")
                        {
                            list.Add(int.Parse(num));
                        }
                        foreach (int i in list)
                        {
                            Console.Write(i.ToString() + " ");
                        }
                        break;
                    case "Write":
                        Console.Write("Range: ");
                        int size = int.Parse(Console.ReadLine());
                        string number;
                        for (int i = 0; i < size; i++)
                        {
                            number = Console.ReadLine();
                            int isParse;
                            if (int.TryParse(number, out isParse))
                            {
                                fs.Write(Encoding.UTF8.GetBytes(number + " "), 0, number.Length + 1);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            //            3
            using (FileStream evenStream = new FileStream("Even.txt", FileMode.OpenOrCreate, FileAccess.Write), oddStream = new FileStream("Odd.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                Random random = new Random();
                StreamWriter even = new StreamWriter(evenStream);
                StreamWriter odd = new StreamWriter(oddStream);
                for (int i = 0; i < 10000; i++)
                {
                    int num = random.Next();
                    if (num % 2 == 0)
                    {
                        even.WriteLine(num);
                    }
                    else
                    {
                        odd.WriteLine(num);
                    }
                }
                FileInfo evenFile = new FileInfo("Even.txt");
                FileInfo oddFile = new FileInfo("Odd.txt");
                Console.WriteLine("Even File");
                Console.WriteLine($"File name - {evenFile.Name}");
                Console.WriteLine($"Size - {evenFile.Length}");
                Console.WriteLine($"File path - {evenFile.FullName}");
                Console.WriteLine($"Creation time - {evenFile.CreationTime}");
                Console.WriteLine($"Last access time - {evenFile.LastAccessTime}");
                Console.WriteLine($"Last write time - {evenFile.LastWriteTime}");
                Console.WriteLine("Odd File");
                Console.WriteLine($"File name - {oddFile.Name}");
                Console.WriteLine($"Size - {oddFile.Length}");
                Console.WriteLine($"File path - {oddFile.FullName}");
                Console.WriteLine($"Creation time - {oddFile.CreationTime}");
                Console.WriteLine($"Last access time - {oddFile.LastAccessTime}");
                Console.WriteLine($"Last write time - {oddFile.LastWriteTime}");
            }
            #endregion
        }
    }
}
