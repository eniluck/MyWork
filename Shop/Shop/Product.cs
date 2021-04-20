using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Product
    {
        public int ShopCaseId { get; set; }
        private int _count = 0;
        public int Price { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quality { get; set; }
        public Product()
        {
            Id = _count;
            _count++;
        } 
    }
}
