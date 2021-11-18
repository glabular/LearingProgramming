using System;

namespace DatesProject
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Console.WriteLine("Введите вторую дату в формате ДД.ММ.ГГГГ");
            //string secondDate = Console.ReadLine();

            //Console.WriteLine("Между этими датами {} дней");
            //Console.WriteLine(secondDate);
            //Console.WriteLine(firstDate);


            Console.WriteLine("Программа вычислит количество дней между двумя датами.");
            Console.WriteLine("Введите первую дату в формате ДД.ММ.ГГГГ");
            Console.ReadLine();

            int[] userDate1;
            userDate1 = new int[3];
            

            int userDay1 = 10;
            int userMonth1 = 12;
            int userYear1 = 2001;

            
            Console.WriteLine(GetDays.UserDate(userDay1, userMonth1, userYear1));

            int userDay2 = 12;
            int userMonth2 = 05;
            int userYear2 = 1996;
            Console.WriteLine(GetDays.UserDate(userDay2, userMonth2, userYear2));
            






            //bool isYear1Leap = IfLeapYear.DetermineLeapYear(1996);
            //Console.WriteLine(isYear1Leap);

            //bool isYear2Leap = IfLeapYear.DetermineLeapYear(2002);
            //Console.WriteLine(isYear2Leap);


























        }

        






    }

}
