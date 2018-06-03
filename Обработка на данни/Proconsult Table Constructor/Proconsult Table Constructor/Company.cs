using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proconsult_Table_Constructor
{
    class Company
    {
        private List<Item> items;

        public Company()
        {
            items = new List<Item>();
        }
        public void addItem(Item i)
        {
            items.Add(i);
        }
        
        public List<Item> returnItems()
        {
            return items;
        }

        public List<Item> returnCategory(string category)
        {
            List<Item> temp = new List<Item>();
            foreach (var item in items)
            {
                if (item.NameCategory == category)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
    }
}
