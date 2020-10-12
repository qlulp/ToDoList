namespace ToDoList.Controls
{
    partial class ListElement
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateLabel = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.CheckPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.Gray;
            this.DateLabel.Location = new System.Drawing.Point(278, 4);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(74, 36);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Today";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskLabel
            // 
            this.TaskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskLabel.AutoEllipsis = true;
            this.TaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(101)))));
            this.TaskLabel.Location = new System.Drawing.Point(39, 4);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TaskLabel.Size = new System.Drawing.Size(233, 36);
            this.TaskLabel.TabIndex = 1;
            this.TaskLabel.Text = "Task";
            this.TaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskLabel.Click += new System.EventHandler(this.TaskLabel_Click);
            // 
            // CheckPictureBox
            // 
            this.CheckPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(196)))), ((int)(((byte)(83)))));
            this.CheckPictureBox.Location = new System.Drawing.Point(10, 13);
            this.CheckPictureBox.Name = "CheckPictureBox";
            this.CheckPictureBox.Size = new System.Drawing.Size(20, 20);
            this.CheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckPictureBox.TabIndex = 2;
            this.CheckPictureBox.TabStop = false;
            this.CheckPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPictureBox_MouseClick);
            // 
            // ListElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CheckPictureBox);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.DateLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1900, 45);
            this.MinimumSize = new System.Drawing.Size(150, 45);
            this.Name = "ListElement";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(360, 45);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CheckPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.PictureBox CheckPictureBox;
    }
}
