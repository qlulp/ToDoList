namespace ToDoList.Forms
{
    partial class DeleteTasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTasksForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormIcon = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CacncelDeleteButton = new System.Windows.Forms.Button();
            this.NoticeLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Controls.Add(this.FormIcon);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(201, 27);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(31, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(64, 15);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Удаление";
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
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(175, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 13);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Tag = "ацу";
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.CausesValidation = false;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(12, 95);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(76, 30);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CacncelDeleteButton
            // 
            this.CacncelDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CacncelDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CacncelDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CacncelDeleteButton.CausesValidation = false;
            this.CacncelDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CacncelDeleteButton.FlatAppearance.BorderSize = 0;
            this.CacncelDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CacncelDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CacncelDeleteButton.ForeColor = System.Drawing.Color.White;
            this.CacncelDeleteButton.Location = new System.Drawing.Point(113, 95);
            this.CacncelDeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.CacncelDeleteButton.Name = "CacncelDeleteButton";
            this.CacncelDeleteButton.Size = new System.Drawing.Size(76, 30);
            this.CacncelDeleteButton.TabIndex = 6;
            this.CacncelDeleteButton.TabStop = false;
            this.CacncelDeleteButton.Text = "Отмена";
            this.CacncelDeleteButton.UseVisualStyleBackColor = false;
            this.CacncelDeleteButton.Click += new System.EventHandler(this.CacncelDeleteButton_Click);
            // 
            // NoticeLabel
            // 
            this.NoticeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoticeLabel.Location = new System.Drawing.Point(9, 32);
            this.NoticeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.NoticeLabel.Name = "NoticeLabel";
            this.NoticeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.NoticeLabel.Size = new System.Drawing.Size(177, 58);
            this.NoticeLabel.TabIndex = 7;
            this.NoticeLabel.Text = "Выбрано элементов для удаления: ";
            this.NoticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(201, 137);
            this.Controls.Add(this.NoticeLabel);
            this.Controls.Add(this.CacncelDeleteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteTasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CacncelDeleteButton;
        private System.Windows.Forms.Label NoticeLabel;
        private System.Windows.Forms.PictureBox FormIcon;
    }
}