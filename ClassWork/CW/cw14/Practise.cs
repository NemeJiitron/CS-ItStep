using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassWork.CW.cw14
{
    internal class Practise
    {
        public static void Run()
        {
        //      1
            
            List<int> nums = new List<int>();
            Console.WriteLine("-1 - Stop entering nums");
            string num = Console.ReadLine();
            while (num != "-1")
            {
                nums.Add(int.Parse(num));
                num = Console.ReadLine();
            }
            Console.WriteLine("1 - sort away simple\n2 - sort away Fibonacci");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    List<int> outList = new List<int>();
                    bool isSimple = true;
                    for (int i = 0; i < nums.Count; i++)
                    {
                        isSimple = true;
                        if (nums[i] < 2) { continue; }
                        for (int j = 2; j * j <= nums[i]; j++)
                        {
                            if (nums[i] % j == 0)
                            {
                                isSimple = false;
                                break;
                            }
                        }
                        if (!isSimple)
                        {
                            outList.Add(nums[i]);
                        }

                    }
                    nums = outList;
                    break;
                case "2":
                    List<int> outList2 = new List<int>();
                    int a = 0, b = 1;
                    for (int i = 0; i < nums.Count; i++)
                    {
                        a = 0;
                        b = 1;
                        while (b < nums[i])
                        {
                            int temp = b;
                            b = a + b;
                            a = temp;
                        }
                        if (!(b == nums[i]))
                        {
                            outList2.Add(nums[i]);
                        }
                    }
                    nums = outList2;
                    break;
                    default:
                    break;
            }
            foreach (int i in nums)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();

            string serializedArr = JsonSerializer.Serialize(nums);
            Console.WriteLine(serializedArr);
            using (StreamWriter sw = new StreamWriter("nums.json"))
            {
                sw.WriteLine(serializedArr);
            }
            using (StreamReader sw = new StreamReader("nums.json"))
            {
                List<int> nums2 = JsonSerializer.Deserialize<List<int>>(sw.ReadToEnd());
                foreach(int n in nums2)
                {
                    Console.Write(n.ToString() + " ");
                }
            }
        }

    }

    internal class Song
    {
        public string Name { get; set; }
        public string Length { get; set; }
        public string Genre { get; set; }
        public Song(string name, string length, string genre)
        {
            Name = name;
            Length = length;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Song name: {Name}, Length: {Length}, Genre: {Genre}. ";
        }
    }
    internal class Album
    {
        public string Name { get; set; }
        public string Musician { get; set; }
        public string ReleaseDate { get; set; }
        public string Length { get; set; }
        public string Label { get; set; }
        public Song[] Songs { get; set; }

        public Album(string name, string musician, string relDate, string length,  string label, params Song[] songs)
        {
            Name = name;
            Musician = musician;
            ReleaseDate = relDate;
            Length = length;
            Label = label;
            Songs = songs;
        }
        public Album()
        {
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{Name}, {Musician}, {ReleaseDate}, {Length}, {Label}. ");
            foreach (Song song in Songs)
            {
                sb.Append( song.ToString() );
            }
            return sb.ToString();
        }
    }
}
