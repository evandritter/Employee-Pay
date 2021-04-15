using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthlyPay();
        }
        public static void MonthlyPay()
        {
            //monthly employee
            HourlyEmployee hourly = new HourlyEmployee("Frank", "Finance", 2020, 160, 30);
            Console.WriteLine("Employee Name: " + hourly.name);
            Console.WriteLine("Employee Section: " + hourly.section);
            Console.WriteLine("Employee Employment Date: " + hourly.dateEmployed);

            Console.WriteLine("Wage per month:");
            Console.WriteLine(hourly.hoursPerMonth * hourly.ratePerHour);

            Console.WriteLine();

            //salary employee
            SalaryEmployee yearly = new SalaryEmployee("Joe", "Sanitation", 2020, 50000);
            Console.WriteLine("Employee Name: " + yearly.name);
            Console.WriteLine("Employee Section: " + yearly.section);
            Console.WriteLine("Employee Employment Date: " + yearly.dateEmployed);
            Console.WriteLine("Wage per year:");
            Console.WriteLine(yearly.annualPay);

            Console.WriteLine();
        }
    }
    public abstract class Employee //abstract preventing instantiation
    {
        public string name;
        public string section;
        public int dateEmployed;

        public Employee(string name, string section, int dateEmployed)
        {
            this.name = name;
            this.section = section;
            this.dateEmployed = dateEmployed;
        }
    }
    public class SalaryEmployee : Employee
    {
        public int annualPay;
        public SalaryEmployee(string name, string section, int dateEmployed, int annualPay) : base(name, section, dateEmployed)
        {
            this.annualPay = annualPay;

        }

    }
    public class HourlyEmployee : Employee
    {
        public int hoursPerMonth;
        public int ratePerHour;
        public HourlyEmployee(string name, string section, int dateEmployed, int hoursPerMonth, int ratePerHour) : base(name, section, dateEmployed)
        {
            this.hoursPerMonth = hoursPerMonth;
            this.ratePerHour = ratePerHour;
        }
    }
}
