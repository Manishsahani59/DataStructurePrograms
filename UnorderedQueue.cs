using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class UnorderedQueue
    {

        UnorderedQueue front;
        UnorderedQueue rear;
        UnorderedQueue prev;
        object data;
        UnorderedQueue next;
        int length = 0;


        public int Length()
        {
            return length;
        }

        public bool isEmpty()
        {
            return length == 0;
        }

        /// <summary>
        ///  insert data in the queue using doubly linked list
        /// </summary>
        /// <param name="data"></param>
        public void DoubliyQueue(object data)
        {
            UnorderedQueue newdata = new UnorderedQueue();
            newdata.data = data;
            if (isEmpty())
            {
                front = newdata;
            }
            else
            {
                rear.next = newdata;
                newdata.prev = rear;

            }
            rear = newdata;
            length++;
        }
        /// <summary>
        ///   queue implementaion using doubly linked list
        /// </summary>
        /// <returns></returns>
        public bool rearTraverse()
        {
            bool flag=false;
            UnorderedQueue last = rear;
            UnorderedQueue frist = front;
            while (frist!=null)
            {

                if (frist.data.Equals(last.data))
                {
                    frist = frist.next;
                    last = last.prev;
                    flag = true;
                }
                else
                {
                    return false;
                }
              //   Console.WriteLine(current.data);
                // current = current.prev;
                //length--;
          }
            return flag;
        
        }

        /// <summary>
        ///  insert the data in the queue
        /// </summary>
        /// <param name="data">data is the object type variable</param>
        public void enequeue(object data)
        {

            UnorderedQueue newdata = new UnorderedQueue();
            newdata.data = data;
            if (isEmpty())
            {
                front = newdata;
            }
            else
            {
                rear.next = newdata;

            }
            rear = newdata;
            length++;
        }

        /// <summary>
        /// dispaly the queue
        /// </summary>
        public void dispaly()
        {
            UnorderedQueue current = front;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        /// <summary>
        /// it removes the data form the front
        /// </summary>
        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("The Queue is Empty");
            }

            object data = front.data;
            front = front.next;
            length--;
            //Console.WriteLine(data);
        }
        /// <summary>
        /// it removes the data from the rear
        /// </summary>
        public void removerear()
        {
            
            while (front!=rear)
            {
            
                object result = rear.data;
                rear = rear.next;
                  
                length--;
                Console.WriteLine(result);
            }
          
        }

        /// <summary>
        /// cash counter dequeue
        /// </summary>

        public void dequeueOneByOne()
        {
            int cash = 1000000;
            Console.WriteLine("The Cash in the Bank is----> " + cash);
            int choice;
            while (!isEmpty())
            {
                object data = front.data;
                front = front.next;
                length--;
                Console.WriteLine(data + " press 1.  Withdrow");
                Console.WriteLine(data + " press 2.  Deposite ");

                Console.WriteLine("Now the Remaning Pepole in the Queue is   " +length ) ;

                choice = Utility.switchcasevalidation();
                switch (choice)
                {
                    case 1:
                        try
                        {

                            Console.WriteLine("You Enter the withdrow Option");
                            Console.WriteLine("Enter the Money How much you Want");
                            int balance = Convert.ToInt32(Console.ReadLine());
                            if (balance > cash)
                            {
                                Console.WriteLine("No sufficient Balance in the Bank Please try Later");
                                Console.WriteLine("The only Amount int the  Bank is----> " + cash);
                            }
                            else
                            {
                                cash = cash - balance;
                                Console.WriteLine(data + "You Withdrow Amount ------> " + balance);
                                Console.WriteLine("The Updated cash in the  Bank is----> " + cash);
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        

                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine(data + " You Enter the deposite Option");
                            Console.WriteLine("Enter the Money how much you want to Deposite");
                            int deposte = Convert.ToInt32(Console.ReadLine());
                            if (deposte <= 0)
                            {
                                Console.WriteLine("Please Enter the Valid Amount");
                            }
                            else
                            {
                                cash = cash + deposte;
                                Console.WriteLine(data + " You Deposite the Amount ------> " + deposte);
                                Console.WriteLine("The Updated cash in the  Bank is----> " + cash);
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                        }
                            

                        break;
                    default:
                        Console.WriteLine("You Enter the Wrong Option");
                        break;
                }
            }
        }



    }
}
