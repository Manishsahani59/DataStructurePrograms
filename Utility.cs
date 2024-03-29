﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
   
    class Utility
    {
        private static int j;

        internal static void calender()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  prime Number 0 to 1000 and store in 2D arry in the sequence of 0-100,100-200, and showon 
        /// </summary>
        public static void primeNumber()
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
            int k = 0, l=0,m=0 ;
            bool result;
            int temp = 0;
            int flag = 0;
         
            int AnagramCount,notanagram;
            int[,] primeAnagram = new int[70, 70];
            int[,] notAnagram = new int[70, 70];
            int[] temparr = new int[170];

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
                        //  primeAnagram[i, j] =frist;

                        //   Console.Write(primeAnagram[i, j] + "  ");
                       
                        i++;
                        Console.WriteLine(frist + "   " + second + "\t"  );
                    }
                   
                  
                   
                }
            }

           

        }
        /// <summary>
        ///   this method detect the two string are anagram or not
        ///   Anagram is the number in which second is the rearrangement of the frist
        /// </summary>
        /// <param name="frist"></param>
        /// <param name="second"></param>
        /// <returns></returns>

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
        /// <summary>
        ///         this methdod in return the day of the week
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <param name="y"></param>
        /// <returns></returns>

        public static int calender(int m, int d, int y)
        {
         //   string[] day = { "Sunday", "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Sarturday" };
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }

        /// <summary>
        ///   boolean method detect the Year is leap or not
        /// </summary>
        /// <param name="year"> year is a variable in which we store the value given by the user </param>
        /// <returns></returns>
        public static bool isLeap(int year)
        {
            if ((year % 4 == 0) || (year % 400 == 0) && year % 100 != 0)
            {
                return true;
            }return false;

        }



        /// <summary>
        ///         Expression Brackets Are Equlas or not method
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static bool AreBalanced(char[] exp)
        {

            stackChar stake1 = new stackChar();

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
                {
                    stake1.push(exp[i]);
                }
                else if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (stake1.isEmpty() || (!ArePair(stake1.peek(), exp[i])))
                    {
                        return false;
                    }
                    else
                    {
                        stake1.pop();
                    }
                }
               
             
            }
         
           

            if (stake1.isEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// boolean Method to check the Brackets are equal or not if equal return true else false;
        /// </summary>
        /// <param name="ch1"></param>
        /// <param name="ch2"></param>
        /// <returns></returns>
        public static bool ArePair(char ch1, char ch2)
        {
            if (ch1 == '(' && ch2 == ')')
                return true;
            if (ch1 == '{' && ch2 == '}')
                return true;
            if (ch1 == '[' && ch2 == ']')
                return true;
           return false;

        }

        /// <summary>
        /// Exit validation
        /// </summary>
        /// <returns></returns>
        public static char ExitValidation()
        {
            bool validation;
            char input;
            do
            {
              
                validation = char.TryParse(Console.ReadLine(), out input);
                if (validation == true && input == 'n' || input == 'N')
                {
                    Console.WriteLine("Program Exit"); 
                    break;

                }
                
                             
            } while (!validation);

            return input;

        }
        /// <summary>
        /// switch case input validation
        /// </summary>
        /// <returns></returns>
     
        public static int switchcasevalidation()
       {
            int choice;
            bool validation;
            Console.WriteLine("Enter Your Choice");
            do
            {
                validation = int.TryParse(Console.ReadLine(), out choice);
                if (validation == true)
                    break;
                Console.WriteLine("The Input must be interger Value");
            } while (!validation);
            return choice;
        }
        /// <summary>
        /// this method validate the input value
        /// </summary>
        /// <returns></returns>
        public static int inputValidation()
        {

            bool validation;
         //   Console.WriteLine("Enter the value");
            int data;
            do
            {
                validation = int.TryParse(Console.ReadLine(), out data);
                if (validation == true)
                    break;
                Console.WriteLine("Please Enter the valid Input");

            } while (!validation);
            return data;
        }




    }
}
