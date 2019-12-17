﻿using DataStructurePrograms.SinglyLinkedList;
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
                Console.WriteLine(" ::  1   :: LinkedList");
                Console.WriteLine(" ::  2   :: Queue");
                Console.WriteLine(" ::  3   :: Stack");
                Console.WriteLine(" ::  4   :: prime number 1-1000");
                Console.WriteLine(" ::  5   :: primeAnagram 1-1000");
                Console.WriteLine(" ::  6   :: Calender ");
                Console.WriteLine(" ::  7   :: Read content form file ");
                Console.WriteLine(" ::  8   :: 0-1000 primeAnagram store in stack print using linked list ");
                Console.WriteLine(" ::  9   :: 0-1000 prime store in queue print using linked list ");
                Console.WriteLine(" ::  10  :: using stack Balancing token problem");
                Console.WriteLine(" ::  11  :: Seaching Element using Hash maping ");
                Console.WriteLine(" ::  12  :: Pallindrom Chacker ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                   
                    case 1:
                        SinglyLinekdListAHome SLLhome = new SinglyLinekdListAHome();
                        SLLhome.SLLHome();


                        break;
                    case 2:
                       
                        QueueHome queue = new QueueHome();
                        queue.Queuehome();
                      

                        break;
                    case 3:
                       
                        StackHome home = new StackHome();
                        home.stackhome();

                        break;
                    case 4:
                        primeNumber prime = new primeNumber();
                        prime.primenumber();
                        break;
                     case 5:
                        primeAnagram primeAnagram = new primeAnagram();
                        primeAnagram.primeanagram();
                        break;
                    case 6:
                        Calender calender = new Calender();
                        calender.createCalender();
                        break;
                    case 7:
                        ReadWordFromFile read = new ReadWordFromFile();
                        read.ReadwordfromFile();
                        break;

                    case 8:
                        primeAnagramStack primeAnagramStack = new primeAnagramStack();
                        primeAnagramStack.primeAnagramstack();
                        break;
                    case 9:
                        primeAnagramQueue primeAnagramQueue = new primeAnagramQueue();
                        primeAnagramQueue.primeAnagramsQueue();

                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        Pallindromchecker pallindrom = new Pallindromchecker();
                        pallindrom.pallindromchecker();
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
