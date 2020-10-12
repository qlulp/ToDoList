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
        readonly Classes.Task ItemData;
        MainForm Main;

        public ListElement(in MainForm form, in Classes.Task item)
        {
            InitializeComponent();

            Dock = DockStyle.Top;
            Main = form;
            ItemData = item;
            UpdateDataOnControl();
            UpdateFont();
        }

        private void UpdateDataOnControl()
        {
            if (ItemData != null)
            {
                TaskLabel.Text = ItemData.Content; 
                CheckPictureBox.Image = ItemData.IsDone ? Properties.Resources.CheckBoxTrue : null;
                BackColor = ItemData.IsSelected ? Color.FromArgb(243, 253, 251) : Color.White;
                DateLabel.Text = ItemData.DateTime.Date.ToShortDateString() + "\n" + ItemData.DateTime.ToShortTimeString();
               //  Content = content;
            }
        }

        private void TaskLabel_Click(object sender, EventArgs e)
        {
            ItemData.IsSelected = !ItemData.IsSelected;
            BackColor = ItemData.IsSelected ? Color.FromArgb(243, 253, 251) : Color.White;
            Main.UpdateSelectedInfoBlock();
        }

        private void UpdateFont()
        {
            if (ItemData.IsDone)
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
            ItemData.IsSelected = !ItemData.IsSelected;
            BackColor = ItemData.IsSelected ? Color.FromArgb(243, 253, 251) : Color.White;
            Main.UpdateSelectedInfoBlock();
        }

        private void CheckPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            ItemData.IsDone = !ItemData.IsDone;
            CheckPictureBox.Image = ItemData.IsDone ? Properties.Resources.CheckBoxTrue : null;
            UpdateFont();
            Main.UpdateDoneInfoBlock();
            Main.UpdateNotDoneInfoBlock();
        }
    }
}
