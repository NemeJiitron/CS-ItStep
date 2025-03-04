using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW
{
    internal class cw5
    {
        private three thr;
        public cw5() { thr = new(); }
        public void print()
        {
            thr.print();
        }
        
        private class one
        {
            public one()
            { Console.WriteLine("one constr"); }
            public void print()
            {
                Console.WriteLine("one print");
            }
        }
        private class two : one
        {
            public two()
            { Console.WriteLine("one constr"); }
            public void print()
            {
                base.print();
                Console.WriteLine("two print");
            }
        }
        private class three : two
        {
            public three()
            { Console.WriteLine("one constr"); }
            public void print()
            {
                base.print();
                Console.WriteLine("three print");
            }
        }
    }
    //1
    internal class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Human(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}\n");
            sb.Append($"Age: {Age}");
            return sb.ToString();
        }
    }
    internal class Builder : Human
    {
        public readonly string Rank;
        public Builder(string name, int age, string rank) : base(name, age)
        {
            Rank = rank;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Rank: {Rank}\n");
            return sb.ToString();
        }
        public void DoWork()
        {
            Console.WriteLine($"Builder {Name} is building");
        }
    }
    internal class Sailor : Human
    {
        public readonly string Rank;
        public Sailor(string name, int age, string rank) : base(name, age)
        {
            Rank = rank;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Rank: {Rank}\n");
            return sb.ToString();
        }
        public void DoWork()
        {
            Console.WriteLine($"Sailor {Name} is sailing");
        }
    }
    internal class Pilot : Human
    {
        public int Flights { get; set; }
        public Pilot(string name, int age, int flights) : base(name, age)
        {
            Flights = flights;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Flights: {Flights}\n");
            return sb.ToString();
        }
        public void DoWork()
        {
            Console.WriteLine($"Pilot {Name} is flying");
        }
    }
    
    //2
    internal class Passport
    {
        public readonly string _country;
        public readonly string _name;
        public readonly string _surname;
        public Passport(string country, string name, string surname)
        {
            _country = country;
            _name = name;
            _surname = surname;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Country: {_country}\n");
            sb.Append($"Name: {_name}\n");
            sb.Append($"Surname: {_surname}\n");
            return sb.ToString();
        }
    }
    internal class ForeignPassport : Passport
    {
        public string[] Visas;
        public readonly string serialNum;
        public ForeignPassport(string country, string name, string surname, string serialNum, string[] visas) : base(country, name, surname) 
        {
            Visas = visas;
            this.serialNum = serialNum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Serial number: {serialNum}\n");
            sb.Append($"Visas:\n");
            foreach (string visa in Visas)
            {
                sb.Append($"{visa}\n");
            }
            return sb.ToString();
        }
    }

    //3
    internal abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name) { Name = name; }
        public abstract void DoSound();
        public override string ToString()
        {
            return Name;
        }
    }
    internal abstract class Tiger : Animal
    {
        public Tiger() : base("Tiger") {}
        public override void DoSound()
        {
            Console.WriteLine("Raaarh");
        }
    }
    internal abstract class Crocodile : Animal
    {
        public Crocodile() : base("Crocodile") { }
        public override void DoSound()
        {
            Console.WriteLine("Crocodile sound");
        }
    }
    internal abstract class Kenguru : Animal
    {
        public Kenguru() : base("Kenguru") { }
        public override void DoSound()
        {
            Console.WriteLine("Kenguru sound");
        }
    }
}
