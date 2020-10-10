using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Classes
{
    class DataManager
    {
        public static int GetCountOfSelectedItems(List<TaskItem> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item.IsSelected)
                    count++;
            }
            return count;
        }
    }
}
