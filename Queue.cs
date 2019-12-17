using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class Queue
    {

        Queue front;
        Queue rear;
        Queue next;
        int data;
        int length = 0;
       

      
      public int Length()
        {
            return length;
        }
        public bool isEmpty()
        {
            return length == 0;
        }

        public void Enequeue(int data)
        {
            Queue newnode = new Queue();
            newnode.data = data;
            if (isEmpty())
            {
                front = newnode;
            }
            else
            {
                rear.next = newnode;
            } 
            rear = newnode;
            length++;

        }
        

    

        public void Dequeue()
        {
            Queue current = new Queue();
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else {
                int result = front.data;
                front = front.next;
                if (front == null)
                {
                    rear = null;
                }


                length--;
            }

            
        }

        public void dispaly()
        {
            Queue current = front;
            while (current!= null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

        }


        public void reverseQueue()
        {
            Queue queue = new Queue();
          
            while (front != null)
                if (isEmpty())
                {
                    return;
                }
                else
                {
                   int result = front.data;
                    front = front.next;
                    length--;
                    queue.Enequeue(result);
                   

                }
           

        }
      
       
          
        }


    }

