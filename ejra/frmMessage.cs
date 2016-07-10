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
    public partial class FrmMessage : DevComponents.DotNetBar.Metro.MetroForm
    {
        static FrmMessage newMessageBox;
        static string Button_id;
        public FrmMessage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e,string str)
        {
            label2.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCancel.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public DialogResult Show(string text, Color foreColour)
        {
            label2.Text = text;
            label2.ForeColor = foreColour;
            return this.ShowDialog();
        }

       
        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new FrmMessage();
            newMessageBox.label2.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }
        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new FrmMessage();
            newMessageBox.label2.Text = txtMessage;
            newMessageBox.Text = txtTitle;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newMessageBox.Dispose();
            Button_id = "2";
        }
    }
}