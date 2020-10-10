using System;
using System.Windows.Forms;

namespace ToDoList.Controls
{
    public partial class CustomCheckBox : UserControl
    {
        public bool IsChecked
        {
            get => CheckBoxPicture.Image == null ? false : true;
            set => CheckBoxPicture.Image = value ? Properties.Resources.CheckBoxTrue : null;
        }
        public CustomCheckBox()
        {
            InitializeComponent();
        }

        private void CheckBoxPicture_Click(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
        }
    }
}
