using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.SinglyLinkedList
{
    class SinglyLinkedList
    {
        ListNode head;

        public void MiddleNode()
        {
            ListNode Fp = head;
            ListNode Sp = head;
            while (Fp != null && Fp.next != null)
            {
                Sp = Sp.next;
                Fp = Fp.next.next;

            }
            Console.WriteLine(Sp);
        }


        public void AddFirst(object data)
        {
            ListNode newNode = new ListNode(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public  void AddLast(object data)
        {
            ListNode newNode = new ListNode(data);
            ListNode current = head;
            while (current.next != null)
            {
                current = current.next;

            }
            current.next = newNode;
        }

        public void LengthofList()
        {
            ListNode current = head;
            int count = 0;
            while (current != null)
            {
                current = current.next;
                count++;
            }
            Console.WriteLine("The Length of the List is ---- > " + count);
        }


        public void Display()
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.data + "--->");
                current = current.next;
            }
            Console.WriteLine("\n");

        }

        public void InsertAt(int position, object data)
        {
            ListNode newNode = new ListNode(data);
            ListNode current = head;
            int count = 1;
            while (count < position - 1)
            {
                current = current.next;
                count++;
            }
            ListNode temp = current.next;
            newNode.next = temp;
            current.next = newNode;
        }

        public void deleteFirst()
        {


            ListNode temp = head;
            head = head.next;
            temp.next = null;


        }
        public void DeleteLast()
        {
            ListNode current = head;
            ListNode previoustocurrent = null;
            while (current.next != null)
            {
                previoustocurrent = current;
                current = current.next;

            }
            previoustocurrent.next = null;
        }

        public void DeleteAt(int position)
        {
            ListNode previous = head;
            ListNode previousTolast = null;
            int count = 1;
            while (count < position - 1)
            {
                previousTolast = previous;
                previous = previous.next;
                count++;
            }
            ListNode temp = previous.next;
            previousTolast.next = temp;
        }

        public void search(int data)
        {

            ListNode current = head;
            int count = 1;
            while (current != null)
            {
                if ((int)current.data == data)
                {
                    Console.WriteLine("The Item Found At The Location ---> " + count);

                }
                count++;
                current = current.next;

            }
        }

               /// <summary>
               /// Delete Data if Already Exists
               /// </summary>
               /// <param name="data"></param>


        public bool seachDelete(int data)
        {
            ListNode newNode = new ListNode(data);
            ListNode previous = head;
           
            ListNode previousTolast = null;
           // ListNode current = head;
         
            while (previous!=null)
            {

                if (previous.data.Equals(data))
                {

                    ListNode temp = previous.next;
                    previousTolast.next = temp;
                    return true;
                }
              
                              previousTolast = previous;
                          previous = previous.next;
               

            }

            return false;







        }







    }
}
