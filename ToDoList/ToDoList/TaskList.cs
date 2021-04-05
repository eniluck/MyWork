using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class TaskList
    {
        private Task[] _tasks;
        public TaskList(int max)
        {
            _tasks = new Task[max];
            _tasks[0] = new Task
            {
                Title = "Test1"
            };
            _tasks[1] = new Task
            {
                Title = "Test2"
            };
            _tasks[2] = new Task
            {
                Title = "Test3"
            };
            _tasks[3] = new Task
            {
                Title = "Test4"
            };
        }
        public int Count()
        {
            int counter = 0;
            for (int i = 0; i < _tasks.Length; i++)
            {
                if (_tasks[i] != null)
                    counter++;
            }
            return counter;
        }
        public Task[] GetTasks()
        {
            int TaskCount = Count();
            Task[] result = new Task[TaskCount];
            for (int i = 0; i < TaskCount; i++)
            {
                result[i] = _tasks[i];
            }
            return result;
        }
        public void Delete(int selectedTaskNumber)
        {
            int taskIndexToRemove = selectedTaskNumber - 1;
            _tasks[taskIndexToRemove] = null;
            int issuesCount = Count();
            do
            {
                _tasks[taskIndexToRemove] = _tasks[taskIndexToRemove + 1];
                taskIndexToRemove++;
            } while (_tasks[taskIndexToRemove] != null);   
        }
        public void Change(int UserInput)
        {
            int taskIndexToChange = UserInput-1;
            _tasks[taskIndexToChange].Status = Status.Complete;
        }
    }
}
/*
 * 1
 * 2- del
 * 3
 * 4
 * 5
 * 6
 * 7
 * 
 * */

    