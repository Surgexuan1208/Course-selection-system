using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Course_selection_system
{
    internal class Teacher
    {
        public string? TeacherName { get; set; }
        public ObservableCollection<Course> TeachingCourses { get; set; } = new ObservableCollection<Course>();

        public override string ToString()
        {
            return $"選取老師:{TeacherName}";
        }
    }
}
