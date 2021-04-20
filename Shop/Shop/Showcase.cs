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
            
            Product[] products = new Product[Size];
            CreateDate = DateTime.Now;
            DeleteDate = default;
        }
        public void Add(int showcaseId)
        {
            
            products[_count].ShopCaseId = showcaseId;
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            products[_count].Name = name;
            products[_count].Id = _count + 1;
            _count++;
        }
        public Product[] ShowCasesProduct(int showcaseId)
        {
            //Console.WriteLine("Выберите номер витрины");
            //int showcaseId = int.Parse(Console.ReadLine());
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
                if(products[i]!=null)
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
