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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormIcon = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.NotDoneInfoBlock = new ToDoList.Controls.InfoBlock();
            this.DoneInfoBlock = new ToDoList.Controls.InfoBlock();
            this.SelectedInfoBlock = new ToDoList.Controls.InfoBlock();
            this.AllInfoBlock = new ToDoList.Controls.InfoBlock();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(215)))));
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Controls.Add(this.FormIcon);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.FormIcon.Image = global::ToDoList.Properties.Resources.CheckBoxTrue;
            this.FormIcon.Location = new System.Drawing.Point(3, 2);
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
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(748, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 13);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Tag = "ацу";
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.AddTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddTaskButton.CausesValidation = false;
            this.AddTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTaskButton.FlatAppearance.BorderSize = 0;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskButton.ForeColor = System.Drawing.Color.White;
            this.AddTaskButton.Location = new System.Drawing.Point(682, 67);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(84, 30);
            this.AddTaskButton.TabIndex = 2;
            this.AddTaskButton.TabStop = false;
            this.AddTaskButton.Text = "Добавить";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.CausesValidation = false;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(600, 67);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(76, 30);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.CausesValidation = false;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(500, 67);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 30);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(500, 34);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(176, 26);
            this.SearchTextBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.CausesValidation = false;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(682, 32);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 30);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.TabStop = false;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoScroll = true;
            this.Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Location = new System.Drawing.Point(0, 103);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(774, 386);
            this.Table.TabIndex = 15;
            // 
            // NotDoneInfoBlock
            // 
            this.NotDoneInfoBlock.Angle = 150F;
            this.NotDoneInfoBlock.Count = "10\r\n";
            this.NotDoneInfoBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotDoneInfoBlock.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(91)))), ((int)(((byte)(215)))));
            this.NotDoneInfoBlock.Location = new System.Drawing.Point(364, 34);
            this.NotDoneInfoBlock.Name = "NotDoneInfoBlock";
            this.NotDoneInfoBlock.Padding = new System.Windows.Forms.Padding(5);
            this.NotDoneInfoBlock.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(253)))));
            this.NotDoneInfoBlock.Size = new System.Drawing.Size(130, 63);
            this.NotDoneInfoBlock.TabIndex = 14;
            this.NotDoneInfoBlock.Title = "Не выполнено";
            this.NotDoneInfoBlock.Click += new System.EventHandler(this.NotDoneInfoBlock_Click);
            // 
            // DoneInfoBlock
            // 
            this.DoneInfoBlock.Angle = 50F;
            this.DoneInfoBlock.Count = "10\r\n";
            this.DoneInfoBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneInfoBlock.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(235)))));
            this.DoneInfoBlock.Location = new System.Drawing.Point(245, 34);
            this.DoneInfoBlock.Name = "DoneInfoBlock";
            this.DoneInfoBlock.Padding = new System.Windows.Forms.Padding(5);
            this.DoneInfoBlock.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(169)))), ((int)(((byte)(253)))));
            this.DoneInfoBlock.Size = new System.Drawing.Size(113, 63);
            this.DoneInfoBlock.TabIndex = 13;
            this.DoneInfoBlock.Title = "Выполнено";
            this.DoneInfoBlock.Click += new System.EventHandler(this.DoneInfoBlock_Click);
            // 
            // SelectedInfoBlock
            // 
            this.SelectedInfoBlock.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.SelectedInfoBlock.Angle = 50F;
            this.SelectedInfoBlock.Count = "10\r\n";
            this.SelectedInfoBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectedInfoBlock.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(101)))), ((int)(((byte)(250)))));
            this.SelectedInfoBlock.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SelectedInfoBlock.Location = new System.Drawing.Point(121, 34);
            this.SelectedInfoBlock.Name = "SelectedInfoBlock";
            this.SelectedInfoBlock.Padding = new System.Windows.Forms.Padding(5);
            this.SelectedInfoBlock.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(67)))), ((int)(((byte)(232)))));
            this.SelectedInfoBlock.Size = new System.Drawing.Size(118, 63);
            this.SelectedInfoBlock.TabIndex = 12;
            this.SelectedInfoBlock.Title = "Выбрано";
            this.SelectedInfoBlock.Click += new System.EventHandler(this.SelectedInfoBlock_Click);
            // 
            // AllInfoBlock
            // 
            this.AllInfoBlock.Angle = 150F;
            this.AllInfoBlock.Count = "10\r\n";
            this.AllInfoBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllInfoBlock.FisrtColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(101)))), ((int)(((byte)(250)))));
            this.AllInfoBlock.Location = new System.Drawing.Point(4, 34);
            this.AllInfoBlock.Name = "AllInfoBlock";
            this.AllInfoBlock.Padding = new System.Windows.Forms.Padding(5);
            this.AllInfoBlock.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            this.AllInfoBlock.Size = new System.Drawing.Size(111, 63);
            this.AllInfoBlock.TabIndex = 11;
            this.AllInfoBlock.Title = "Всего";
            this.AllInfoBlock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllInfoBlock_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(774, 491);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.NotDoneInfoBlock);
            this.Controls.Add(this.DoneInfoBlock);
            this.Controls.Add(this.SelectedInfoBlock);
            this.Controls.Add(this.AllInfoBlock);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список задач";
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
        private System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private Controls.InfoBlock AllInfoBlock;
        private Controls.InfoBlock SelectedInfoBlock;
        private Controls.InfoBlock DoneInfoBlock;
        private Controls.InfoBlock NotDoneInfoBlock;
        private System.Windows.Forms.TableLayoutPanel Table;
    }
}

