using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class CaseCounter
    {
        public void cashcounter()
        {
            int choice,size;
            bool validation;
            UnorderedQueue unorederQueue = new UnorderedQueue();
            Console.WriteLine("Enter the no of pepole come today in bank");
            do
            {
                validation = int.TryParse(Console.ReadLine(), out size);
                if (validation == true)
                    break;
                Console.WriteLine("Enter the valid value");
            } while (!validation);
           
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
