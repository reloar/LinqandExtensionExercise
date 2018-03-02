using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
   public  class InventoryManager
    {
        public static IEnumerable<Inventory> FreshInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
        {
            new Inventory(){Name="IPhone X", Price=34500, Id=1},
            new Inventory(){Name="Samsung S8", Price=98000, Id=2},
            new Inventory(){Name="Gionee", Price=45000, Id=3},
            new Inventory(){Name="Injoo", Price= 20000, Id=4},
            new Inventory(){Name="Nokia" ,Price=54000,Id=5},
            new Inventory(){Name="Keyboard", Price=23000, Id=5},
           

        };
            return inventories;
        }

        public static void Main()
        {

            Console.WriteLine();
        }

        public static IEnumerable<Inventory> GetInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {

                new Inventory()
                { Id = 1,
                    Name = "Lenovo X1 Carbon",
                    Price =84000,
                    Entrydate= DateTime.Now,
                    categories = new List<Category>{ GetCategories()[1]}
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Price=54000,
                    Entrydate= DateTime.Now,
                    categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 3,
                    Name = "VGA Converter",
                    Price=23000,
                    Entrydate= DateTime.Now,
                    categories = new List<Category>{ GetCategories()[0] }
                },


                 new Inventory()
                 {
                     Id = 4,
                    Name = "Guitar",
                    Price=27000,
                    Entrydate= new DateTime(2000,11,12),
                    categories = new List<Category>{ GetCategories()[0] }
                 },
                  new Inventory()
                  { Id = 5,
                    Name = "shoe",
                    Price =8400,
                    Entrydate= DateTime.Now,
                    categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                new Inventory()
                {
                    Id = 6,
                    Name = "laptop",
                    Price=252000,
                    Entrydate= DateTime.Now,
                    categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 7,
                    Name = "Shirt",
                    Price=23000,
                   Entrydate= DateTime.Now,
                    categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                 {
                     Id = 8,
                    Name = "Infinix",
                    Price=27000,
                    Entrydate= DateTime.Now,
                    categories = new List<Category>{ GetCategories()[0] }
                 }
            };          
            
            return inventories;

        }

        public static List<Category> GetCategories()
        {
            Category[] categories = new Category[3]
            {
                new Category(){ Name = "Computer Accessorires"},
                 new Category(){ Name = "Laptop"},
                    new Category(){ Name = "Computer Gadget"},
            };

            return categories.ToList();
        }

    }
}
