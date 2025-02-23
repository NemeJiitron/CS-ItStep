using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW
{
    internal class cw4
    {
        internal static void Boxing()
        {
            int num = 100;
            object obj = num;
            //value t -> ref t        
        }
    }

    public class Point
    {
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator ++(Point self)
        {
            self.X++;
            self.Y++;
            return self;
        }

        public static Point operator --(Point self)
        {
            self.X--;
            self.Y--;
            return self;
        }

        public static Point operator +(Point self, Point other)
        {
            return new Point(self.X + other.X, self.Y + other.Y);
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                { return X; }
                else if (index == 1) { return Y; } else { return -1000000000; }
            }
            set
            {
                if (index == 0)
                {
                    X = value;
                }
                else if (index == 1)
                {
                    Y = value;
                }
            }
        }
    }

    public class Employee
    {
        public int Salary { get; set; }
        public static Employee operator +(Employee self, int dif)
        {
            self.Salary += dif;
            return self;
        }
        public static Employee operator -(Employee self, int dif)
        {
            self.Salary -= dif;
            return self;
        }
        public override string ToString()
        {
            return Salary.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static bool operator ==(Employee self, Employee other)
        {
            return self.Equals(other);
        }
        public static bool operator >(Employee self, Employee other)
        {
            return self.Salary > other.Salary;
        }
        public static bool operator <(Employee self, Employee other)
        {
            return self.Salary < other.Salary;
        }
        public static bool operator !=(Employee self, Employee other)
        {
            return !(self == other);
        }
    }

    public class Matrix
    {
        private int[,] arr;
        private Random r = new Random();
        public int Size { get; set; }

        public Matrix(int size)
        {
            Size = size;
            arr = new int[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    arr[i, j] = r.Next(0, 100);
                }
            }
        }
        public int this[int i1, int i2]
        {
            get { return arr[i1, i2]; }
            set { arr[i1, i2] = value; }
        }

        public static Matrix operator +(Matrix self, Matrix other)
        {
            Matrix matrix = new Matrix(self.Size);
            for (int i = 0; i < self.Size; i++)
            {
                for (int j = 0; j < self.Size; j++)
                {
                    matrix.arr[i, j] = self.arr[i, j] + other.arr[i, j];
                }
            }
            return matrix;
        }
        public static Matrix operator -(Matrix self, Matrix other)
        {
            Matrix matrix = new Matrix(self.Size);
            for (int i = 0; i < self.Size; i++)
            {
                for (int j = 0; j < self.Size; j++)
                {
                    matrix.arr[i, j] = self.arr[i, j] - other.arr[i, j];
                }
            }
            return matrix;
        }
        public static Matrix operator *(Matrix self, Matrix other)
        {
            Matrix matrix = new Matrix(self.Size);
            for (int i = 0; i < self.Size; i++)
            {
                for (int j = 0; j < self.Size; j++)
                {
                    matrix.arr[i, j] = self.arr[i, j] * other.arr[i, j];
                }
            }
            return matrix;
        }
        public static Matrix operator *(Matrix self, int mult)
        {
            Matrix matrix = new Matrix(self.Size);
            for (int i = 0; i < self.Size; i++)
            {
                for (int j = 0; j < self.Size; j++)
                {
                    matrix.arr[i, j] = self.arr[i, j] * mult;
                }
            }
            return matrix;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    sb.Append(arr[i, j] + " ");
                }
            }
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static bool operator ==(Matrix self, Matrix other)
        {
            return self.Equals(other);
        }
        public static bool operator !=(Matrix self, Matrix other)
        {
            return !(self == other);
        }
    }

    public class City
    {
        public int Population { get; set; }
        public static City operator +(City self, int dif)
        {
            self.Population += dif;
            return self;
        }
        public static City operator -(City self, int dif)
        {
            self.Population -= dif;
            return self;
        }
        public override string ToString()
        {
            return Population.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static bool operator ==(City self, City other)
        {
            return self.Equals(other);
        }
        public static bool operator >(City self, City other)
        {
            return self.Population > other.Population;
        }
        public static bool operator <(City self, City other)
        {
            return self.Population < other.Population;
        }
        public static bool operator !=(City self, City other)
        {
            return !(self == other);
        }
    }

    public class CreditCard
    {
        public int Balance { get; set; }
        public int CVC { get; }
        public static CreditCard operator +(CreditCard self, int dif)
        {
            self.Balance += dif; return self;
        }
        public static CreditCard operator -(CreditCard self, int dif)
        {
            self.Balance -= dif; return self;
        }
        public static bool operator ==(CreditCard self, CreditCard other)
        {
            return self.Equals(other);
        }
        public static bool operator !=(CreditCard self, CreditCard other)
        {
            return !(self == other);
        }
        public static bool operator >(CreditCard self, CreditCard other)
        {
            return self.Balance > other.Balance;
        }
        public static bool operator <(CreditCard self, CreditCard other)
        {
            return self.Balance < other.Balance;
        }
        public override string ToString()
        {
            return CVC.ToString();
        }
        public override bool Equals(object other)
        {
            return this.ToString() == other.ToString();
        }
    }
}
