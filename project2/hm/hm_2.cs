using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project2.hm
{
    internal class hm_2
    {
        internal static void t1()
        {
            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            double[,] B = new double[3, 4];
            System.Random rand = new System.Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.Next(1, 100);

                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                Console.Write(A[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            double Bmax = B[0, 0];
            int Amax = A.Max();
            double Bmin = B[0, 0];
            int Amin = A.Min();
            int AEvenSum = 0;
            int Amult = 1;
            double Bsum = 0;
            double BOddSum = 0;
            double Bmult = 1;
            foreach (int i in B)
            {
                Bsum += i;
                Bmult *= i;
                if (Bmax < i)
                {
                    Bmax = i;
                    continue;
                }
                if (Bmin > i)
                {
                    Bmin = i;
                }
            }
            foreach (int i in A)
            {
                if (i % 2 == 0)
                {
                    AEvenSum += i;
                }
                Amult *= i;
            }
            for (int i = 0; (i < B.GetLength(1)); i++)
            {
                if ((i % 2) != 0)
                {
                    for (int j = 0; j < B.GetLength(0); j++)
                    {
                        BOddSum += B[j, i];
                    }
                }
            }
            Console.WriteLine($"Max val in A: {Amax}");
            Console.WriteLine($"Max val in B: {Bmax}");
            Console.WriteLine($"Min val in A: {Amin}");
            Console.WriteLine($"Min val in B: {Bmin}"); 
            Console.WriteLine($"Sumary in A = {A.Sum()}");
            Console.WriteLine($"Sumary in B = {Bsum}");
            Console.WriteLine($"Even sumary in A = {AEvenSum}");
            Console.WriteLine($"Odd column sumary in B = {BOddSum}");
            Console.WriteLine($"Multiplication in A = {Amult}");
            Console.WriteLine($"Multiplication in B = {Bmult}");
        }
        internal static void t2()
        {
            int[,] arr = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-100, 100);
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int max = arr[0, 0];
            int MaxUpperIndex = 0;
            int MaxLowerIndex = 0;
            int min = arr[0, 0];
            int MinUpperIndex = 0;
            int MinLowerIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if( arr[i, j] > max )
                    {
                        max = arr[i, j];
                        MaxUpperIndex = i;
                        MaxLowerIndex = j;
                        continue;
                    }
                    if( arr[i, j] < min )
                    {
                        min = arr[i, j];
                        MinUpperIndex = i;
                        MinLowerIndex = j;
                    }
                }
            }
            Console.WriteLine($"Max num = {max}, index: [{MaxUpperIndex},{MaxLowerIndex}] ");
            Console.WriteLine($"Min num = {min}, index: [{MinUpperIndex},{MinLowerIndex}] ");
            int sum = 0;
            if(MinUpperIndex == MaxUpperIndex)
            {
                if (MinLowerIndex > MaxLowerIndex)
                {
                    for (int i = MaxLowerIndex + 1; i < MinLowerIndex; i++)
                    {
                        sum += arr[MinUpperIndex, i];
                    }
                }
                else 
                {
                    for (int i = MinLowerIndex + 1; i < MaxLowerIndex; i++)
                    {
                        sum += arr[MinUpperIndex, i];
                    }
                }
            }
            else if (MaxUpperIndex < MinUpperIndex)
            {
                int cur = MaxUpperIndex;
                for(int i = MaxLowerIndex + 1; i < 5; i++)
                {
                    sum += arr[MaxUpperIndex, i];
                }
                cur++;
                while(cur != MinUpperIndex)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        sum += arr[cur, i];
                    }
                    cur++;
                }
                for (int i = 0; i < MinLowerIndex; i++)
                {
                    sum += arr[MinUpperIndex, i];
                }
            }
            else 
            {
                int cur = MinUpperIndex;
                for (int i = MinLowerIndex + 1; i < 5; i++)
                {
                    sum += arr[MinUpperIndex, i];
                }
                cur++;
                while (cur != MaxUpperIndex)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sum += arr[cur, i];
                    }
                    cur++;
                }
                for (int i = 0; i < MaxLowerIndex; i++)
                {
                    sum += arr[MaxUpperIndex, i];
                }
            }

            Console.WriteLine($"Summary between = {sum}");
        }
        internal static void t3(int key)
        {
            string str = Console.ReadLine();
            string encryptedStr = new string("");
            string ReEncryptedStr = new string("");
            for (int i = 0;i < str.Length;i++)
            {
                if (char.IsLetter(str[i]))
                {
                    char ch;
                    if (str[i] + key > 122)
                    {
                        ch = (char)(97 + (str[i] - 122) + key - 1);
                        encryptedStr += ch;
                        Console.WriteLine(ch);

                        continue;
                    }
                    else if (str[i] + key > 90 && str[i] + key < 97)
                    {
                        ch = (char)(65 + (str[i] - 90) + key - 1);
                        encryptedStr += ch;
                        Console.WriteLine(ch);
                        continue;
                    }
                    ch = (char)(str[i] + key);
                    Console.WriteLine(ch);
                    encryptedStr += ch;
                }
                else
                {
                    encryptedStr += str[i];
                }
            }
            Console.WriteLine("Encrypted text: ");
            Console.WriteLine(encryptedStr);
            for (int i = 0; i < encryptedStr.Length; i++)
            {
                if (char.IsLetter(encryptedStr[i]))
                {
                    char ch;
                    if (encryptedStr[i] - key < 65)
                    {
                        ch = (char)(90 + (encryptedStr[i] - 65) - key + 1);
                        ReEncryptedStr += ch;
                        Console.WriteLine(ch);

                        continue;
                    }
                    else if (encryptedStr[i] - key > 90 && encryptedStr[i] - key < 97)
                    {
                        ch = (char)(122 + (encryptedStr[i] - 97) - key + 1);
                        ReEncryptedStr += ch;
                        Console.WriteLine(ch);
                        continue;
                    }
                    ch = (char)(encryptedStr[i] - key);
                    Console.WriteLine(ch);
                    ReEncryptedStr += ch;
                }
                else
                {
                    ReEncryptedStr += str[i];
                }
            }
            Console.WriteLine("ReEncrypted text: ");
            Console.WriteLine(ReEncryptedStr);
        }
        internal static void t4()
        {
            int[,] Matrix1 = new int[5, 5];
            int[,] Matrix2 = new int[5, 5];
            System.Random rand = new System.Random();
            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix1.GetLength(1); j++)
                {
                    Matrix1[i, j] = rand.Next(1, 100);
                    Matrix2[i, j] = rand.Next(1, 100);

                }
            }
            Console.WriteLine("Matrix 1");
            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix1.GetLength(1); j++)
                {
                    Console.Write(Matrix1[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matrix 2");
            for (int i = 0; i < Matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix2.GetLength(1); j++)
                {
                    Console.Write(Matrix2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("1 - multiple matrix by num");
            Console.WriteLine("2 - add matrix to matrix");
            Console.WriteLine("3 - matrix times matrix");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int[,] Matrix3 = new int[5, 5];
                    int[,] Matrix4 = new int[5, 5];
                    Console.WriteLine("Enter multiplayer: ");
                    int num = int.Parse(Console.ReadLine());
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Matrix3[i, j] = Matrix1[i, j] * num;
                            Matrix4[i, j] = Matrix2[i, j] * num;
                        }
                    }
                    Console.WriteLine("Matrix 3");
                    for (int i = 0; i < Matrix3.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix3.GetLength(1); j++)
                        {
                            Console.Write(Matrix3[i, j]);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Matrix 4");
                    for (int i = 0; i < Matrix4.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix4.GetLength(1); j++)
                        {
                            Console.Write(Matrix4[i, j]);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    int[,] Matrix5 = new int[5, 5];
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Matrix5[i, j] = Matrix1[i, j] + Matrix2[i, j];
                        }
                    }
                    Console.WriteLine("Matrix 5");
                    for (int i = 0; i < Matrix5.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix5.GetLength(1); j++)
                        {
                            Console.Write(Matrix5[i, j]);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    int[,] Matrix6 = new int[5, 5];
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Matrix6[i, j] = Matrix1[i, j] * Matrix2[i, j];
                        }
                    }
                    Console.WriteLine("Matrix 6");
                    for (int i = 0; i < Matrix6.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix6.GetLength(1); j++)
                        {
                            Console.Write(Matrix6[i, j]);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;

            }

        }
        internal static void t5()
        {
            string example = Console.ReadLine();
            string num1 = new string("");
            char op = ' ';
            string num2 = new string("");
            int temp = 0;
            for(int i = 0; i < example.Length; i++)
            {
                char ch = example[i];
                if (char.IsDigit(ch))
                {
                    if (num1 == "")
                    {
                        for(; char.IsDigit(example[i]); i++)
                        {
                            num1 += example[i];
                        }
                        i--;
                    }
                    else
                    {
                        for (;i < example.Length && char.IsDigit(example[i]); i++)
                        {
                            num2 += example[i];
                        }
                    }
                }
                else
                {
                    if (ch == '+' || ch == '-')
                    {
                        op = ch;
                    }
                }
            }
            int x1 = int.Parse(num1);
            int x2 = int.Parse(num2);
            if (op == '+')
            {
                Console.WriteLine(x1 + x2);
            }
            else if (op == '-')
            {
                Console.WriteLine(x1 - x2);
            }
        }
        internal static void t6()
        {
            string str = Console.ReadLine();
            string outStr = new string("");
            bool isNextUpper = true;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if(char.IsLetter(ch))
                {
                    if(isNextUpper)
                    {
                        outStr += char.ToUpper(str[i]);
                        isNextUpper = false;
                        continue;
                    }
                }
                if (ch == '.')
                {
                    isNextUpper = true;
                }
                outStr += ch;
            }
            Console.WriteLine(outStr);

        }
        internal static void t7()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string stars = new string('*', word.Length);
            string outText = text.Replace(word, stars);
            int res = 0;
            for (int i = 0; i < outText.Length; i++)
            {
                if (outText[i] == '*')
                {
                    res++;
                }   
            }
            res /= word.Length;
            Console.WriteLine(outText);
            Console.WriteLine($"word die occured {res} times");
        }
        internal static void t8()
        {
            string str = Console.ReadLine();
            int key = int.Parse(Console.ReadLine());
            string encryptedStr = new string("");
            string ReEncryptedStr = new string("");
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    char ch;
                    if (str[i] + key > 122)
                    {
                        ch = (char)(97 + (str[i] - 122) + key - 1);
                        encryptedStr += ch;
                        Console.WriteLine(ch);

                        continue;
                    }
                    else if (str[i] + key > 90 && str[i] + key < 97)
                    {
                        ch = (char)(65 + (str[i] - 90) + key - 1);
                        encryptedStr += ch;
                        Console.WriteLine(ch);
                        continue;
                    }
                    ch = (char)(str[i] + key);
                    Console.WriteLine(ch);
                    encryptedStr += ch;
                }
                else
                {
                    encryptedStr += str[i];
                }
            }
            Console.WriteLine("Encrypted text: ");
            Console.WriteLine(encryptedStr);
            for (int i = 0; i < encryptedStr.Length; i++)
            {
                if (char.IsLetter(encryptedStr[i]))
                {
                    char ch;
                    if (encryptedStr[i] - key < 65)
                    {
                        ch = (char)(90 + (encryptedStr[i] - 65) - key + 1);
                        ReEncryptedStr += ch;
                        Console.WriteLine(ch);

                        continue;
                    }
                    else if (encryptedStr[i] - key > 90 && encryptedStr[i] - key < 97)
                    {
                        ch = (char)(122 + (encryptedStr[i] - 97) - key + 1);
                        ReEncryptedStr += ch;
                        Console.WriteLine(ch);
                        continue;
                    }
                    ch = (char)(encryptedStr[i] - key);
                    Console.WriteLine(ch);
                    ReEncryptedStr += ch;
                }
                else
                {
                    ReEncryptedStr += str[i];
                }
            }
            Console.WriteLine("ReEncrypted text: ");
            Console.WriteLine(ReEncryptedStr);
        }
        internal static void t9()
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int x = 0, y = 0, multiplier = 0;
            int temp = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    while (i < str.Length && char.IsDigit(str[i]))
                    {
                        sb.Append(str[i]);
                        i++;
                    }
                    switch (temp)
                    {
                        case 0:
                            x = int.Parse(sb.ToString());
                            break;
                        case 1:
                            y = int.Parse(sb.ToString());
                            break;
                        case 2:
                            multiplier = int.Parse(sb.ToString());
                            break;
                    }
                    temp++;
                    sb.Clear();
                }
            }
            int[,] matrix = new int[x, y];
            Random r = new Random();
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    matrix[i, j] = r.Next(0, 100) * multiplier;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
