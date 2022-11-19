using System;

namespace _3
{
    class Program
    {
        static void Main()
        {
            Console.Write("please enter your age:");
            string a = Console.ReadLine();
            int age = Convert.ToInt32(a);
            int res1 = year(age);
            int res2 = ageMonth(age);
            int res3 = ageWeek(age);
            int res4 = days(age);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
        }
        private static int year(int age)
        {
            int res1;
            res1 = age / 365;
            return res1;
        }//end year
        private static int  ageMonth(int age)
        {
            int res2;
            res2 = age * 30;
            return res2;
        }//end agemonth
        private static int ageWeek(int age)
        {
            int res3;
            res3 = age * 7;
            return res3;
        }//end ageweek
        private static int days(int age)
        {
            int res4;
            res4 = age * 365;
            return res4;
        }//end days

    }
}