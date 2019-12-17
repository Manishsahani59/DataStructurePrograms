using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class Pallindromchecker
    {
        public void pallindromchecker()
        {
            Queue queue = new Queue();
            Console.WriteLine("Enter the String to check Pallindrom");
            string word = Console.ReadLine();
            
            for (int i = 0; i < word.Length; i++)
            {
              
                queue.Enequeue(word[i]) ;
            }

            queue.dispaly();

            Console.WriteLine("The Length of the Queue --->  " + queue.Length());
        }
        

    }
}
