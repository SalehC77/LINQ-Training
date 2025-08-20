using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MakeId { get; set; }
        public Model(int id , string name, int makeid)
        {
            this.Id = id;
            this.Name = name;
            this.MakeId = makeid;
            
        }
    }
}
