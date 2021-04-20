using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Shop
    {
        private Showcase[] showcases;
        private int _showcaseCount = 0;
        private int _size;
        public Shop()
        {
            _size = 100;
            showcases = new Showcase[_size];
        }
        public void Add()
        {
            Showcase showcase = new Showcase();
            Console.WriteLine("Введите название");
            string title = Console.ReadLine();
            showcase.Title = title;
            Console.WriteLine("Введите размер");
            int size = int.Parse(Console.ReadLine());
            showcase.Size = size;
            showcase.Id = _showcaseCount + 1;
            showcases[_showcaseCount] = showcase;
            _showcaseCount++;
        }
        public void Print()
        {
            for (int i = 0; i < _showcaseCount; i++)
            {
                Console.WriteLine(showcases[i].Id + ")Витрина: " + showcases[i].Title + "   Размер:" + showcases[i].Size +
                 "\n Cоздана" + showcases[i].CreateDate + "  Удалена" + showcases[i].DeleteDate);
            }
        }
        public void Remove()
        {
            Console.WriteLine("Введите номер для удаления");
            int Input = int.Parse(Console.ReadLine()) - 1;
            showcases[Input] = null;
            _showcaseCount--;
            do
            {
                showcases[Input] = showcases[Input + 1];
                Input++;
            } while (showcases[Input] != null);
        }
        public void Change()
        {
            Console.WriteLine("Номер витрины");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("1)Что бы поменять название");
            Console.WriteLine("2)Что бы поменять размер");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine("Введите название");
                        input = Console.ReadLine().ToLower();
                        showcases[num - 1].Title = input;
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Введите размер");
                        input = Console.ReadLine().ToLower();
                        showcases[num - 1].Size = int.Parse(input);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }
        }
        public void Shoping()
        {
            while (true)
            {
                Print();
                Console.WriteLine("Нажмите:\n1 для выбора витрины\n2 для изменения витрины\n3 для удаления витрины\n4 для добавления втирины");
                var UserInput = Console.ReadLine().ToLower();
                switch (UserInput)
                {
                    case "1":
                        {
                            Console.WriteLine("Введите номер витрины");
                            int ShowcaseId = int.Parse(Console.ReadLine())-1;
                            Showcase showcase = showcases[ShowcaseId];
                            showcase.UsingShowcase(ShowcaseId);
                            break;
                        }
                    case "2":
                        {
                            Change();
                            break;
                        }
                    case "3":
                        {
                            Remove();
                            break;
                        }
                    case "4":
                        {
                           Add();
                            break;
                        }
                }
            }
        }
    }
}