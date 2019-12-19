using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class QueueHome
    {
        Queue queue = new Queue();
        public void Queuehome()
        {
            char input;
            int choice,size;
            bool validaton;
            int value;
            do
            {
                Console.WriteLine("Enter 1 . create Queue");
                Console.WriteLine("Enter 2 . Enequeue operation");
                Console.WriteLine("Enter 3 . Dequeue operartion");
                Console.WriteLine("Enter 4 . isEmpty");
                Console.WriteLine("Enter 5 . Length of the Queue");
                Console.WriteLine("Enter 6 . Dispaly the Queues");
                Console.WriteLine("Enter 7 . Remove form Rear");
                Console.WriteLine("Enter Your Choice");

                //int choice = Convert.ToInt32(Console.ReadLine());
                choice = Utility.switchcasevalidation(); 



                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Queue created scessfully of");
                        Console.WriteLine("Length ---> " + queue.Length());
                        Console.WriteLine("currently no element ---> " + queue.isEmpty());

                        break;
                    case 2:
                      
                        try
                        {
                            Console.WriteLine("Enter the size of the Queue");
                            size = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("push the Element in the stack");
                            for (int i = 1; i <= size; i++)
                            {
                                do
                                {
                                    validaton = int.TryParse(Console.ReadLine(), out value);
                                    if (validaton == true)
                                        continue;
                                    Console.WriteLine("Enter the valid value");

                                } while (!validaton);

                                queue.Enequeue(value);
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                       

                        break;
                    case 3:
                        Console.Write("Before Delete the Element the list is -->  ");
                        queue.dispaly();
                        queue.Dequeue();
                        Console.WriteLine("The Length  --->" + queue.Length());
                        Console.Write("After Pop the Element the list is -->  ");
                        queue.dispaly();
                        Console.WriteLine("The Length  --->" + queue.Length());

                        break;
                    
                    case 4:
                        Console.WriteLine("Is Empty --->" +queue.isEmpty());
                        break;
                    case 5:
                        Console.WriteLine("The Length of the queue is ---> " + queue.Length());
                        break;
                    case 6:
                        queue.dispaly();
                        break;
                    case 7:
                        queue.removeRear();
                        queue.dispaly();
                        break;

                    default:
                        Console.WriteLine("You select Wrong Option");
                        break;
                }
               
                input = Utility.ExitValidation();
            } while (input.Equals('Y') || input.Equals('y'));
        }


    }
}
