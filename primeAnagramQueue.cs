using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class primeAnagramQueue
    {
        public static void primeAnagramsQueue()
        {
            Queue queue = new Queue();
            int k = 0;
            bool result;
            int temp = 0;
            int flag = 0;
            int[,] arr = new int[1000, 1000];
            int[] temparr = new int[200];

            for (int no = 1; no < 1000; no++)
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
                    queue.Enequeue(no);


                    // Console.WriteLine(temparr[k]);

                    //  k++;
                }
                else
                {
                    flag = 0;
                }



            }

            /*            for (int i = 0; i < stack; i++)
                        {
                            for (int j = i + 1; j < temparr.Length; j++)
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
                        */

            queue.dispaly();
        }

        public static bool DetectAnagram(string frist, string second)
        {
            Boolean status = true;
            if (frist.Length != second.Length)
            {
                return false;
            }
            else
            {
                char[] ch1 = frist.ToCharArray();
                char[] ch2 = second.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                for (int i = 0; i < ch1.Length; i++)
                {
                    if (ch1[i] != ch2[i])
                    {
                        return false;
                    }
                }
                return true;

            }




        }
    }
}
