using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_selection_system
{
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }

        public override string ToString()
        {
            return $"{StudentName} ({StudentId})";
        }
    }

}
