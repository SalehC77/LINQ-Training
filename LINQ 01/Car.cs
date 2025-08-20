using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal class Car
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public string VIN { get; set; }
        public Car(int id ,int makeid,int modelid ,string vin)
        {
            this.Id = id;
            this.MakeId = makeid;
            this.ModelId = modelid;
            this.VIN = vin;
            
        }
    }
}
