using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;

namespace ejra
{
    public partial class frmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {

                showMessage("نام کاربری  را وارد کنید");
            }

            else if (txtPassword.Text == "")
            {
                showMessage("کلمه عبور را وارد کنید");
            }
            else
            {


                string hashPassword = CreatePasswordHash(txtPassword.Text);
                myDataClassesDataContext db1 = new myDataClassesDataContext();
               
                if (db1.DatabaseExists())
                {
                    var query = (from m in db1.userTbls
                                 where m.username.Equals(txtUsername.Text) && m.password.Equals(hashPassword)
                                 select m).Count();
                    if (query.ToString() == "0")
                    {
                        showMessage("نام کاربری یا کلمه عبور نادرست است");

                    }
                    else
                    {
                        this.Hide();
                        var form1 = new MainFrm();
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();

                    }
                }
                else
                {
                    showMessage("پایگاه داده متصل تیست.");
                }
            }
        }
           

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void showMessage(string str)
        {
            lblMessage.Show();
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = str;
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, e2) =>
            {
                lblMessage.Hide();
                t.Stop();
            };
            t.Start();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guid userGuid = System.Guid.NewGuid();
            string hashedPassword = CreatePasswordHash(txtPassword.Text);
            using (myDataClassesDataContext dtContext = new myDataClassesDataContext())
            {
                userTbl uDetail = new userTbl
                {
                    username = txtUsername.Text,
                    password = hashedPassword,
                    //UserGuid = userGuid,
                };
                dtContext.userTbls.InsertOnSubmit(uDetail);
                dtContext.SubmitChanges();
            }
        }

        public static string CreatePasswordHash(string plainpassword)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(plainpassword);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }
    }
}