using System;
using System.Collections.Generic;
using Shop.Interafaces;

namespace Shop.Model
{
    class Product : IProduct
    {
        List<Product> products = new List<Product>();

        private int _count = 1;
        public double Price { get; set; }
        public int Count { get; set; }
        public int ShowcaseId { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime DaliteTime { get; set; }

        public Product() { }

        public Product(int id, string name, int capacity)
        {
            ID = id;
            Name = name;
            Capacity = capacity;
            CreateTime = DateTime.Now;
            DaliteTime = DateTime.MinValue;
        }

        public List<Product> ListProduct() { return products; }

        public void Print()
        {
            foreach (var x in products)
            {
                if (x.ShowcaseId == 0)
                {
                    Console.WriteLine(x.ID + ")" + "Title:" + x.Name + " Capacity:" + x.Capacity);
                }
            }
        }

        public void CheckId(int id)
        {
            if (id > _count - 1)
            {
                Console.WriteLine("Такого ID не существует,введите другой ID");
                var input = Console.ReadLine();
                id = Validate(input);
                CheckId(id);
            }
        }

        private int Validate(string input)
        {
            var num = 0;
            var x = int.TryParse(input, out num);
            while (!int.TryParse(input, out num))
            {
                Console.Write("Введите целое число больше нуля:");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        public void Create()
        {
            string input;
            Console.Write("Введите название:");
            var name = Console.ReadLine();
            Console.Write("Введите занимаемый обьем:");
            input = Console.ReadLine();
            var capacity = Validate(input);
            var id = _count;
            _count++;
            Product product = new Product(id, name, capacity);
            products.Add(product);
        }

        public void Edit()
        {
            Console.Write("Введите ID товара:");
            var input = Console.ReadLine();
            var id = Validate(input);
            CheckId(id);
            Product thisproduct = this;
            foreach (var item in products)
            {
                if (item.ID == id)
                {
                    thisproduct = item;
                    break;
                }
            }
            Console.WriteLine("Введите 1 для изменения Name \nВведите 2 для изменени Capacity");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    {
                        Console.Write("Введите Name:");
                        input = Console.ReadLine();
                        thisproduct.Name = input;
                        break;
                    }
                case "2":
                    {
                        Console.Write("Введите Capacity:");
                        input = Console.ReadLine();
                        var capacity = Validate(input);
                        thisproduct.Capacity = capacity;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого дейтсвия не сущесвует");
                        input = Console.ReadLine();
                        break;
                    }
            }
        }

        public void Remove()
        {
            Console.Write("Введите ID продукта:");
            var input = Console.ReadLine();
            var id = Validate(input);
            CheckId(id);
            foreach (var x in products)
            {
                if (x.ID == id)
                {
                    products.Remove(x);
                    x.DaliteTime = DateTime.Now;
                    _count--;
                    break;
                }
            }
        }

        public void Interect()
        {
            Console.WriteLine("Введите:\n1)Для добавления\n2)Для редактирования\n3)Для удаления\n0)Для отабражения продуктов");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    {
                        Console.Clear();
                        Create();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        Print();
                        Edit();
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        Print();
                        Remove();
                        break;
                    }
                case "0":
                    {
                        Print();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Такого действия не существует");
                        Interect();
                        break;
                    }
            }
        }
    }
}


