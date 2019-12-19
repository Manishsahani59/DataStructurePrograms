using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class calenderusingtwoDarray
    {

        public void calendertwodimesional()
        {


            Console.WriteLine("Enter the Month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            int day = Utility.calender(month,1,year);
            int totalday = DateTime.DaysInMonth(year, month);
            int[,] calender = new int[6, 7];
            Console.WriteLine("sun\tmon\ttu\twed\tth\tfr\tsa");
            int temp = 1;
            int count = 7;
            for(int i=0;i<6;i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 && j < day)
                        calender[0, j] = day;
                    else
                    {
                        if (temp <= totalday)
                        {
                            calender[i, j] = temp;
                            temp++;

                        }
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i==0 &&  j<day ||calender[i,j]==0)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(calender[i, j]+"\t");
                       
                    }

                }
                Console.WriteLine();
            }


            }
            
        }

    }

