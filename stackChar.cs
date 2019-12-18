using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class stackChar
    {

        public stack next;
        public char data;
        public int length = 0;

        public stack top;


        public void push(char data)
        {
            stack newnode = new stack();
            newnode.data = data;
            newnode.next = top;
            top = newnode;
            length++;
        }
        public void push1(char data)
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

        public char peek()
        {
            if (isEmpty())
            {
                throw new EmptyStackException();
            }
            return (char)top.data;
        }

        public void pop()
        {
            char reult = (char)top.data;
            top = top.next;
            length--;
            Console.WriteLine("The Top of the Stack element deleted ----> " + reult);
        }


        public void reverseStack()
        {
            int reult;
            if (isEmpty())
            {
                return;
            }
            else
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
