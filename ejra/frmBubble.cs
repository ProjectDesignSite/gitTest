using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejra
{
    public partial class frmBubble : Form
    {
        public frmBubble()
        {
            InitializeComponent();
            myButtonObject myButton = new myButtonObject();
            EventHandler myHandler = new EventHandler(myButton_Click);
            myButton.Click += myHandler;
            myButton.Location = new System.Drawing.Point(20, 20);
            myButton.Size = new System.Drawing.Size(300, 300);
            this.Controls.Add(myButton);
        }
        void myButton_Click(Object sender, System.EventArgs e)
        {
            MessageBox.Show("Click");
        }
        private void frmBubble_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void roundButton2_MouseLeave(object sender, EventArgs e)
        {
            roundButton2.Height -= 20;
            roundButton2.Width -= 20;
        }

        private void roundButton2_MouseHover(object sender, EventArgs e)
        {
            roundButton2.Height += 20;
            roundButton2.Width += 20;
           
        }

        private void roundButton3_MouseHover(object sender, EventArgs e)
        {
            roundButton3.Height += 20;
            roundButton3.Width += 20;
        }

        private void roundButton3_MouseLeave(object sender, EventArgs e)
        {
            roundButton3.Height=92;
            roundButton3.Width =86;
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin();
            fr.Show();
        }

       

        
    }
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
          
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
        
    }
}
