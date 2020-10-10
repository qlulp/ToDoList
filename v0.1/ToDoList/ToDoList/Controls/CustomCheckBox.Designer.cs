namespace ToDoList.Controls
{
    partial class CustomCheckBox
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
            this.CheckBoxPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxPicture
            // 
            this.CheckBoxPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(199)))), ((int)(((byte)(165)))));
            this.CheckBoxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxPicture.Image = global::ToDoList.Properties.Resources.CheckBoxTrue;
            this.CheckBoxPicture.Location = new System.Drawing.Point(0, 0);
            this.CheckBoxPicture.Name = "CheckBoxPicture";
            this.CheckBoxPicture.Size = new System.Drawing.Size(150, 150);
            this.CheckBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckBoxPicture.TabIndex = 0;
            this.CheckBoxPicture.TabStop = false;
            this.CheckBoxPicture.Click += new System.EventHandler(this.CheckBoxPicture_Click);
            // 
            // CustomCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckBoxPicture);
            this.Name = "CustomCheckBox";
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CheckBoxPicture;
    }
}
