using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inventory
    {
        public String name { get; set; }
        public int count { get; set; }

        public Inventory(String name, int count)
        {
            this.name = name;
            this.count = count;
        }
        public Inventory(String name)
        {
            this.name = name;
        }

        public Inventory()
        {
            return;
        }

        public static void updateCount(List<Inventory> myList)
        {
            Console.WriteLine("\nwhich item would you like to update?");
            var index = Console.ReadLine();
            int intIndex = Convert.ToInt32(index);

            while(intIndex > myList.Count())
            {
                Console.WriteLine("I'm sorry, there is no item at that number, please enter a valid item's number.");
                index = Console.ReadLine();
                intIndex = Convert.ToInt32(index);
            }

            Console.WriteLine("How many would you like to add or remove to the count of this item?");
            int amount = Convert.ToInt32(Console.ReadLine());

            myList[intIndex].count += amount;
            Console.WriteLine("Item: " + myList[intIndex].name + ", now has a count of: " + myList[intIndex].count);
        }

        public static void displayFinalOutput(List<Inventory> myList)
        {
            Console.WriteLine("\nThe items you created were:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i + ": " + myList[i].name + " has a count of: " + myList[i].count);
            }
        }
    }
}
