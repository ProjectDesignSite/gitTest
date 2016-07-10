using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ejra
{
    public partial class MainFrm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainFrm()
        {
            InitializeComponent();
            System.Globalization.CultureInfo TypeOfLanguage = new System.Globalization.CultureInfo("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    uccheque.Visible = false;
        //    ucTaxpayerFiles1.Visible = true;
           
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    uccheque.Visible = true;
        //    ucTaxpayerFiles1.Visible = false;
        //}

        private void uccheque_Load(object sender, EventArgs e)
        {

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //this.Opacity = 0;
            //timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Make Form Visible a Bit more on Every timer Tick
           //this.Opacity += 0.07;
        }
        
        private void btnChequeFrm_Click(object sender, EventArgs e)
        {
           fadeWinForm();
            //this.Opacity = 60;
            //timer1.Enabled = true;
           // fadeout();
            ucTaxFiles1.Visible = false;
            userControl11.Visible = true;
        }

        private void btnTaxFiles_Click(object sender, EventArgs e)
        {
            //FrmMessage fr = new FrmMessage();
            //DialogResult result = fr.ShowDialog();
            //if (result == DialogResult.OK)
            //{
                // etc
                fadeWinForm();
                ucTaxFiles1.Visible = true;
                userControl11.Visible = false;
           // }
            
            
        }

        private void btnChequeFrm_MouseHover(object sender, EventArgs e)
        {
           // btnChequeFrm.BackColor = Color.White;
            btnChequeFrm.Width = 130;
            btnChequeFrm.BringToFront();  
        }

        private void btnChequeFrm_MouseLeave(object sender, EventArgs e)
        {
            //btnChequeFrm.BackColor = Color.Red;
            btnChequeFrm.Width = 75;  
        }

        private void btnTaxFiles_MouseHover(object sender, EventArgs e)
        {
            btnTaxFiles.Width = 130;
            btnTaxFiles.Height = 60;
            btnChequeFrm.BringToFront();
           
        }

        private void btnTaxFiles_MouseLeave(object sender, EventArgs e)
        {
            btnTaxFiles.Width = 75;
            btnTaxFiles.Height = 45;
        }

        private void ucTaxFiles1_Load(object sender, EventArgs e)
        {

        }
         private void fadeout()
        {
            this.Opacity -= 0.01;

        if (this.Opacity <= 0)
        {
            this.Close();
        }   
        }
        private void fadeWinForm()
        {
            int duration = 200;//in milliseconds
            int steps = 50;
            Timer timer = new Timer();
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }
    }
}