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

namespace Northwind
{
    public partial class GradientPanel : Panel
    {
        public Color PrimaryColor;
        public Color SecondaryColor;
        public Boolean Radial;
        public float[] Positions;
        public Color[] Colors;

        public GradientPanel()
        {
            InitializeComponent();
            ResizeRedraw = true;
            DoubleBuffered = true;
            Radial = false;
            Positions = new[] { 0f, 1f };
            Colors = new[] { Color.Black, Color.White };
            PrimaryColor = Color.Black;
            SecondaryColor = Color.White;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            
            if (this.Width == 0 || this.Height == 0) return;
            if (Radial)
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                base.OnPaintBackground(pevent);
                var ellipsePath = new GraphicsPath();
                ellipsePath.AddEllipse(rect);
                var brush = new PathGradientBrush(ellipsePath);
                brush.CenterPoint = new PointF(rect.Width / 2f, rect.Height / 2f);
                brush.CenterColor = PrimaryColor;
                brush.SurroundColors = new[] { SecondaryColor };
                brush.FocusScales = new PointF(0.7f, 0.7f);
                g.FillRectangle(brush, rect);
                brush.Dispose();
            }
            else
                PaintLinear(g, 0, 0);
        }

        public void PaintLinear(Graphics g, int x, int y)
        {
            this.Height = this.Height == 0 ? 1 : this.Height;
            this.Width = this.Width == 0 ? 1 : this.Width;
            Rectangle rect = new Rectangle(x, y, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Black, Color.Black, 0f);
            ColorBlend cb = new ColorBlend();
            cb.Positions = this.Positions;
            cb.Colors = this.Colors;
            brush.InterpolationColors = cb;
            g.FillRectangle(brush, rect);
            brush.Dispose();
        }
    }
}
