using System;

namespace ToDoList.Classes
{
    [Serializable]
    public class Task
    {
        public bool IsDone { get; set; }
        public bool IsSelected { get; set; }
        public DateTime DateTime { get; set; }
        public string Content { get; set; }

        public Task(bool isDone, bool isSelected, DateTime dateTime, string content)
        {
            IsDone = isDone;
            IsSelected = isSelected;
            DateTime = dateTime;
            Content = content;
        }
    }
}
