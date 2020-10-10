using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Classes;

namespace ToDoList.Controls
{
    public partial class ListElement : UserControl
    {
        readonly TaskItem ThisItem;

        public bool IsSelected
        {
            get => ThisItem.IsSelected;
            set => ThisItem.IsSelected = value;
        }

        public bool IsDone
        {
            get => ThisItem.IsDone;
            set => ThisItem.IsDone = value; // IsCheckedCheckBox.IsChecked  = value;
        }

        public string Content 
        { 
            get
            {
                return ThisItem.Content;
            }
            set
            {
                ThisItem.Content = value;
                TaskLabel.Text = ThisItem.Content;
            }
        }

        public ListElement(TaskItem item)
        {
            InitializeComponent();
            ThisItem = item;
        }

        private void TaskLabel_Click(object sender, EventArgs e)
        {
            ThisItem.IsSelected = !IsSelected;
            BackColor = ThisItem.IsSelected ? Color.FromArgb(243, 253, 251) : Color.White;
        }

        private void UpdateFont()
        {
            if (IsDone)
            {
                // Зачёркивание текста
                TaskLabel.Font = new Font
                (
                    TaskLabel.Font.FontFamily,
                    TaskLabel.Font.Size, FontStyle.Strikeout
                );
                TaskLabel.ForeColor = Color.Gray;
            }
            else
            {
                // Сброс
                TaskLabel.Font = new Font
                (
                    TaskLabel.Font.FontFamily,
                    TaskLabel.Font.Size, FontStyle.Regular
                );
                TaskLabel.ForeColor = Color.FromArgb(34, 61, 101);
            }
        }

        private void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            ThisItem.IsSelected = !IsSelected;
            BackColor = ThisItem.IsSelected ? Color.FromArgb(243, 253, 251) : Color.White;
        }
    }
}
