using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Interafaces
{
    interface IShowCase
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Size { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime DaliteTime { get; set; }
        public void Add();
        public void Remove();
        public void Edit();
    }
}
