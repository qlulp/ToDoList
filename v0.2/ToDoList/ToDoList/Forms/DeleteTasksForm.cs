using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToDoList.Forms
{
    public partial class DeleteTasksForm : Form
    {
        private MainForm Main;
        private List<ToDoList.Classes.Task> Tasks;
        private List<ToDoList.Classes.Task> itemsToDelete;
        public DeleteTasksForm(in MainForm main, in List<ToDoList.Classes.Task> tasks)
        {
            InitializeComponent();
            Main = main;
            Tasks = tasks;
            itemsToDelete = new List<Classes.Task>();
            foreach (var task in Tasks)
            {
                if (task.IsSelected)
                    itemsToDelete.Add(task);
            }
            NoticeLabel.Text = $"Выбрано элементов для удаления: {itemsToDelete.Count}";
        }

        private void CacncelDeleteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (var task in itemsToDelete)
            {
                Tasks.Remove(task);
            }

            Main.UpdateInfoBlocks();
            Main.ShowAllItems();
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }
    }
}
