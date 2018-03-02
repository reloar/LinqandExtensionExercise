﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class CompareInventory : IEqualityComparer<Inventory>
    {
        public bool Equals(Inventory x, Inventory y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Inventory obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
