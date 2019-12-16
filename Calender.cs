using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class Calender
    {
        public void createCalender()
        {
            Console.WriteLine("Enter the Day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month");
            int month= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            int year= Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine(Utility.calender(month,1, year));
           
            string[] months = {"","january", "frebuary", "march", "April", "may", "june", "july", "August", "Septeember", "October", "November", "December" };
            int[] days = {  0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Boolean result= Utility.isLeap(year);
            if (month == 2 && result)
            {
                days[month] = 29;
            }

            Console.WriteLine("The Number of Days in this Month is  --->" + days[month]);
            int d = Utility.calender(month, 1, year);
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine(i); 
            }

        }

    }
}
