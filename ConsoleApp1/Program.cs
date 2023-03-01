using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Inventory> listOfObjs = new List<Inventory>();
            Console.WriteLine("Add the item you would like to add to the list,\nor type 'stop' to get the current list of already entered items.\n");
            while (true)
            {
                Console.WriteLine("Please enter your item");
                string item = Console.ReadLine();

                if (item.ToLower() == "stop")
                {
                    Console.WriteLine("The items you created were:");
                    for (int i = 0; i < listOfObjs.Count; i++)
                    {
                        Console.WriteLine(i + " " + listOfObjs[i].name);
                    }
                    break;
                }
                else
                {
                    Inventory item1 = new Inventory(item);
                    listOfObjs.Add(item1);
                }
            }

            do
            {
                //update or show the final output
                Console.WriteLine("To update the count of an item, type 'update'.\nOtherwise, type 'exit' to have the final items and their counts displayed");
                var update = Console.ReadLine();

                if (update.ToLower() == "exit")
                {
                    Inventory.displayFinalOutput(listOfObjs);
                    break;
                }
                else if (update.ToLower() == "update")
                {
                    Inventory.updateCount(listOfObjs);
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand that input, please try again.");
                }

            } while (true);
            Console.WriteLine("Goodbye");
        }
    }
}
