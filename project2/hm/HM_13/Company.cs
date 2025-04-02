using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_13
{
    internal class Company
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Profile { get; set; }
        public string DirectorFullName { get; set; }
        public int NumOfWorkers { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }
        public Company(string name, string foundDate, string profile, string directorFullName, int numOfWorkers, string address)
        {
            Name = name;
            FoundationDate = DateTime.Parse(foundDate);
            Profile = profile;
            DirectorFullName = directorFullName;
            NumOfWorkers = numOfWorkers;
            Address = address;
            Employees = new List<Employee>();
        }
        public void HireEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public override string ToString()
        {
            return $"Company name: {Name}. Foundation date: {FoundationDate}. Company profile: {Profile}. " +
                $"Director full name: {DirectorFullName}. Number of workers: {NumOfWorkers}. Address: {Address}";
        }


    }

    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string pos, string phoneNumber, string email, int salary)
        {
            Name = name; Position = pos;
            PhoneNumber = phoneNumber; 
            Email = email; 
            Salary = salary;
        }
    }
}
