using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class tester4
    {
        public static void Main()
        {
            var getsum = InventoryManager.GetInventories().Sum(s => s.Price);
            Console.WriteLine($"the sum of {getsum}");           
          
            Console.Read();
        }
    }
}
