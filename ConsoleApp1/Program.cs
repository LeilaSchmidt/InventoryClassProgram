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
                //enter the values or exit
                Console.WriteLine("Type 'stop' to stop, or enter the index of the item you wish to change.");
                var itemIndex = Console.ReadLine();

                if (itemIndex.ToLower() == "stop")
                {
                    Inventory.displayFinalOutput(listOfObjs);
                    break;
                }
                int updateIndex = Convert.ToInt32(itemIndex);
                Inventory.countInitialization(updateIndex, listOfObjs);


            } while (true);

            //update or show the final output
            Console.WriteLine("If you made a mistake and wish to update the count of an item, type 'update'.\nOtherwise, type 'exit' to have the final items and their counts displayed");
            var update = Console.ReadLine();

            if (update.ToLower() == "stop")
            {
                Inventory.displayFinalOutput(listOfObjs);
            }
            else if (update.ToLower() == "update")
            {
                Inventory.updateCount(listOfObjs);
            }

            Console.WriteLine("Goodbye");
        }
    }
}
