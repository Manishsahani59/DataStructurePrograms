using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructurePrograms.SinglyLinkedList
{
    class SinglyLinekdListAHome
    {
        public void SLLHome()
        {
           
            char input;
            do
            {
                Console.WriteLine(" 1. create Linked List");
                Console.WriteLine(" 2. Insert At Begning");
                Console.WriteLine(" 3. Insert At End");
                Console.WriteLine(" 4. Insert At Given Position");
                Console.WriteLine(" 5. Seach Element");
                Console.WriteLine(" 6. Delete An Element form begning ");
                Console.WriteLine(" 7. Delete At End ");
                Console.WriteLine(" 8. Delete At Given Positon ");
                Console.WriteLine(" 9. Find the Length of Linked List ");

                Console.WriteLine("Enter Your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    
                    case 1:
                        SinglyLinkedList SLL = new SinglyLinkedList();
                        Console.WriteLine("Enter the Size of the List");
                        int size = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= size; i++)
                        {
                            int value = Convert.ToInt32(Console.ReadLine());
                            SLL.AddFirst(value);
                        }
                        SLL.Display();

                        break;
                    case 2:
                        SinglyLinkedList SLL1 = new SinglyLinkedList();
                        Console.WriteLine("Enter the Size of the List");
                        int size1 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= size1; i++)
                        {
                            int value = Convert.ToInt32(Console.ReadLine());
                            SLL1.AddFirst(value);
                        }
                       
                        SLL1.Display();

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;


                }
                Console.WriteLine("If you Want Continue Press Y/N");
                input = Convert.ToChar(Console.ReadLine());
            } while (input.Equals('Y') || input.Equals('y'));
        }

    }
}
