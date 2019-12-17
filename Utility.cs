using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    /// <summary>
    ///         prime Number 0 to 1000 and store in 2D arry in the sequence of 0-100,100-200, and showon 
    /// </summary>
    class Utility
    {
        private static int j;

        public static void primeNumber(int size)
        { int k = 0, m = 0;
            int[,] arr = new int[1001, 1001];
            int temp = 0;
            int sum = 0;
            int seperate = 100;
          
            for (int no = 1; no <= 1000; no++)
            {
                for (int i = 2; i <= no - 1; i++)
                {
                    if (no % i == 0)
                    {
                        temp = temp + 1;
                    }
                }
                if (temp == 0)
                {

                   
                            arr[k, m] = no;


                    if (no <= seperate)
                    {
                        Console.Write(arr[k, m] + " ");

                    }
                    else
                    {
                        Console.WriteLine("\n");
                        seperate = seperate + 100;
                    }

                    k++;
                    m++;
                }


                    /*sum = sum + no;
                        Console.Write(no + "  ");
                 //   Console.WriteLine("sum = " + sum);
                        if (no >= seperate)
                        {
                            Console.WriteLine("\n");
                            seperate = seperate + 100;
                        }
                   */
                    
                
                else {
                    temp = 0;
                }

            

            }

           
        }
        /// <summary>
        /// Print number which is prime and Anagram to each other in the range 0-1000
        /// </summary>
        public static void primeAnagram()
        {
            int k = 0;
            bool result;
            int temp = 0;
            int flag = 0;
            int[,] arr = new int[1000, 1000];
            int[] temparr = new int[200];

            for (int no = 1; no <1000; no++)
            {
              //  chackAnagram = no;
                for (int i = 2; i <= no - 1; i++)
                {
                    if (no % i == 0)
                    {
                        flag = flag + 1;
                    }

                    //  result=DetectAnagram(chackAnagram);


                }

                if (flag == 0)
                {
                      temparr[k] = no;

                   // Console.WriteLine(temparr[k]);

                      k++;
                }
                else
                {
                    flag = 0;
                }

              

            }

            for (int i = 0; i < temparr.Length; i++)
            {
                for (int j = i+1; j < temparr.Length; j++)
                {
                    string frist = temparr[i] + "";
                    string second = temparr[j] + "";
                   
                    result = DetectAnagram(frist, second);
                    if (result)
                    {
                        Console.WriteLine(frist + "   " + second + "\t");
                    }
                   
                }
            }
        }

        public static bool DetectAnagram(string frist, string second)
        {  
            Boolean status=true;
            if (frist.Length != second.Length)
            {
                return false;
            }
            else {
                char[] ch1 = frist.ToCharArray();
                char[] ch2 = second.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                for (int i = 0; i <ch1.Length; i++)
                {
                    if (ch1[i] != ch2[i])
                    {
                        return false;
                    }
                }
                return true;
              
            }
        
         
          
           
        }
        /*    End of PrimeAnagram Detection  */


        public static int calender(int m, int d, int y)
        {
         //   string[] day = { "Sunday", "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Sarturday" };
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }

        public static bool isLeap(int year)
        {
            if ((year % 4 == 0) || (year % 400 == 0) && year % 100 != 0)
            {
                return true;
            }return false;

        }


      




    }
}
