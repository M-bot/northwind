using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Header : Panel
    {
        private GradientPanel gp;
        private GradientPanel gp2;

        public Header()
        {
            InitializeComponent();
            ResizeRedraw = true;
            DoubleBuffered = true;

            gp = new GradientPanel();
            gp.Colors = new[] { Color.FromArgb(190, 73, 17), Color.FromArgb(235, 93, 25), Color.FromArgb(190, 73, 17) };
            gp.Positions = new[] { 0, .5f, 1 };

            gp2 = new GradientPanel();
            gp2.Colors = new[] { Color.FromArgb(154, 151, 139), Color.FromArgb(215, 215, 211), Color.FromArgb(186, 185, 177) };
            gp2.Positions = new[] { 0, .7f, 1 };
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            gp.Size = this.Size;
            gp.PaintLinear(g, 0, 0);
            Console.WriteLine(this.Location.Y + " " + (this.Location.Y + 44));
            gp2.Location = new Point(this.Location.X, this.Location.Y + 44);
            gp2.Size = new Size(this.Size.Width, (int)(this.Size.Height/(72f/26f)));
            gp2.PaintLinear(g, 0, 44);
        }
    }
}
