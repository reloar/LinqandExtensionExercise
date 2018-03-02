using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public static class Tester1
    {
        public static void Main()
        {

            var skip = InventoryManager.GetInventories().SkipWhile(x => x.Id < 2);


            foreach(var item in skip)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            Console.WriteLine("\n USING TAKE BY");

            var take = InventoryManager.GetInventories().TakeWhile(x => x.Id > 4);
            foreach(var it in take)
            {
                Console.WriteLine(it.Name + " : " + it.Price);
            }       


            Console.Read();




        }

    }
}
