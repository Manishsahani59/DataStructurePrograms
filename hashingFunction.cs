using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructurePrograms.SinglyLinkedList
{
    class hashingFunction
    {

        public void hashingfunction() 
        {
           
            string path = @"D:\hashfunction.txt"; 
            int[] arr = new int[11];
            SinglyLinkedList[] slot = new SinglyLinkedList[11];
            SinglyLinkedList singlelinked;
            string content = File.ReadAllText(path);
            string[] words = content.Split(" ");
            foreach (string val in words)
            {
                Console.Write(val +"     ");
            }
            Console.WriteLine();


            foreach(string element in words)
            {
                
               
                int value = int.Parse(element);
                int reminder = value % 11;
                if (slot[reminder] == null)
                {
                    singlelinked = new SinglyLinkedList();
                    singlelinked.AddFirst(value);
                    slot[reminder] = singlelinked;
                }
                else
                {
                    singlelinked = slot[reminder];
                    singlelinked.AddFirst(value);
                }

            }

            for (int i = 0; i < 11; i++)
            {
                Console.Write(i + "\t");
                if (slot[i] != null)
                {
                    singlelinked = slot[i];
                    singlelinked.Display();
                }
                Console.WriteLine("");

            }



        }

    }
}
