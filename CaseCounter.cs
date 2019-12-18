using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class CaseCounter
    {
        public void cashcounter()
        {
            int choice;

            UnorderedQueue unorederQueue = new UnorderedQueue();
            Console.WriteLine("Enter the no of pepole come today in bank");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                String name = Console.ReadLine();
                unorederQueue.enequeue(name);
            }
             unorederQueue.dequeueOneByOne();






            unorederQueue.dispaly();
            Console.WriteLine("The Length is -->" + unorederQueue.Length());
           
            
           

        }
       
    }
}
