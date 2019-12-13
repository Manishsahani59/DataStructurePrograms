using DataStructurePrograms.SinglyLinkedList;
using DataStructurePrograms.DoublyLinekdList;
using System;
using System.Collections.Generic;

namespace DataStructurePrograms.SinglyLinkedList
{
    class Program
    {
        static void Main()
        {


           char input;
            do
            {
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine(" ::  1  :: LinkedList");
                Console.WriteLine(" ::  2  :: Queue");
                Console.WriteLine(" ::  3  :: Stack");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                   
                    case 1:
                        DoublyLinekdList.DoublyLinekdList DLL = new DoublyLinekdList.DoublyLinekdList();
                        SinglyLinkedList SLL = new SinglyLinkedList();

                        /* 
                         SLL.AddFirst(10);
                         SLL.AddFirst(30);
                         SLL.AddFirst(5);
                         SLL.AddFirst(11);
                         SLL.AddFirst(17);
                         SLL.MiddleNode();

                         SLL.Display();
                         */

                        DLL.InsertAtBegingin(20);
                        DLL.InsertAtBegingin(30);
                        DLL.InsertAtBegingin(40);
                        DLL.InsertAtBegingin(50);
                        DLL.InsertAtBegingin(60);
                        DLL.InsertAtBegingin(70);
                        DLL.InsertAtLast(100);
                        // DLL.InsertAtLast(100);
                        //  DLL.insertAt(4, 300);
                     //    DLL.deleteAt(3);

                        // DLL.deleteFrist();

                        // DLL.deleteAtLast();
                        Console.WriteLine("The Original  Linked List");
                        DLL.DisplayFoward();
                        Console.WriteLine("The Reverse of the Linked List");
                     
                        DLL.displayBackWord();
                        Console.WriteLine(DLL.Length());
                        Console.WriteLine(DLL.isEmpty());

                        break;
                    case 2:
                      
                      

                        break;
                    case 3:
                        break;

                    default:
                        Console.WriteLine("Your Selection is Wrong");
                        break;
                }
                Console.WriteLine("If You Want Continue Press Y/N");
                input = Convert.ToChar(Console.ReadLine());
            } while (input.Equals('Y') || input.Equals('y'));
            
        }
    }
}
