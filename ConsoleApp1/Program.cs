using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Inventory> listOfObjs = new List<Inventory>();

                Console.WriteLine("What item would you like to add to the inventory?");
                string item = Console.ReadLine();
                Console.WriteLine("How many of this item do you have?");
                int count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Inventory.numberOfItemsCreated);

                Inventory item1 = new Inventory(item, count);

                item1.displayTest();

                foreach (Inventory items in listOfObjs)
                {
                    Console.WriteLine("There are " + items.count);
                }

                Console.WriteLine("Do you wish to create another item?");
                string cont = Console.ReadLine();
                if (cont == "no")
                {
                    Console.WriteLine("The items you created were:");
                    foreach (Inventory items in listOfObjs)
                    {
                        Console.WriteLine(items.count + " " + items.name);
                    }
                    break;
                }
            }
        }
    }
}