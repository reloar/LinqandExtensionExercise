using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class tester3
    {
        public static void Main()
        {


            Console.WriteLine("\n USING ORDERBY AND THENBY");

            var k = InventoryManager.GetInventories().OrderBy(n => n.Id).ThenBy(n => n.Entrydate);
            foreach (var i in k)
            {
                Console.WriteLine($"{i.Id}\t{i.Name}\t{i.Entrydate}");
            }

            Console.WriteLine("\n USING ORDERBY DESCENDING AND THENBY DESCENDING");
            var dispaly = InventoryManager.GetInventories().OrderByDescending(n => n.Id).ThenByDescending(n => n.Price);
            foreach (var m in dispaly)
            {
                Console.WriteLine($"{m.Name} : {m.Price} : {m.Id}");
            }
            Console.Read();
        }
    }
}
