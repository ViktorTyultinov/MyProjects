using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proconsult_Table_Constructor
{
    class Item
    {
        public string NameCategory { get; set; }
        public string NameGroup { get; set; }
        public string NameItem { get; set; }
        public string QuantityPerPack { get; set; }
        public string MinQuantityForDelivery { get; set; }
        public double Price { get; set; }
        public Item(string namCat,string namGr, string namItem, string pack, string del,double pri)
        {
            NameCategory = namCat;
            NameGroup = namGr;
            NameItem = namItem;
            QuantityPerPack = pack;
            MinQuantityForDelivery = del;
            Price = 999999;
        }

        public override string ToString()
        {
            string s = "<ITEM>\r<CATEGORY>" + NameCategory + "</CATEGORY>\r<GROUP>" + NameGroup + "</GROUP>\r<NAME>" + NameItem + "</NAME>\r<PACK>"+QuantityPerPack+"</PACK>\r<DELIVERY>"+MinQuantityForDelivery+"</DELIVERY>\r<PRICE>"+Price+"</PRICE>\r</ITEM>";
            return s;
        }
    }
}
