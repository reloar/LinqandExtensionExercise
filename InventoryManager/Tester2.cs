using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Tester2
    {
        public static void Main()
        {
            Console.WriteLine("USING CONCAT,UNION, DISTINCT,INTERCEPT, EXCEPT");

            Console.WriteLine("\n===========CONCAT===========");
            var concat = InventoryManager.GetInventories().Concat(InventoryManager.FreshInventories());

            foreach(var o in concat)
            {
             Console.WriteLine($"{o.Id}\t |{o.Name}\t |{o.Price}\t |{o.Entrydate} ");
            }

            Console.WriteLine("\n===========UNION===========");
            var union = InventoryManager.FreshInventories().Union(InventoryManager.GetInventories(), new CompareInventory());

            foreach(var e in union)
            {
                    Console.WriteLine($"{e.Id}\t |{e.Name}\t |{e.Price}\t |{e.Entrydate} ");
            }

            Console.WriteLine("\n===========DISTINCT===========");
            var distinct = union.Distinct();
            foreach(var d in distinct)
            {
                Console.WriteLine($"{d.Id}\t |{d.Name}\t |{d.Price}\t |{d.Entrydate}");

            }

            Console.WriteLine("\n===========INTERSECT===========");
            var item3 = InventoryManager.FreshInventories().Intersect(InventoryManager.GetInventories(), new CompareInventory());
            foreach (var u in item3)
            {
                Console.WriteLine($"{u.Id}\t |{u.Name}\t |{u.Price}\t |{u.Entrydate} ");
            }


            Console.WriteLine("\n===========EXCEPT===========");
            var item4 = InventoryManager.FreshInventories().Except(InventoryManager.GetInventories());

            foreach (var u in item4)
            {
                Console.WriteLine($"{u.Id}\t |{u.Name}\t |{u.Price}\t |{u.Entrydate}");

            }

           
            // distint=item1.Distinct()

           

            Console.Read();
        }
    }
}
