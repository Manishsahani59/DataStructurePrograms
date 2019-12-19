using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructurePrograms.SinglyLinkedList
{
    class SinglyLinekdListAHome
    {
        public void SLLHome()
        {
            SinglyLinkedList singlelinkedlist = new SinglyLinkedList();
            int datafront;
            int datalast;
            int data;
            char exit,gofor;
            int choice;
            bool flag;
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
                Console.WriteLine(" 10. isEmpty");
                Console.WriteLine(" 11. Display the List ");



              
                    choice = Utility.switchcasevalidation();
                    switch (choice)
                    {

                        case 1:
                            Console.WriteLine("The length of the list is    -----> " +singlelinkedlist.Length());
                            Console.WriteLine(" empty list is    -----> " +singlelinkedlist.isEmpty());

                            break;
                        case 2:

                            Console.WriteLine("Enter the data");
                            datafront = Utility.inputValidation();
                            singlelinkedlist.AddFirst(datafront);

                            break;
                        case 3:
                            Console.WriteLine("Enter the data");
                            datalast = Utility.inputValidation();
                            singlelinkedlist.AddLast(datalast);

                            break;
                        case 4:
                            Console.WriteLine("Enter the position");
                            int dataposition;
                            int position = Utility.inputValidation();
                            Console.WriteLine("Enter the data");
                            do {
                                
                                flag = int.TryParse(Console.ReadLine(), out dataposition);
                                if (flag == true)
                                    break;
                                Console.WriteLine("Enter the valid input");
                            } while (!flag);
                            
                            singlelinkedlist.InsertAt(position, dataposition);


                            break;
                        case 5:
                            Console.WriteLine("Enter the data");
                            int searchdata = Utility.inputValidation();
                            singlelinkedlist.search(searchdata);

                            break;
                        case 6:
                            singlelinkedlist.deleteFirst();

                            break;
                        case 7:
                            singlelinkedlist.DeleteLast();
                            break;
                        case 8:
                            Console.WriteLine("Enter the postion");
                            int index = Utility.inputValidation();
                            singlelinkedlist.DeleteAt(index);
                            break;
                        case 9:
                            singlelinkedlist.LengthofList();
                            break;
                        case 10:
                            Console.WriteLine(singlelinkedlist.isEmpty());
                            break;
                        case 11:
                            singlelinkedlist.Display();
                            break;
                        default:
                            Console.WriteLine("Enter wrong option");
                            break;
                    }
                   



                Console.WriteLine("Do you want to go back");
                exit = Utility.ExitValidation();
               
            } while (exit.Equals('Y') || exit.Equals('y'));
        }

    }
}
