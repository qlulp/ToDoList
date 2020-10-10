namespace ToDoList
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormIcon = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.TaskListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.infoBlock3 = new ToDoList.Controls.InfoBlock();
            this.infoBlock2 = new ToDoList.Controls.InfoBlock();
            this.infoBlock1 = new ToDoList.Controls.InfoBlock();
            this.infoBlock4 = new ToDoList.Controls.InfoBlock();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Controls.Add(this.FormIcon);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(774, 27);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDoubleClick);
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(31, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(84, 15);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Список задач";
            // 
            // FormIcon
            // 
            this.FormIcon.Image = global::ToDoList.Properties.Resources.FormIcon;
            this.FormIcon.Location = new System.Drawing.Point(3, 3);
            this.FormIcon.Name = "FormIcon";
            this.FormIcon.Size = new System.Drawing.Size(22, 22);
            this.FormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FormIcon.TabIndex = 2;
            this.FormIcon.TabStop = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(721, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(21, 13);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "__";
            this.MinimizeButton.Click += new System.EventHandler(this.HideButton_Click);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.HideButton_MouseLeave);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.HideButton_MouseHover);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(748, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 13);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddTaskButton.CausesValidation = false;
            this.AddTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.AddTaskButton.FlatAppearance.BorderSize = 2;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.AddTaskButton.Location = new System.Drawing.Point(682, 67);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(84, 30);
            this.AddTaskButton.TabIndex = 2;
            this.AddTaskButton.TabStop = false;
            this.AddTaskButton.Text = "Добавить";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // TaskListPanel
            // 
            this.TaskListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListPanel.AutoScroll = true;
            this.TaskListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TaskListPanel.Location = new System.Drawing.Point(0, 103);
            this.TaskListPanel.Name = "TaskListPanel";
            this.TaskListPanel.Padding = new System.Windows.Forms.Padding(5);
            this.TaskListPanel.Size = new System.Drawing.Size(774, 390);
            this.TaskListPanel.TabIndex = 3;
            this.TaskListPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListPanel_MouseDown);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.CausesValidation = false;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.DeleteButton.Location = new System.Drawing.Point(600, 67);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(76, 30);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditButton.CausesValidation = false;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.EditButton.FlatAppearance.BorderSize = 2;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.EditButton.Location = new System.Drawing.Point(500, 67);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 30);
            this.EditButton.TabIndex = 5;
            this.EditButton.TabStop = false;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(500, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.CausesValidation = false;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatAppearance.BorderSize = 2;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.SearchButton.Location = new System.Drawing.Point(682, 32);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 30);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.TabStop = false;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // infoBlock3
            // 
            this.infoBlock3.Angle = 50F;
            this.infoBlock3.Count = "10\r\n";
            this.infoBlock3.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(235)))));
            this.infoBlock3.Location = new System.Drawing.Point(245, 34);
            this.infoBlock3.Name = "infoBlock3";
            this.infoBlock3.Padding = new System.Windows.Forms.Padding(5);
            this.infoBlock3.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(253)))));
            this.infoBlock3.Size = new System.Drawing.Size(113, 63);
            this.infoBlock3.TabIndex = 13;
            this.infoBlock3.Title = "Выполнено";
            // 
            // infoBlock2
            // 
            this.infoBlock2.Angle = 140F;
            this.infoBlock2.Count = "10\r\n";
            this.infoBlock2.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(153)))));
            this.infoBlock2.Location = new System.Drawing.Point(121, 34);
            this.infoBlock2.Name = "infoBlock2";
            this.infoBlock2.Padding = new System.Windows.Forms.Padding(5);
            this.infoBlock2.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.infoBlock2.Size = new System.Drawing.Size(118, 63);
            this.infoBlock2.TabIndex = 12;
            this.infoBlock2.Title = "Выбрано";
            // 
            // infoBlock1
            // 
            this.infoBlock1.Angle = 150F;
            this.infoBlock1.Count = "10\r\n";
            this.infoBlock1.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(101)))), ((int)(((byte)(250)))));
            this.infoBlock1.Location = new System.Drawing.Point(4, 34);
            this.infoBlock1.Name = "infoBlock1";
            this.infoBlock1.Padding = new System.Windows.Forms.Padding(5);
            this.infoBlock1.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(97)))), ((int)(((byte)(182)))));
            this.infoBlock1.Size = new System.Drawing.Size(111, 63);
            this.infoBlock1.TabIndex = 11;
            this.infoBlock1.Title = "Всего";
            // 
            // infoBlock4
            // 
            this.infoBlock4.Angle = 50F;
            this.infoBlock4.Count = "10\r\n";
            this.infoBlock4.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(77)))));
            this.infoBlock4.Location = new System.Drawing.Point(364, 34);
            this.infoBlock4.Name = "infoBlock4";
            this.infoBlock4.Padding = new System.Windows.Forms.Padding(5);
            this.infoBlock4.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(138)))), ((int)(((byte)(140)))));
            this.infoBlock4.Size = new System.Drawing.Size(130, 63);
            this.infoBlock4.TabIndex = 14;
            this.infoBlock4.Title = "Не выполнено";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(774, 491);
            this.Controls.Add(this.infoBlock4);
            this.Controls.Add(this.infoBlock3);
            this.Controls.Add(this.infoBlock2);
            this.Controls.Add(this.infoBlock1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TaskListPanel);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.PictureBox FormIcon;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.FlowLayoutPanel TaskListPanel;
        private System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private Controls.InfoBlock infoBlock1;
        private Controls.InfoBlock infoBlock2;
        private Controls.InfoBlock infoBlock3;
        private Controls.InfoBlock infoBlock4;
    }
}

