﻿namespace InventoryManager
{
    public class Category
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}