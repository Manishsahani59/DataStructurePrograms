using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.DoublyLinekdList
{
    class DoublyLinekdList
    {
        DNode head;
        DNode tail;
        int length;

        public DoublyLinekdList()
        {
            this.length = 0;

        }
        public bool isEmpty()
        {
            return length == 0;
        }
        public int Length()
        {
            return length;
        }

        public void InsertAtBegingin(object data)
        {
            DNode newNode = new DNode(data);
            if (head == null)
            {
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.previous = newNode;
            }
            head = newNode;
        }

        public void displayBackWord()
        {
            DNode current = tail;
            while (current != null)
            {
                Console.Write(current.data +" ---> ");
                
                current = current.previous;
            }
        }




        /*public void createList()
        {
            DNode head = new DNode(20);
            DNode second = new DNode(30);
            DNode third = new DNode(40);

            head.next = second;
            second.previous = head;
            second.next = third;
            third.previous = second;
            third.next=null;
        }
        */

        public void deleteAtLast()
        {
            DNode current = head;
            DNode currenttolast = null;
            while (current.next != null)
            {
                currenttolast = current;
                current = current.next;
            }currenttolast.next = null;
            current.previous = null;
        }

        public void deleteAt(int position)
        {
            DNode current = head;
            DNode currenttoPrevious = null;
            int count = 1;
            if (position == 1)
            {
                deleteFrist();
            }
            else
            {
                while (count <= position - 1)
                {
                    currenttoPrevious = current;
                    current = current.next;
                    count++;
                }


                DNode temp = current.next;
                temp.previous = currenttoPrevious;
                currenttoPrevious.next = temp;
                current.next = null;
                current.previous = null;

            }

        }

        public void deleteFrist()
        {
            DNode temp = head;
            head = head.next;
            head.previous = null;
            temp.next = null;

        }

        public void InsertAtLast(object data)
        {

            DNode NewNode = new DNode(data);
            DNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = NewNode;
            NewNode.previous = current;

        }


        public void insertAt(int position,object data)
        {
            int count = 1;
            DNode newNode = new DNode(data);
            DNode current = head;

            while (count < position - 1)
            {
                current = current.next;
                count++;
            }
            DNode temp = current.next;
            newNode.next = temp;
            temp.previous = newNode;
            newNode.previous = current;
            current.next = newNode;
            

        }



        public void DisplayFoward()
        {
            DNode current = head;
            while (current != null)
            {
                
                  
                Console.Write(current.data);
                if (current.next!= null)
                {
                    Console.Write(" ----> ");
                }
                current = current.next;
            }
            Console.WriteLine("\n");
        }




        

    }
}
