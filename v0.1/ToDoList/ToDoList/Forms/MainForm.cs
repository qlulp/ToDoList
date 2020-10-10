using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ToDoList.Classes;
using ToDoList.Controls;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        AddTask AddTaskForm;
        List<TaskItem> Tasks;
        public MainForm()
        {
            InitializeComponent();

            AddItems();
        }

        private void AddItems()
        {
            Tasks = new List<TaskItem>();
            for (int i = 0; i < 100; i++)
            {
                Tasks.Add(new TaskItem
                (
                    isDone: true,
                    isSelected: true,
                    dateTime: DateTime.Now,
                    content: $"Задача {i}"
                ));

                TaskListPanel.Controls.Add(new ListElement(Tasks[i]));
            }
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

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HideButton_MouseHover(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(0, 153, 204);
        }

        private void HideButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.White;
        }

        private void HeaderPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            {
                if (WindowState != FormWindowState.Maximized)
                    WindowState = FormWindowState.Maximized;
                else
                    WindowState = FormWindowState.Normal;
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (AddTaskForm != null)
            {
                AddTaskForm.Close();
            }
            AddTaskForm = new AddTask();
            AddTaskForm.Show();
        }

        public void UpdateInfoBlocks()
        {
            infoBlock2.Count = DataManager.GetCountOfSelectedItems(Tasks).ToString();
        }

        private void TaskListPanel_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInfoBlocks();
        }

        private void TaskListPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("fs");
            UpdateInfoBlocks();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
