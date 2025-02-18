namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array/String
            //Console.WriteLine("Hello, World!");
            //int[] ints = { 1, 2, 3, 4, 5 };
            //ints = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //short[,] shotrs = { { 1, 2, }, { 1, 2 }, { 1, 2 }, { 1, 2 } };

            //Console.WriteLine(shotrs.GetLength(0));
            //Console.WriteLine(shotrs.GetLength(1));
            //int[] ints2 = new int[15];
            //ints.CopyTo(ints2, 0);
            //for(int i = 0; i < ints2.Length; i++)
            //{
            //    Console.Write(ints2[i]);
            //    Console.Write(' ');
            //}
            //Console.Write('\n');
            //Console.WriteLine(ints2.GetUpperBound(0));
            //int[] ints3 = ints.Clone() as int[];
            //Console.WriteLine(Array.BinarySearch(ints, 3));

            //string interPolatedString = $"This is interpolated string. Ints[1] value {ints[0]}";
            //Console.WriteLine(interPolatedString);

            //StringBuilder strB = new StringBuilder();
            //strB.Append(149141424);
            //strB.Append(true);
            //strB.Append(true);
            //strB.Append(true);
            //strB.Append(true);
            //Console.WriteLine(strB.ToString());

            //Console.WriteLine(args[0]);
            #endregion

            //Console.WriteLine(Enum.Parse(typeof(PlayerStatus), "Online"));

            //1
            int[] arr = new int[] { 2, 3, 5, 9, 11, 2, 11, 20 };
            int par = 0, nepar = 0, uniq = 0, count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    nepar++;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    uniq++;
                }
                count = 0;
            }
            Console.WriteLine($"Even nums: {par}");
            Console.WriteLine($"Odd nums: {nepar}");
            Console.WriteLine($"Unique nums: {uniq}");

            //2
            int num = 5;
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < num)
                {
                    res++;
                }
            }
            Console.WriteLine($"Res nums: {res}");


        }

        void ShowInfo(int[] arr)
        {
            int par = 0, nepar = 0, uniq = 0, count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    nepar++;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    uniq++;
                    count = 0;
                }
            }
            Console.WriteLine($"Even nums: {par}");
            Console.WriteLine($"Odd nums: {nepar}");
            Console.WriteLine($"Unique nums: {uniq}");


        }

        void LessThan(int[] arr, int num)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < num)
                {
                    res++;
                }
            }
            Console.WriteLine($"Res nums: {res}");
        }


        enum PlayerStatus
        {
            Online, Offline, NoInfo
        }

    }
}
