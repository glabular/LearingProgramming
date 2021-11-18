using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesProject
{
    // class If_leap_year // WrongNaming
    static class IfLeapYear
    {
        static public bool DetermineLeapYear(int year)
        {
            bool ifLeap;
            int z4 = year % 4; // Проверка високосный ли год.
            if (z4 == 0)
            {
                int z100 = year % 100;
                if (z100 == 0)
                {
                    int z400 = year % 400;
                    if (z400 == 0)
                    {
                        //Console.WriteLine("Год високосный");
                        ifLeap = true;
                    }
                    else
                    {
                        //Console.WriteLine("Год не високосный");
                        ifLeap = false;
                    }
                }
                else
                {
                    //Console.WriteLine("Год високосный");
                    ifLeap = true;
                }
            }
            else
            {
                //Console.WriteLine("Год не високосный");
                ifLeap = false;
            }

            return ifLeap;
        }
    }
}
