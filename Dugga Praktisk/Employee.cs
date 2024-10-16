using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugga_Praktisk
{
    internal class Employee : Person
    {
        private double annualSalary;
        private string department;

        public double AnnualSalary
        {
            get { return annualSalary; }
            set
            {
                if (value > 0)
                {
                    annualSalary = value;
                }
                else
                {
                    throw new ArgumentException("Årslönen måste vara positiv.");
                }
            }
        }
        public string Department
        {
            get { return department; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    department = value;
                }
                else
                {
                    throw new ArgumentException("Avdelning får inte vara tom.");
                }
            }
        }
        public Employee(string firstName, string lastName, string personalNumber, string address, double annualSalary, string department)
        : base(firstName, lastName, personalNumber, address)
        {
            AnnualSalary = annualSalary;
            Department = department;
        }
        public void IncreaseSalary(double percentage)
        {
            if (percentage > 0)
            {
                AnnualSalary += AnnualSalary * (percentage / 100);
            }
            else
            {
                throw new ArgumentException("Procentuell ökning måste vara positiv.");
            }
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Årslön: {AnnualSalary}");
            Console.WriteLine($"Avdelning: {Department}");
        }
    }
}
