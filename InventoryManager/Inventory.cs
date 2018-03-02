using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
   public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Entrydate { get; set; } = DateTime.Now;
        public List<Category> categories { get; set; } = new List<Category>();

        public override string ToString()
        {
            return $"{this.Id} , {this.Name},{this.Price}, {this.Entrydate}, {this.categories}";
        }
    }

    
}
