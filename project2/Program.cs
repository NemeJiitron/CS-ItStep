using System;
using System.Text;
using project2.hm;
using project2.hm.HM_4;
using static project2.hm.hm_1;
using static project2.hm.hm_2;
using static project2.hm.hm_3;
using static project2.hm.HM_4.BookList;
using static project2.hm.HM_4.TemperatureArray;
using static project2.hm.HM_4.Fraction;
using static project2.hm.HM_6.Money;
using static project2.hm.HM_5.Course;
using static project2.hm.HM_5.OnlineCourse;
using project2.hm.HM_5;
using project2.hm.HM_6;
using project2.hm.HM_8;
using ClassWork.CW.cw7;
using project2.hm.HM_9;
using project2.hm.HM_10;
using project2.hm.HM_11;
using project2.hm.HM_12;
using project2.hm.HM_13;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company[] companies = new Company[]
            {
                new Company("TechSoft", "2005-03-15", "IT", "Ivan Petrenko", 120, "Kyiv, Ukraine"),
                new Company("MarketPro", "2010-06-22", "Marketing", "Olga Romanenko", 80, "Lviv, Ukraine"),
                new Company("EcoBuild", "2018-09-10", "Construction", "Dmitry Shevchenko", 150, "Odesa, Ukraine"),
                new Company("MediCare", "2000-12-01", "Healthcare", "Natalia Bondarenko", 200, "Kharkiv, Ukraine"),
                new Company("FastFood", "2015-05-30", "Food", "Serhiy Kovalenko", 90, "Dnipro, Ukraine")
            };
            #region task 1
            //IEnumerable<string> Info =
            //    from company in companies
            //    select company.ToString();
            //foreach (string info in Info)
            //{
            //    Console.WriteLine(info);
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> Food =
            //    from company in companies
            //    where company.Name.Contains("Food")
            //    select company;
            //foreach (Company comp in Food)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> Marketing =
            //    from company in companies
            //    where company.Profile.ToLower() == "marketing"
            //    select company;
            //foreach (Company comp in Marketing)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> MarketingIt =
            //    from company in companies
            //    where company.Profile.ToLower() == "marketing" || company.Profile.ToLower() == "it"
            //    select company;
            //foreach (Company comp in MarketingIt)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> WorkersMoreThan100 =
            //    from company in companies
            //    where company.NumOfWorkers > 100
            //    select company;
            //foreach (Company comp in WorkersMoreThan100)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> Beetween100And300 =
            //    from company in companies
            //    where company.NumOfWorkers > 100 && company.NumOfWorkers < 300
            //    select company;
            //foreach (Company comp in Beetween100And300)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> InLondon =
            //    from company in companies
            //    where company.Address.Contains("London")
            //    select company;
            //foreach (Company comp in InLondon)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> DirWhite =
            //    from company in companies
            //    where company.DirectorFullName.Contains("White")
            //    select company;
            //foreach (Company comp in DirWhite)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> OldCompanies =
            //    from company in companies
            //    where (DateTime.Now - company.FoundationDate).TotalDays > 730
            //    select company;
            //foreach (Company comp in DirWhite)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> found123DaysAgo =
            //    from company in companies
            //    where (DateTime.Now - company.FoundationDate).TotalDays == 123
            //    select company;
            //foreach (Company comp in DirWhite)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //IEnumerable<Company> BlackAndWhite =
            //    from company in companies
            //    where company.DirectorFullName.Contains("Black") && company.Name.Contains("White")
            //    select company;
            //foreach (Company comp in DirWhite)
            //{
            //    Console.WriteLine(comp.ToString());
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            #endregion

            #region task 2
            IEnumerable<string> info = companies.Select(c => c.ToString()).ToList();

            IEnumerable<Company> food = companies.Where(c => c.Name.Contains("Food")).ToList();

            IEnumerable<Company> market = companies.Where(c => c.Profile.ToLower().Equals("marketing")).ToList();

            IEnumerable<Company> marketIt = companies.Where((c => c.Profile.ToLower().Equals("marketing") || c.Profile.ToLower().Equals("it"))).ToList();

            IEnumerable<Company> moreThan100 = companies.Where(c => c.NumOfWorkers > 100).ToList();

            IEnumerable<Company> beetween100an300 = companies.Where(c => c.NumOfWorkers > 100 && c.NumOfWorkers < 300).ToList();

            IEnumerable<Company> inLondon = companies.Where(c => c.Address.Contains("London")).ToList();

            IEnumerable<Company> white = companies.Where(c => c.DirectorFullName.Contains("White")).ToList();

            IEnumerable<Company> oldCompanies = companies.Where(c => (DateTime.Now - c.FoundationDate).TotalDays > 730).ToList();

            IEnumerable<Company> daysFromFound123 = companies.Where(c => (DateTime.Now - c.FoundationDate).TotalDays == 123).ToList();

            IEnumerable<Company> blackAndWhite = companies.Where(c => c.DirectorFullName.Contains("Black") && c.Name.Contains("White")).ToList();
            #endregion
            #region task 3
            Company company = new Company("BallHog", "2024-04-02", "Ballin", "Matt Tkachuk", 0, "Odesa, Ukraine");
            company.HireEmployee(new Employee("John Doe", "Manager", "+233456789", "john.doe@example.com", 5000));
            company.HireEmployee(new Employee("Jane Smith", "Developer", "+987654321", "jane.smith@example.com", 6000));
            company.HireEmployee(new Employee("Bob Johnson", "Engineer", "+321321321", "bob.johnson@example.com", 5500));
            company.HireEmployee(new Employee("Charlie White", "Analyst", "+456456456", "charlie.white@example.com", 4800));
            company.HireEmployee(new Employee("David Black", "Technician", "+654654654", "david.black@example.com", 4700));
            IEnumerable<Employee> workers = company.Employees.Select(e => e).ToList();
            IEnumerable<Employee> highSalary = company.Employees.Where(e => e.Salary > 5000).ToList();
            IEnumerable<Employee> managers = company.Employees.Where(e => e.Position.Equals("manager", StringComparison.OrdinalIgnoreCase)).ToList();
            IEnumerable<Employee> PhoneStart = company.Employees.Where((e => e.PhoneNumber.Substring(1, 2) == "23")).ToList();
            IEnumerable<Employee> EmailStart = company.Employees.Where((e => e.Email.Substring(0, 2) == "di")).ToList();
            IEnumerable<Employee> Lionels = company.Employees.Where((e => e.Name.Split(' ').First() == "Lionel")).ToList();

            #endregion
            #region task 4
            int[] nums = { 20, 15, 54, 1100, 143, 59 };
            IEnumerable<int> sorted = nums.OrderBy(SumOfDigits);
            IEnumerable<int> sortedDesc = nums.OrderByDescending(SumOfDigits);
            foreach(int i in sorted)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
            foreach (int i in sortedDesc)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
            #endregion

        }
        static int SumOfDigits(int num)
        {
            char[] chars = num.ToString().ToCharArray();
            int res = 0;
            foreach (char c in chars)
            {
                res += int.Parse(c.ToString());
            }
            return res;
        }


    }
}
