using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesProject
{
    static class GetDays
    {
        static public int UserDate(int userDay, int userMonth, int userYear)
        {
            Console.WriteLine($"Users day is: {userDay}");
            Console.WriteLine($"Users month is: {userMonth}");
            Console.WriteLine($"Users year is: {userYear}");
            int result = userDay + userMonth + userYear;
            return result;




        }

    }
}
