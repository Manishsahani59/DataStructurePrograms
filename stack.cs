using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructurePrograms
{
    class stack
    {
       public stacknode top;
       public int length;
        
        public stack()
        {
           top = null;
           length = 0;
        }
       

        public int Length()
        {
            return length;
        }
        public bool isEmpty()
        {
            return length==0;
        }


        public void push(int data)
        {
            stacknode newnode = new stacknode(data);
            newnode.next = top;
            top = newnode;
            length++;
            top = top.next;

        }

      

       
        
        
        public void display()
        {
            stacknode current = top;
            while (top != null)
            {
                Console.Write(top.data + " --->");
                    top = top.next;
            }

        }
        public int peek()
        {
          
            if (isEmpty())
            {
                throw new EmptyStackException();
            }
            return top.data;
         
        }





    }

}
