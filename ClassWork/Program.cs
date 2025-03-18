using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using ClassWork.CW;
using ClassWork.CW.cw6;
using ClassWork.CW.cw7;
using ClassWork.CW.cw8;
using project2.hm.HM_9;
using static ClassWork.CW.cw3;
using static ClassWork.CW.cw5;
using static ClassWork.CW.player;
using ClassWork.CW.cw10;

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

            #endregion

        }
    }
}
