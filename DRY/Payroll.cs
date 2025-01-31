using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY
{
    public class Payroll
    {
        public decimal CalculateSalaryForFullTime(decimal baseSalary)
        {
            decimal tax = baseSalary * 0.18m;
            decimal bonus = baseSalary * 0.05m;
            return baseSalary - tax + bonus;
        }

        public decimal CalculateSalaryForPartTime(decimal hourlyRate, int hoursWorked)
        {
            decimal salary = hourlyRate * hoursWorked;
            decimal tax = salary * 0.18m;
            decimal bonus = salary * 0.05m;
            return salary - tax + bonus;
        }
    }
}
