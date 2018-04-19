using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    class Category
    {
        private string name;
        private List<string> items;

        public string Name { get => name; set => name = value; }
        public List<string> Items { get => items; set => items = value; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
