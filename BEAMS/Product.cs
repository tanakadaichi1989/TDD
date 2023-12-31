﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMS
{
    public class Product
    {
        public String Name { get; }
        public int Price { get; }
        public String Memo { get; }
        public Product(string name, int price, string memo)
        {
            Name = name;
            Price = price;
            Memo = memo;
        }

        public virtual String GetInfo()
        {
            return $"{Name} {Extension.Deliminate(Price)} 円 {Memo}";
        }
    }
}
