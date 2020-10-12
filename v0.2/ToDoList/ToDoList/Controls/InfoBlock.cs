using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ToDoList.Controls
{
    public partial class InfoBlock : UserControl
    {
        public Color FisrtColor { get; set; }
        public Color SecondColor { get; set; }

        public string Title
        {
            get => TitleLabel.Text;
            set => TitleLabel.Text = value;
        }

        public string Count
        {
            get => CountLabel.Text;
            set => CountLabel.Text = value;
        }

        public float Angle { get; set; }
        public InfoBlock()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e);
            LinearGradientBrush brush = new LinearGradientBrush
            (
                this.ClientRectangle,
                this.FisrtColor,
                this.SecondColor,
                this.Angle
            );
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e); 
        }
    }
}
