namespace ToDoList.Controls
{
    partial class AddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.TaskContentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormIcon = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelAddTaskButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskContentTextBox
            // 
            this.TaskContentTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TaskContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskContentTextBox.Location = new System.Drawing.Point(73, 37);
            this.TaskContentTextBox.Name = "TaskContentTextBox";
            this.TaskContentTextBox.Size = new System.Drawing.Size(162, 26);
            this.TaskContentTextBox.TabIndex = 0;
            this.TaskContentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TaskContentTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задача:";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(184)))), ((int)(((byte)(83)))));
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Controls.Add(this.FormIcon);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(248, 27);
            this.HeaderPanel.TabIndex = 2;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(31, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(106, 15);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Добавить задачу";
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
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(222, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 13);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(9, 74);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(108, 16);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Дата создания:";
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.BackColor = System.Drawing.Color.Transparent;
            this.TimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLable.Location = new System.Drawing.Point(9, 104);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(117, 16);
            this.TimeLable.TabIndex = 5;
            this.TimeLable.Text = "Время создания:";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(196)))), ((int)(((byte)(81)))));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.CausesValidation = false;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(12, 140);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 30);
            this.AddButton.TabIndex = 6;
            this.AddButton.TabStop = false;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelAddTaskButton
            // 
            this.CancelAddTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelAddTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(196)))), ((int)(((byte)(81)))));
            this.CancelAddTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelAddTaskButton.CausesValidation = false;
            this.CancelAddTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelAddTaskButton.FlatAppearance.BorderSize = 0;
            this.CancelAddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAddTaskButton.ForeColor = System.Drawing.Color.White;
            this.CancelAddTaskButton.Location = new System.Drawing.Point(150, 140);
            this.CancelAddTaskButton.Name = "CancelAddTaskButton";
            this.CancelAddTaskButton.Size = new System.Drawing.Size(85, 30);
            this.CancelAddTaskButton.TabIndex = 7;
            this.CancelAddTaskButton.TabStop = false;
            this.CancelAddTaskButton.Text = "Отмена";
            this.CancelAddTaskButton.UseVisualStyleBackColor = false;
            this.CancelAddTaskButton.Click += new System.EventHandler(this.CancelAddTaskButton_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(247, 182);
            this.Controls.Add(this.CancelAddTaskButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskContentTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавит задачу";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskContentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox FormIcon;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelAddTaskButton;
    }
}