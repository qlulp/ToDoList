using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    public class TaskItem
    {
        public bool IsDone { get; set; }
        public bool IsSelected { get; set; }
        public DateTime DateTime { get; set; }
        public string Content { get; set; }

        public TaskItem(bool isDone, bool isSelected, DateTime dateTime, string content)
        {
            IsDone = isDone;
            IsSelected = isSelected;
            DateTime = dateTime;
            Content = content;
        }
    }
}
