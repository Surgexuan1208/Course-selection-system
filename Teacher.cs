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

        /*ObservableCollection<T> 是 .NET 中的一個類別，通常用於在應用程式的使用者介面 (UI) 中實現資料繫結 (Data Binding)。
            它和一般的 List<T> 類型很類似，但有一個關鍵的不同點：當 ObservableCollection 的內容發生改變時，它會主動發送通知，讓繫結到該集合的 UI 元件能夠感知到這些改變，並自動更新介面。
            這意味著，如果您將 ObservableCollection<T> 繫結到某個 UI 元件（例如列表、表格、或其他類型的資料呈現控制項），當 ObservableCollection 中的內容發生變化（如增加、移除或清空物件），UI 將會自動地更新以反映這些變化。
            簡單來說，ObservableCollection 是一個具有通知功能的集合類型，用於在資料發生變化時通知繫結的 UI 元件，從而使介面能夠即時顯示最新的資料狀態。這對於建立動態和交互式的使用者介面非常有用，特別是當您需要讓 UI 即時反映出資料集合的變化時。
        */
        public override string ToString()
        {
            return $"選取老師:{TeacherName}";
        }
    }
}
