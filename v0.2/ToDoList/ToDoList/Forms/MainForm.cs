using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ToDoList.Classes;
using ToDoList.Controls;
using ToDoList.Forms;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        private AddTask AddTaskForm;
        private DeleteTasksForm DeleteForm;
        public List<Task> Tasks;
        public MainForm()
        {
            InitializeComponent();

            Tasks = DataManager.Deserialize();
            ShowAllItems();
            UpdateInfoBlocks();
            Table.Select();
        }

        private void ClearTable()
        {
            Table.RowStyles.Clear();
            Table.Controls.Clear();
        }

        public void ShowAllItems()
        {
            ClearTable();

            foreach (var task in Tasks)
            {
                Table.Controls.Add(new ListElement(this, task));
            }

            UpdateInfoBlocks();
        }

        public void ShowSelectedItems()
        {
            ClearTable();
            foreach (var task in Tasks)
            {
                if (task.IsSelected)
                    Table.Controls.Add(new ListElement(this, task));
            }
        }

        public void ShowDoneItems()
        {
            ClearTable();
            foreach (var task in Tasks)
            {
                if (task.IsDone)
                    Table.Controls.Add(new ListElement(this, task));
            }
        }

        public void ShowNotDoneItems()
        {
            ClearTable();
            foreach (var task in Tasks)
            {
                if (!task.IsDone)
                    Table.Controls.Add(new ListElement(this, task));
            }
        }

        private void CreateItems()
        {
            Table.RowStyles.Clear();
            for (int i = 0; i < 100; i++)
            {
                Tasks.Add(new Task
                (
                    isDone: false,
                    isSelected: false,
                    dateTime: DateTime.Now,
                    content: $"Задача {i}"
                ));
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
            DataManager.Serialize(Tasks);
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
            AddTaskForm = new AddTask(this);
            AddTaskForm.Show();
        }

        public void UpdateAllInfoBlock()
        {
            AllInfoBlock.Count = DataManager.GetCountOfItems(Tasks).ToString();
        }

        public void UpdateSelectedInfoBlock()
        {
            SelectedInfoBlock.Count = DataManager.GetCountOfSelectedItems(Tasks).ToString();
        }

        public void UpdateDoneInfoBlock()
        {
            DoneInfoBlock.Count = DataManager.GetCountOfDoneItems(Tasks).ToString();
        }

        public void UpdateNotDoneInfoBlock()
        {
            NotDoneInfoBlock.Count = DataManager.GetCountOfNotDoneItems(Tasks).ToString();
        }

        public void UpdateInfoBlocks()
        {
            UpdateAllInfoBlock();
            UpdateSelectedInfoBlock();
            UpdateDoneInfoBlock();
            UpdateNotDoneInfoBlock();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DataManager.GetCountOfSelectedItems(Tasks) > 0)
            {
                if (DeleteForm != null)
                {
                    DeleteForm.Close();
                }

                DeleteForm = new DeleteTasksForm(this, Tasks);
                DeleteForm.Show();
            }
        }

        private void AllInfoBlock_MouseDown(object sender, MouseEventArgs e)
        {
            ShowAllItems();
        }

        private void SelectedInfoBlock_Click(object sender, EventArgs e)
        {
            ShowSelectedItems();
        }

        private void DoneInfoBlock_Click(object sender, EventArgs e)
        {
            ShowDoneItems();
        }

        private void NotDoneInfoBlock_Click(object sender, EventArgs e)
        {
            ShowNotDoneItems();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataManager.Serialize
            (
               tasks: Tasks, 
               showMessage: true
            );
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != string.Empty)
            {
                int countOfSuitableOptions = 0;
                foreach (var task in Tasks)
                    if (task.Content.IndexOf(SearchTextBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                        countOfSuitableOptions++;

                if (countOfSuitableOptions > 0)
                {
                    ClearTable();
                    foreach (var task in Tasks)
                    {
                        if (task.Content.IndexOf(SearchTextBox.Text, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            Table.Controls.Add(new ListElement(this, task));
                        }
                    }
                    SearchTextBox.Text = string.Empty;
                }
            }
        }
    }
}
