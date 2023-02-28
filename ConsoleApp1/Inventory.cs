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
        public static int numberOfItemsCreated = 1;

        public Inventory(String name, int count)
        {
            this.name = name;
            this.count = count;
            numberOfItemsCreated++;
        }
        public void displayTest()
        {
            Console.WriteLine("the item " + name + " with value " + count + " has been created");
        }

    }
}
