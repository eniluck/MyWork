using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        /* Задача
         * Просмотр списка задач
         * Редоктирование 
         * Удаление 
         * Измененгие статуса
       */
        
        private static TaskList _taskList;
        private const string _DisplayTask = "1";
        private const string _EditTask = "2";
        private const string _DeliteTask = "3";
        private const string _ChangeStatus = "4";
        private const string _Exit = "x";
        static void Main(string[] args)
        {
            bool _isNext = true;
        _taskList = new TaskList(100);
                Console.WriteLine("Выберет действие");
                Console.WriteLine("Введите 1: для вывода список ");
                Console.WriteLine("Введите 2: для редоктрования");
                Console.WriteLine("Введите 3: для удаления");
                Console.WriteLine("Введите 4: для изменения статуса");
                Console.WriteLine("Введите x: для выхода");
            while (_isNext)
            {
                string UserInput = Console.ReadLine().ToLower();

                switch (UserInput)
                {
                    case _DisplayTask:
                        {
                            PrintTask();
                            break;
                        }
                    case _EditTask:
                        {
                            EditTask();
                            break;
                        }
                    case _DeliteTask:
                        {
                            DeliteTask();
                            break;
                        }
                    case _ChangeStatus:
                        {
                            ChangeStatus();
                            break;
                        }
                    case _Exit:
                        {
                            Console.Clear();
                            _isNext = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого действия нет: " + UserInput);
                            break;
                        }
                }
                if (_isNext)
                {
                    Console.WriteLine("Выберет действие");
                    Console.WriteLine("Введите 1: для вывода список ");
                    Console.WriteLine("Введите 2: для редоктрования");
                    Console.WriteLine("Введите 3: для удаления");
                    Console.WriteLine("Введите 4: для изменения статуса");
                    Console.WriteLine("Введите x: для выхода");
                }
            }
        }

        private static void DeliteTask()
        {
            PrintTask();
            Console.WriteLine("Выбирете задачу");
            int UserInput = int.Parse(Console.ReadLine());
            _taskList.Delete(UserInput);
           
        }

        private static void PrintTask()
        {
            
            Task[] tasks = _taskList.GetTasks();
            for (int i = 0; i < tasks.Length; i++)
            {
             Console.WriteLine(i + 1 + ") Название:" + tasks[i].Title + " Статус: " + tasks[i].Status + ", Создан:" + tasks[i].CreationDate);
            }
        }
        private static void EditTask()
        {
            PrintTask();
            Task[] tasks = _taskList.GetTasks();
            Console.WriteLine("Выбирете задачу");
            int UserInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя задачи");
            tasks[UserInput - 1].Title = Console.ReadLine();
           
        }
        private static void ChangeStatus()
        {
            PrintTask();
            Console.WriteLine("Выбирете задачу");
            int UserInput = int.Parse(Console.ReadLine());
            _taskList.Change(UserInput);          
        }
    }
}
