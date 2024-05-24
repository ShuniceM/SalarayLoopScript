using System.Runtime.CompilerServices;

namespace SalaryLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            double hoursWorked;
            double rate;
            double salary;

            //start loop
            for (int i = 1;i <= 3;i++)
            {
                Console.WriteLine("Enter hours worked");
                hoursWorked = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter rate of pay");
                rate = Convert.ToDouble(Console.ReadLine());

                salary = hoursWorked * rate;

                Console.WriteLine("Salary is \tR" + salary.ToString("F2"));
                
            }
        }
    }
}
