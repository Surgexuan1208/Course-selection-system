using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_selection_system
{
    class Record
    {
        public Student SelectedStudent {  get; set; }
        public Course SelectedCourse { get; set; }

        public bool Equals(Record record)
        {
            return SelectedStudent.StudentId == record.SelectedStudent.StudentId && SelectedCourse.CourseName == record.SelectedCourse.CourseName;
        }

        public override string ToString()
        {
            return $"{SelectedStudent.StudentName}/{SelectedCourse.CourseName}";
        }
    }
}
