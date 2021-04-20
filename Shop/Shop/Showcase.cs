using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Showcase
    {
        private int _count=0;
        private Product[] products;
        public int Id { get; set; }
        public string Title { get; set; }
        public int Size { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public Showcase()
        {
            
            products = new Product[100];
            CreateDate = DateTime.Now;
            DeleteDate = default;
        }
        public void Add(int showcaseId)
        {
            Product product = new Product();
            product.ShopCaseId = showcaseId+1;
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            product.Name = name;
            product.Id = _count + 1;
            products[_count] = product;
            _count++;
        }
        public Product[] ShowCasesProduct(int showcaseId)
        {
           
            Product[] showCaseProduct = new Product[Size];
            for (int i = 0; i < _count; i++)
            {
                if (products[i].ShopCaseId == showcaseId)
                    showCaseProduct[i] = products[i];
            }
            return showCaseProduct;
        }
        public void Print(int showcaseId)
        {
            Product[] products = ShowCasesProduct(showcaseId);
            for (int i = 0; i < products.Length; i++)
            {
                if(products[i]!=null )
                Console.WriteLine(products[i]);
            }
        }
        public void UsingShowcase(int showcaseId)
        {
            Console.WriteLine("Нажмите:\n1 для вывода продуктов\n2 для добавления");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    {
                        Print(showcaseId);
                        break;
                    }
                case "2":
                    {
                        Add(showcaseId);
                        break;
                    }
            }    
        }
    }
}
