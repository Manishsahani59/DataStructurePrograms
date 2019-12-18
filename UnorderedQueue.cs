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


        public void dispaly()
        {
            UnorderedQueue current = front;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

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
               
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You Enter the withdrow Option");
                        Console.WriteLine("Enter the Money How much you Want");
                        int balance = Convert.ToInt32(Console.ReadLine());
                        if (balance > cash)
                        {
                            Console.WriteLine("No sufficient Balance in the Bank Please try Later");
                            Console.WriteLine("The only Amount int the  Bank is----> " + cash);
                        }
                        else {
                            cash = cash - balance;
                            Console.WriteLine( data +"You Withdrow Amount ------> " + balance);
                            Console.WriteLine("The Updated cash in the  Bank is----> " + cash);
                        }

                        break;
                    case 2:
                        Console.WriteLine( data+" You Enter the deposite Option");
                        Console.WriteLine("Enter the Money how much you want to Deposite");
                        int deposte = Convert.ToInt32(Console.ReadLine());
                        if (deposte <= 0)
                        {
                            Console.WriteLine("Please Enter the Valid Amount");
                        }
                        else
                        {
                            cash = cash + deposte;
                            Console.WriteLine(data+ " You Deposite the Amount ------> " + deposte);
                            Console.WriteLine("The Updated cash in the  Bank is----> " + cash);

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
