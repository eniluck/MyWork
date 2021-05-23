using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Interafaces
{
    interface IProduct
    {
        public DateTime CreateTime { get; set; }
        public DateTime DaliteTime { get; set; }
        public int ID { get; set; }
        //public int ShowcaseID { get; set; }
        //public int Amount { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        //public int Price { get; set; }
        public void Create();
        public void Remove();
        public void Edit();
    }
}
