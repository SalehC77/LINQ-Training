using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Make(int id ,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
