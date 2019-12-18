using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class Pallindromchecker
    {
        public void pallindromchecker()
        {
            UnorderedQueue queue = new UnorderedQueue();
            Console.WriteLine("Enter the String to check Pallindrom");
            string word = Console.ReadLine();
            
            for (int i = 0; i < word.Length; i++)
            {
                 queue.DoubliyQueue(word[i]);
            }
                
        //    queue.dispaly();
            bool result = queue.rearTraverse();
            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
      //      queue.removerear();
            Console.WriteLine("The Length of the Queue --->  " + queue.Length());
        
        }
        

    }
}
