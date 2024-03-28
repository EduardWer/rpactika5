using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practa5_ints
{
    public class Product
    {
        public string name_wer { get; set; }
        public string Description { get; set; }

        public string Size { get; set; }
        public int Price { get; set; }

        public Product(string name_, string description, string size, int price)
        {
            name_wer = name_;
            Description = description;
            Size = size;
            Price = price;
        }
    }
}
