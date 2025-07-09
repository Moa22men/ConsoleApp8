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
    

    class Employee
    {
        public int ID;
        public string Name;
        public char Gender; 
        public double Salary;
        public SecurityLevel Security;

        public Employee(int id, string name, char gender, double salary, SecurityLevel security)
        {
            ID = id;
            Name = name;
            if (gender == 'M' || gender == 'F')
                Gender = gender;
            else
                Gender = 'M'; 

            Salary = salary;
            Security = security;
        }

        public string GetInfo()
        {
            return "ID: " + ID + " Name: " + Name + " Gender: " + Gender + " Salary: " + Salary.ToString("C") + " Security Level: " + Security;
        }
        
    }
    #endregion

    #region Q2
    class HiringDate
    {
        public int Day;
        public int Month;
        public int Year;

        public HiringDate(int d, int m, int y)
        {
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
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
