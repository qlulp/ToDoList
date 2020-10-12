using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Classes;

namespace ToDoList.Controls
{
    public partial class AddTask : Form
    {
        MainForm Main;
        private DateTime DateTimeOfTask;
        public AddTask(MainForm mainForm)
        {
            InitializeComponent();

            DateTimeOfTask = DateTime.Now;
            Main = mainForm;
            UpdateData();
        }

        private void UpdateData()
        {
            DateLabel.Text = "Дата создания: " + DateTimeOfTask.ToShortDateString();
            TimeLable.Text = "Время создания: " + DateTimeOfTask.ToShortTimeString();
        }

        #region Перемещение формы 
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;

        public void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        #endregion

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CancelAddTaskButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void AddItem()
        {
            if (TaskContentTextBox.Text != string.Empty)
            {
                var temp = new Classes.Task
                (
                    isDone: false,
                    isSelected: false,
                    dateTime: DateTimeOfTask,
                    content: TaskContentTextBox.Text
                );

                Main.Tasks.Add(temp);
                Main.ShowAllItems();
                // Main.UpdateNotDoneInfoBlock();
                Close();
            }
        }

        private void TaskContentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AddItem();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
