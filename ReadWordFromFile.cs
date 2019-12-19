using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructurePrograms.SinglyLinkedList
{
    class ReadWordFromFile
    {

        public void ReadwordfromFile()
        {
            SinglyLinkedList SLL = new SinglyLinkedList();

            try
            {
                string path = @"D:\path.txt";
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
                string[] words = content.Split(" ");

                for (int i = 0; i < words.Length; i++)
                {

                    int value = int.Parse(words[i]);
                    SLL.AddFirst(value);

                }
                SLL.Display();
                SLL.LengthofList();
                Console.WriteLine("Wnter the Word To be Searched");
                int key = Convert.ToInt32(Console.ReadLine());
                if (SLL.seachDelete(key))
                {
                    // File.WriteAllText(path, words);
                    SLL.Display();
                }
                else
                {

                    Console.WriteLine("Enter the index to insert the value");
                    int index = Convert.ToInt32(Console.ReadLine());
                    //     SLL.AddLast(key);
                    SLL.InsertAt(index, key);
                    //  File.WriteAllText(path, words);
                    SLL.Display();
                }

                SLL.LengthofList();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("File Read Failed");
            }
          

        }



    }
}
