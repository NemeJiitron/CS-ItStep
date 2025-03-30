using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ClassWork.CW.cw13
{
    internal class Practise
    {
        public static void run()
        {
            int[] arr = new int[16];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine();
            //      1
            IEnumerable<int> allInts =
                from num in arr
                select num;
            IEnumerable<int> Even =
                from num in arr
                where num % 2 == 0
                select num;
            IEnumerable<int> odd =
                from num in arr
                where num % 2 != 0
                select num;
            int numToCompare = 50;
            IEnumerable<int> MoreThan =
                from num in arr
                where num > numToCompare
                select num;
            int range1 = 10;
            int range2 = 80;
            IEnumerable<int> Range =
                from num in arr
                where num > range1 && num < range2
                select num;
            IEnumerable<int> DividbleBy7 =
                from num in arr
                where num % 7 == 0
                orderby num
                select num;
            IEnumerable<int> DividbleBy8 =
                from num in arr
                where num % 8 == 0
                orderby num descending
                select num;
            //      2
            string[] cities = { "Kyiv", "Lviv", "Odesa", "Kharkiv", "Dnipro", "Zaporizhzhia", "Vinnytsia", "Poltava", "Chernihiv", "Zhytomyr" };
            IEnumerable<string> allCities =
               from city in cities
               select city;
            int lengthToCompare = 7;
            IEnumerable<string> WithSetLength =
                from city in cities
                where city.Length == lengthToCompare
                select city;
            IEnumerable<string> StartWithA =
                from city in cities
                where city[0] == 'A'
                select city;
            IEnumerable<string> EndWithM =
                from city in cities
                where city[city.Length - 1] == 'm'
                select city;
            IEnumerable<string> EndAndStartWith =
                from city in cities
                where city[0] == 'N' && city[city.Length - 1] == 'k'
                select city;
            IEnumerable<string> StartWithNe =
                from city in cities
                where city[0] == 'N' && city[1] == 'e'
                select city;
            //      3
            QueryStudent[] studs = new QueryStudent[] { new("Boris", "Druhy", 45, "Sofia"), new("Kolyan", "Brotato", 15, "PTU"), new("Boris", "Gachka", 22, "NBU"), new("Katka", "Baklan", 21, "MIT") };
            IEnumerable<QueryStudent> allStuds =
               from stud in studs
               select stud;
            IEnumerable<QueryStudent> Borisi =
               from stud in studs
               where stud.Fname == "Boris"
               select stud;
            IEnumerable<QueryStudent> LnameBro =
              from stud in studs
              where stud.Lname.Contains("Bro")
              select stud;
            IEnumerable<QueryStudent> olderThan19 =
              from stud in studs
              where stud.Age > 19
              select stud;
            IEnumerable<QueryStudent> Beetween =
              from stud in studs
              where stud.Age > 20 && stud.Age < 23
              select stud;
            IEnumerable<QueryStudent> StudyAtMIT =
              from stud in studs
              where stud.StudyPlace == "MIT"
              select stud;
        }
        internal class QueryStudent
        {
            public string Fname { get; set; }
            public string Lname { get; set; }
            public int Age { get; set; }
            public string StudyPlace { get; set; }
            public QueryStudent(string fname, string lname, int age, string place)
            {
                Fname = fname;
                Lname = lname;
                Age = age;
                StudyPlace = place;
            }
        }
    }
}
