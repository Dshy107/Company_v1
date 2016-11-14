using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int monthlyBonus;
        private int houres;
        public Manager(string name, int salaryPerMonth, int monthlyBonus, int houres) : base(name, salaryPerMonth)
        {
            this.monthlyBonus = monthlyBonus;
            this.houres = houres;
        }
        public override int GetSalaryPerMonth()
        {

            if (houres > 180)
            {
                monthlyBonus = 100;
                Console.WriteLine(monthlyBonus + base.GetSalaryPerMonth());
            }
            else
            {
                Console.WriteLine("Not enouth for bonus");
            }
            return base.GetSalaryPerMonth();
        }
        //public int Bonus()
        //{
        //    if (monthlyBonus > 100)
        //    {
        //        Console.WriteLine(monthlyBonus);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not enouth bonus");
        //    }
        //    return monthlyBonus;
        //}
    }
}
