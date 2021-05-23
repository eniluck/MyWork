using Shop.Interafaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    class Showcase : IShowCase
    {
        List<Showcase> showcases = new List<Showcase>();
        private int _count =1;
        public int ID { get; set; }
        public string Title { get ; set; }
        public int Size { get;set ; }
        public DateTime CreateTime { get; set ;}
        public DateTime DaliteTime { get ; set;}
        public List<Product> products { get; set; }
        public int ProductID { get; set; }
        public Showcase() {}
        public Showcase(string title,int id,int size)
        {
            ProductID = 1;
            products = new List<Product>();
            CreateTime = DateTime.Now;
            DaliteTime = DateTime.MinValue;
            ID = id;
            Size = size;
            Title = title;
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
        public void CheckProductID(int id)
        {
            if (id > ProductID - 1)
            {
                Console.WriteLine("Такого ID не существует,введите другой ID");
                var input = Console.ReadLine();
                id = Validate(input);
                CheckProductID(id);
            }
        }
        public void CheckId(int id)
        {
            if (id > _count-1)
            {
                Console.WriteLine("Такого ID не существует,введите другой ID");
                var input = Console.ReadLine();
                id = Validate(input);
                CheckId(id);
            }
        }
        public List<Showcase> ReturnListShowcases() { return showcases; }
        public void Add()
        {
            string input;
            Console.Write("Введите название:");
            var title = Console.ReadLine();
            Console.Write("Введите размер витрины:");
            input = Console.ReadLine();
            var size = Validate(input);
            var id = _count;
            _count++;
            Showcase showcase = new Showcase(title,id,size);
            showcases.Add(showcase);
        }
        public void Print()
        {
            foreach(var x in showcases)
            {
                Console.WriteLine(x.ID+")"+"Title:"+x.Title+" Size:"+x.Size);
            }
        }
        public void Remove()
        {
            Console.Write("Введите ID витрины:");
            var input = Console.ReadLine();
            var id = Validate(input);
            CheckId(id);
            var thisShowcase = new Showcase();
            foreach(var item in showcases)
            {
                if (item.ID == id)
                    thisShowcase = item;
            }
            //если на втирине продукт id!=1 то выйти из метода
            if (thisShowcase.ProductID != 1)
                Interect();
            foreach (var x in showcases)
            {
                if (x.ID == id)
                {
                    showcases.Remove(x);
                    x.DaliteTime = DateTime.Now;
                    _count--;
                    break;
                }
            }
        }
        public void Edit()
        {
            Console.Write("Введите ID витрины:");
            var input = Console.ReadLine();
            var id = Validate(input);
            CheckId(id);
            Showcase thisshowcase=this;
            foreach (var item in showcases)
            {
                if (item.ID == id)
                {
                    thisshowcase = item;
                    break;
                }
            }
            Console.WriteLine("Введите:\n1) для изменения Title \n2) для изменени Size");
            input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    {
                        Console.Write("Введите Tittle:");
                        input = Console.ReadLine();
                        thisshowcase.Title = input;
                        break;
                    }
                case "2":
                    {
                        Console.Write("Введите Size:");
                        input = Console.ReadLine();
                        var size = Validate(input);
                        thisshowcase.Size = size;
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
        public void Interect()
        {
            Console.WriteLine("Введите:\n1)Для добавления\n2)Для редактирования\n3)Для удаления\n0)Для отабражения витрин");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    {
                        Console.Clear();
                        Add();
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
        public int SumProductCapacity()
        {
            var sum = 0;
            foreach (var item in products)
                sum += item.Capacity * item.Count;
            return sum;
        }
    }
}
