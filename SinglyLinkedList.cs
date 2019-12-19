using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.SinglyLinkedList
{
    class SinglyLinkedList
    {
        ListNode head;
        int length = 0;

        public int Length()
        {
            return length;
        }
        public bool isEmpty()
        {
            return length == 0;
        }

        /// <summary>
        /// this method to find the middle node in the list
        /// </summary>
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

        /// <summary>
        /// this method to add the data in the list from begning
        /// </summary>
        /// <param name="data"></param>
        public void AddFirst(object data)
        {
            ListNode newNode = new ListNode(data);
            if (head == null)
            {
                head = newNode;
                length++;
            }
            else
            {
                newNode.next = head;
                head = newNode;
                length++;
            }
        }
        /// <summary>
        /// This method insert data form the end in the linked list
        /// </summary>
        /// <param name="data"></param>
        public  void AddLast(object data)
        {
            ListNode newNode = new ListNode(data);
            ListNode current = head;
            if (head == null)
            {
                head = newNode;
            }
            else {
                while (current.next != null)
                {
                    current = current.next;

                }
                current.next = newNode;
                length++;
            }
            
        }
        /// <summary>
        /// this method find the length of the list i.e how much element stored in the list
        /// </summary>
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

        /// <summary>
        /// this method display the list
        /// </summary>
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
        /// <summary>
        /// this method insert the data at the given position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
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
            length++;
        }
        /// <summary>
        /// remove the frist element form the list
        /// </summary>
        public void deleteFirst()
        {


            ListNode temp = head;
            head = head.next;
            temp.next = null;
            length--;


        }
        /// <summary>
        /// this method delete the data form the last
        /// </summary>
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
            length--;
        }
        /// <summary>
        /// this insert the data from the given location
        /// </summary>
        /// <param name="position"> postion is the variable i.e the index value from where we want to remove the data</param>
        public void DeleteAt(int position)
        {
            ListNode previous = head;
            ListNode previousTolast = null;
            int count = 1;
            if (position == 1)
            {
                SinglyLinkedList sll = new SinglyLinkedList();
                sll.deleteFirst();
            }
            else
            {
                while (count < position - 1)
                {
                    previousTolast = previous;
                    previous = previous.next;
                    count++;
                }
                ListNode temp = previous.next;
                previousTolast.next = temp;
                length--;
            }
        }
        /// <summary>
        /// serach the data from the list
        /// </summary>
        /// <param name="data"></param>
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


       

        public int takeinput()
        {
            Console.WriteLine("Enter the value");
            int value;
            bool validate;
            do
            {
                validate = int.TryParse(Console.ReadLine(), out value);
                if (validate == true)
                    break;
                Console.WriteLine("Enter the valid Input");
            } while (!validate);
            return value;
        }



    }
}
