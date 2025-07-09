using System;

namespace ConsoleApp8
{
    #region Q1
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    #region Q2
    class HiringDate
    {
        public int Day;
        public int Month;
        public int Year;

        public HiringDate(int d, int m, int y)
        {
            if (d < 1 || d > 31) 
                d = 1;
           
            if (m < 1 || m > 12) 
                m = 1;

            Day = d;
            Month = m;
            Year = y;
        }

        public string GetDate()
        {
            return Day + "/" + Month + "/" + Year;
        }
    }
    #endregion

    class Employee
    {
        public int ID;
        public string Name;
        public char Gender; 
        public double Salary;
        public HiringDate HireDate;
        public SecurityLevel Security;

        public Employee(int id, string name, char gender, double salary, HiringDate hireDate, SecurityLevel security)
        {
            ID = id;
            Name = name;
            if (gender == 'M' || gender == 'F')
                Gender = gender;
            else
                Console.WriteLine(" Invalid input");

            if (salary < 0)
                salary = 0;

            Salary = salary;
            HireDate = hireDate;
            Security = security;
        }

        public string GetInfo()
        {
            return "ID: " + ID + " Name: " + Name + " Gender: " + Gender + " Salary: " + Salary.ToString("C") + "Hire Date: " + " Hire Date: " + HireDate.GetDate() + " Security Level: " + Security;
        }
        
    }
    #endregion

    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q3
            Employee[] EmpArr = new Employee[2];

            EmpArr[0] = new Employee(1, "Moamen", 'M', 20000, new HiringDate(13, 4, 2022), SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Yara", 'F', 15000, new HiringDate(4, 1, 2023), SecurityLevel.Guest);

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i].GetInfo());
            }
            #endregion

        }
    }
}
