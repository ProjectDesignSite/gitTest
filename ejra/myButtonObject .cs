using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejra
{
    public partial class myButtonObject : UserControl
    {
        public myButtonObject()
        {
            InitializeComponent();
        }

        private void myButtonObject_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            // Draw the button in the form of a circle
            graphics.DrawEllipse(myPen, 0, 0, 100, 100);
            SolidBrush brush = new SolidBrush(Color.Bisque);
            graphics.FillEllipse(brush, 0, 0, 100, 100);
            myPen.Dispose();
        }
    }
}
