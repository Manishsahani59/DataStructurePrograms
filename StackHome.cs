using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class StackHome
    {

        stack stack = new stack();
        public void stackhome()
        {
            char input;

            do
            {
            Console.WriteLine("Enter 1 . create stack");
            Console.WriteLine("Enter 2 . push element in the stack");
            Console.WriteLine("Enter 3 . Pop element form the stack");
            Console.WriteLine("Enter 4 . peek element of the stack");
            Console.WriteLine("Enter 5 . isEmpty");
            Console.WriteLine("Enter 6 . Length of the stack");
            Console.WriteLine("Enter 7 . Dispaly the stack list");
            Console.WriteLine("Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());




                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Stack created scessfully of");
                        Console.WriteLine("Length ---> " +stack.Length());
                        Console.WriteLine("currently no element ---> " +stack.isEmpty());

                        break;
                    case 2:
                        Console.WriteLine("Enter the size of the stack");
                        int size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("push the Element in the stack");
                        for (int i = 1; i <= size; i++)
                        {
                            int value = Convert.ToInt32(Console.ReadLine());
                            stack.push(value);
                        }
                        

                        break;
                    case 3:
                        Console.Write("Before Pop the Element the list is -->  ");
                        stack.dispaly();
                        Console.WriteLine("The Length  --->" + stack.Length());
                        Console.Write("After Pop the Element the list is -->  ");
                        stack.dispaly();
                        Console.WriteLine("The Length  --->" + stack.Length());

                        break;
                    case 4:
                        Console.WriteLine("The Top of Stack value is ----> " + stack.peek());
                        break;
                    case 5:
                        Console.WriteLine("Is Empty --->" +stack.isEmpty());
                        break;
                    case 6:
                        Console.WriteLine("The Length of the stack is ---> " + stack.Length());
                        break;
                    case 7:
                        stack.dispaly();
                        break;
                 
                    default:
                        Console.WriteLine("You select Wrong Option");
                        break;
                }
                Console.WriteLine("if You Want Continue Y/N");
                input = Convert.ToChar(Console.ReadLine());
            } while (input.Equals('Y') || input.Equals('y'));
        }

    }
}
