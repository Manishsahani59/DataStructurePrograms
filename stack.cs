using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class stack
    {

        stack next;
        int data;
        int length = 0;

        stack top;

      
        public void push(int data)
        {
            stack newnode = new stack();
            newnode.data = data;
            newnode.next = top;
            top = newnode;
            length++;
        }
        public void push1(int data)
        {
            stack newnode = new stack();
            newnode.data = data;
            newnode.next = top;
            top = newnode;
            length++;
        }
        public int Length()
        {
            return length;
        }
        public bool isEmpty()
        {
            return length == 0;
        }
        public void dispaly()
        {
            stack current = top;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
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

        public void pop()
        {
            int reult = top.data;
            top = top.next;
            length--;
            Console.WriteLine("The Top of the Stack element deleted ----> " +reult);
        }


        public void reverseStack()
        {
            int reult;
            if (isEmpty())
            {
                return;
            } else
            {
                 reult = top.data;
                top = top.next;
                length--;
                Console.WriteLine("The Top of the Stack element deleted ----> " + reult);
            }

            stack stack = new stack();
            stack.push(reult);
        }
      
    }
}
