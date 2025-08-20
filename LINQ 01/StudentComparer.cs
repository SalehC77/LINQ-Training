using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            var result = 0;
            if (x is not null && y is not null)
            {
                if (x.Level > y.Level) result = 1;

                else if (x.Level < y.Level) result = -1;
                
                
            }
            return result;
        }
    }
}
