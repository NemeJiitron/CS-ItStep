using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace project2.hm
{
    internal class hm_3
    {
        public static void Square(int length, char sym)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(sym + " ");
                }
                Console.WriteLine();
            }
        }
        public static bool IsPalindrom(int num)
        {
            string number = num.ToString();
            bool res = true;
            for (int i = 0, j = number.Length - 1; i < number.Length / 2; i++, j--)
            {
                if (number[i] != number[j])
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
        public static int[] Filter(int[] input, int[] filter)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < filter.Length; j++)
                {
                    if (input[i] == filter[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            int[] output = new int[input.Length - count];
            for (int i = 0, n = 0; i < input.Length; i++)
            {
                bool isIn = false;
                for (int j = 0; j < filter.Length; j++)
                {
                    if (input[i] == filter[j])
                    {
                        isIn = true;
                        break;
                    }
                }
                if (!isIn)
                {
                    output[n] = input[i];
                    n++;
                }
            }
            return output;
        }
    }
    public class WebSite
    {
        private string name;
        private string path;
        private string description;
        private string adress;
        public void SetValue(string name, string path, string description, string adress)
        {
            this.name = name;
            this.path = path;
            this.description = description;
            this.adress = adress;
        }
        public void PrintValues()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Path: " + path);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Adress: " + adress);
        }
        public string getName(){ return name; }
        public void setName(string name) { this.name = name; }
        public string getPath() { return path; }
        public void setPath(string path) { this.path = path; }
        public string getDescription() { return description; }
        public void setDescription(string description) { this.description = description; }
        public string getAdress() { return adress; }
        public void setAdress(string adress) { this.adress = adress; }
    }

    public class Journal
    {
        private string name;
        private string foundationYear;
        private string description;
        private string contactNumber;
        public void SetValue(string name, string foundationYear, string description, string contactNumber)
        {
            this.name = name;
            this.foundationYear = foundationYear;
            this.description = description;
            this.contactNumber = contactNumber;
        }
        public void PrintValues()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Foundation Year: " + foundationYear);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Contact Number: " + contactNumber);
        }
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }
        public string getFoundation_Year() { return contactNumber; }
        public void setFoundation_Year(string foundationYear) { this.foundationYear = foundationYear; }
        public string getDescription() { return description; }
        public void setDescription(string description) { this.description = description; }
        public string getContact_Number() { return contactNumber; }
        public void setContact_Number(string contactNumber) { this.contactNumber = contactNumber; }
    }

    public class Shop
    {
        private string name;
        private string adress;
        private string description;
        private string contactNumber;
        public void SetValue(string name, string adress, string description, string contactNumber)
        {
            this.name = name;
            this.adress = adress;
            this.description = description;
            this.contactNumber = contactNumber;
        }
        public void PrintValues()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Adress: " + adress);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Contact Number: " + contactNumber);
        }
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }
        public string getAdress() { return adress; }
        public void setAdress(string adress) { this.adress = adress; }
        public string getDescription() { return description; }
        public void setDescription(string description) { this.description = description; }
        public string getContact_Number() { return contactNumber; }
        public void setContact_Number(string contactNumber) { this.contactNumber = contactNumber; }
    }

    public class Tank
    {
        private float volume;
        private string material;
        private bool isFilled;
        public Tank(float volume, string material, bool isFilled)
        {
            this.volume = volume;
            this.material = material;
            this.isFilled = isFilled;
        }
        public Tank(float volume, string material) :this(volume, material, false) {}
        public Tank(float volume) : this(volume, "", false) { }
        public void Fill()
        {
            isFilled = true;
        }
        public void Unload()
        {
            isFilled = false;
        }
        public void PrintValues()
        {
            Console.WriteLine("Volume: " + volume.ToString());
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Is filled: " + isFilled.ToString());
        }
        
    }

}
