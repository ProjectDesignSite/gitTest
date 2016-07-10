using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ejra
{
    public partial class UCTaxFiles : UserControl
    {
        static int mod;
        public UCTaxFiles()
        {
            InitializeComponent();
        }
        private void RetrieveDetails()
        {
            myDataClassesDataContext dtContext = new myDataClassesDataContext();
            var query = from m in dtContext.FilesTaxPayers
                        select new
                        {
                            //0
                            m.KLAS,
                            //1
                            m.NAME,
                            //2
                            m.FNAME,
                            //3
                            m.FATHER,
                            //4
                            m.NO_SHEN,
                            //5
                            m.CONAME,
                            //6
                            m.NO_SABT,
                            //7                                     
                            m.HOZE,
                            //8
                            m.KODVAZ,
                            //9 
                            m.SAL,
                            //10
                            m.SAL2,
                            //11
                            m.MABL,
                            //12
                            m.DEGR1,
                            //13
                            m.DEGR2,
                            //14
                            m.ARSAL,
                            //15
                            m.ADDRESS,
                            //نمایش داده نمی شود
                            m.id
                        };
            //take top 10 row, for efficency
            radGridView1.DataSource = query.Take(10);
            //adjust header column title and size
            AdjustDataGridView();


        }

        private void AdjustDataGridView()
        {
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            string[] headerColumnArray = new string[] { "کلاسه", "نام", "نام خانوادگی", "نام پدر", "شماره شناسنامه" ,
            "نام شرکت","شماره ثبت","حوزه","وضعیت","از سال","تا سال","مبلغ","تاریخ ", "تاریخ مختومه",  "فرستنده","آدرس"};
            for (int i = 0; i < 15; i++)
            {
                radGridView1.Columns[i].HeaderText = headerColumnArray[i];
                this.radGridView1.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
                this.radGridView1.Columns[i].Width = 100;
                this.radGridView1.Columns[i].AllowResize = false;
            }
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            RetrieveDetails();
        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GridViewRowInfo CurrentRow = e.Row;
                DisplayDataInTopPanel(CurrentRow);
               
            }

        }

        private void DisplayDataInTopPanel(GridViewRowInfo row)
        {

            txtID.Text = row.Cells[16].Value.ToString();

            if (row.Cells[0].Value == null)
                txtClass.Text = "";
            else
                txtClass.Text = row.Cells[0].Value.ToString();

            if (row.Cells[1].Value == null)
                txtFirstName.Text = "";
            else
                txtFirstName.Text = row.Cells[1].Value.ToString();

            if (row.Cells[2].Value == null)
                txtLastName.Text = "";
            else
                txtLastName.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value == null)
                txtFatherName.Text = "";
            else
                txtFatherName.Text = row.Cells[3].Value.ToString();

            if (row.Cells[4].Value == null)
                txtShomareShenasnameh.Text = "";
            else
                txtShomareShenasnameh.Text = row.Cells[4].Value.ToString();

            if (row.Cells[5].Value == null)
                txtCopName.Text = "";
            else
                txtCopName.Text = row.Cells[5].Value.ToString();
            if (row.Cells[6].Value == null)
                txtRegCode.Text = "";
            else
                txtRegCode.Text = row.Cells[6].Value.ToString();

            if (row.Cells[7].Value == null)
                txtTaxUnit.Text = "";
            else
                txtTaxUnit.Text = row.Cells[7].Value.ToString();

            if (row.Cells[8].Value == null)
                cmbStatus.SelectedIndex = -1;
            else

                cmbStatus.SelectedIndex = Int32.Parse(row.Cells[8].Value.ToString());

            if (row.Cells[9].Value == null)
                txtFromYear.Text = "";
            else
                txtFromYear.Text = row.Cells[9].Value.ToString();

            if (row.Cells[10].Value == null)
                txtUntilYear.Text = "";
            else
                txtUntilYear.Text = row.Cells[10].Value.ToString();

            if (row.Cells[11].Value == null)
                txtTaxAmount.Text = "";
            else
            {
                //txtTaxAmount.Text = string.Format("{0:N0}", row.Cells[11].Value);
                txtTaxAmount.Text = row.Cells[11].Value.ToString();
            }

            if (row.Cells[12].Value == null)
                mtxtDate1.Text = "";
            else
                mtxtDate1.Text = row.Cells[12].Value.ToString();

            if (row.Cells[13].Value == null)
                mtxtDate2.Text = "";
            else
                mtxtDate2.Text = row.Cells[13].Value.ToString();

            if (row.Cells[14].Value == null)
                txtSender.Text = "";
            else
                txtSender.Text = row.Cells[14].Value.ToString();

            if (row.Cells[15].Value == null)
                txtAddress.Text = "";
            else
                txtAddress.Text = row.Cells[15].Value.ToString();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            search();
        }

        private void search()
        {
            myDataClassesDataContext dtContext = new myDataClassesDataContext();
            var query = from m in dtContext.FilesTaxPayers

                        select new
                        {
                            //0
                            m.KLAS,
                            //1
                            m.NAME,
                            //2
                            m.FNAME,
                            //3
                            m.FATHER,
                            //4
                            m.NO_SHEN,
                            //5
                            m.CONAME,
                            //6
                            m.NO_SABT,
                            //7                                     
                            m.HOZE,
                            //8
                            m.KODVAZ,
                            //9 
                            m.SAL,
                            //10
                            m.SAL2,
                            //11
                            m.MABL,
                            //12
                            m.DEGR1,
                            //13
                            m.DEGR2,
                            //14
                            m.ARSAL,
                            //15
                            m.ADDRESS,
                            m.id


                        };

            if (rdbFirestName.Checked) query = query.Where(m => m.NAME.Contains(txtSearch.Text));
            else if (rdbLastName.Checked) query = query.Where(m => m.FNAME.Contains(txtSearch.Text));
            else if (rdbClass.Checked) query = query.Where(m => m.KLAS.ToString().Contains(txtSearch.Text));
            radGridView1.DataSource = query;
            AdjustDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (txtClass.Text == "")
                showMessage("لطفا برای حذف یک کلاسه معتبر وارد کنید");
            else
            {
                if (!checkExistClass(txtClass.Text))
                {
                    showMessage("چنین کلاسه ای وجود ندارد");
                }

                else
                {
                    string btnClicked = FrmMessage.ShowBox("آیا از حذف پرونده با شماره " + txtClass.Text.Trim() + " مطمئن هستید؟ ");

                    if (btnClicked == "1")
                    {
                        using (myDataClassesDataContext dtContext = new myDataClassesDataContext())
                        {
                            FilesTaxPayer Udetails = dtContext.FilesTaxPayers.SingleOrDefault(x => x.id == Int32.Parse(txtID.Text));
                            dtContext.FilesTaxPayers.DeleteOnSubmit(Udetails);
                            dtContext.SubmitChanges();
                            showMessage("حذف با موفقیت صورت گرفت");
                        }
                        RetrieveDetails();
                        clearAllInputControls(this);
                    } 

                    else
                    {

                    }
                }

            }
        }
        private bool checkExistClass(string str)
        {
            myDataClassesDataContext db1 = new myDataClassesDataContext();
            var query = (from m in db1.FilesTaxPayers
                         where m.KLAS == str
                         select m).Count();
            if (query.ToString() == "0")
                return false;
            return true;

        }
        private void clearAllInputControls(Control con)
        {
            clearAllTextBox(this);
            cmbStatus.ResetText();
            mtxtDate2.ResetText();
            mtxtDate1.ResetText();
        }
        void clearAllTextBox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    clearAllTextBox(c);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            mod = 0;//search,normal
            enableInputControls(this, false);
            changeStatusBtnControls(this, true);
            radGridView1.Enabled = true;
        }
        private void changeStatusBtnControls(Control con, bool flag)
        {
            enableOtherBtnControls(con, flag);
            btnCancel.Enabled = !flag;
            btnApply.Enabled = !flag;

            if (mod == 1)
            {

            }
            else if (mod == 0)
            {

            }

        }
        private void enableInputControls(Control con, bool flag)
        {
            enableTxtControls(this, flag);
            mtxtDate1.Enabled = flag;
            mtxtDate2.Enabled = flag;
            // txtSearchFirstName.Enabled = true;
            txtSearch.Enabled = true;
            //txtSearchClass.Enabled = true;
            cmbStatus.Enabled = flag;

        }
        private void enableTxtControls(Control con, bool flag)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Enabled = flag;
                else
                    enableTxtControls(c, flag);
            }
        }
        private void enableOtherBtnControls(Control con, bool flag)
        {
            foreach (Control c in con.Controls)
            {
                if (c is Button)
                    ((Button)c).Enabled = flag;
                else
                    enableOtherBtnControls(c, flag);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (mod == 1)
            {
                if (validateInputData())
                {
                    using (myDataClassesDataContext dtContext = new myDataClassesDataContext())
                    {

                        FilesTaxPayer fileDetails = dtContext.FilesTaxPayers.SingleOrDefault(x => x.id == Int32.Parse(txtID.Text));
                        fileDetails.NAME = txtFirstName.Text;
                        fileDetails.FNAME = txtLastName.Text;
                        fileDetails.FATHER = txtFatherName.Text;
                        fileDetails.HOZE = Int32.Parse(txtTaxUnit.Text);
                        fileDetails.NO_SABT = txtRegCode.Text;
                        fileDetails.ADDRESS = txtRegCode.Text;
                        fileDetails.CONAME = txtRegCode.Text;
                        fileDetails.SAL = txtFromYear.Text;
                        fileDetails.SAL2 = txtUntilYear.Text;
                        fileDetails.MABL = long.Parse(txtTaxAmount.Text);
                        fileDetails.DEGR1 = mtxtDate1.Text;
                        fileDetails.DEGR2 = mtxtDate2.Text;
                        fileDetails.KODVAZ = (short)cmbStatus.SelectedIndex;
                        fileDetails.NO_SHEN = txtRegCode.Text;
                        fileDetails.ARSAL = txtSender.Text;
                        dtContext.SubmitChanges();
                        showMessage("تغییرات ثبت شد");
                        enableInputControls(this, false);
                        radGridView1.Enabled = true;
                        changeStatusBtnControls(this, true);
                        RetrieveDetails();

                    }
                }
            }
            else if (mod == 2)
            {
                if (validateInputData())
                {

                    if (checkExistClass(txtClass.Text))
                    {
                        showMessage("شماره کلاسه تکراری است");

                    }
                    else
                    {
                        using (myDataClassesDataContext dtContext = new myDataClassesDataContext())
                        {
                            FilesTaxPayer fileDetails = new FilesTaxPayer
                            {
                                KLAS = txtClass.Text,
                                NAME = txtFirstName.Text,
                                FNAME = txtLastName.Text,
                                FATHER = txtFatherName.Text,
                                HOZE = Int32.Parse(txtTaxUnit.Text),
                                NO_SABT = txtRegCode.Text,
                                ADDRESS = txtRegCode.Text,
                                CONAME = txtRegCode.Text,
                                SAL = txtFromYear.Text,
                                SAL2 = txtUntilYear.Text,
                                MABL = long.Parse(txtTaxAmount.Text),
                                DEGR1 = mtxtDate1.Text,
                                DEGR2 = mtxtDate2.Text,
                                KODVAZ = (short)cmbStatus.SelectedIndex,
                                NO_SHEN = txtRegCode.Text,
                                ARSAL = txtSender.Text,
                            };
                            dtContext.FilesTaxPayers.InsertOnSubmit(fileDetails);
                            dtContext.SubmitChanges();
                            showMessage("تغییرات ثبت شد");
                            enableInputControls(this, false);
                            radGridView1.Enabled = true;
                            changeStatusBtnControls(this, true);
                            RetrieveDetails();
                        }//end of using

                    }
                }
            }//end of mod=2

            else
            {

            }
        }

        private bool validateInputData()
        {
            if (txtFirstName.Text == "")
            {
                //showMessage("نام را وارد کنید");     
                errorProvider1.SetError(txtFirstName, "*");
                return false;
            }
            errorProvider1.SetError(txtFirstName, "");
            if (txtLastName.Text == "")
            {
                errorProvider1.SetError(txtLastName, "*");
                return false;
            }
            errorProvider1.SetError(txtLastName, "");
            if (txtClass.Text == "")
            {
                errorProvider1.SetError(txtClass, "*");
                return false;
            }
            errorProvider1.SetError(txtClass, "");
            if (txtTaxUnit.Text == "")
            {
                errorProvider1.SetError(txtTaxUnit, "*");
                return false;
            }
            errorProvider1.SetError(txtTaxUnit, "");
            if (txtFromYear.Text == "")
            {
                errorProvider1.SetError(txtFromYear, "*");
                return false;
            }
            errorProvider1.SetError(txtFromYear, "");
            if (txtTaxAmount.Text == "")
            {
                errorProvider1.SetError(txtTaxAmount, "*");

                return false;
            }
            errorProvider1.SetError(txtTaxAmount, "");
            if (cmbStatus.SelectedIndex == -1)
                errorProvider1.SetError(cmbStatus, "*");
            errorProvider1.SetError(cmbStatus, "");
            return true;
        }
        private void showMessage(string str)
        {
            lblMessage.Show();
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = str;
            var t = new Timer();
            t.Interval = 5000; // it will Tick in 3 seconds
            t.Tick += (s, e2) =>
            {
                lblMessage.Hide();
                t.Stop();
            };
            t.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtClass.Text == "")
            {
                showMessage("کلاسه را جهت ویرایش وارد کنید");
            }

            else if (!checkExistClass(txtClass.Text))
            {
                showMessage("چنین کلاسه ای وجود ندارد");
            }
            else
            {

                mod = 1;//edit
                changeStatusBtnControls(this, false);
                enableInputControls(this, true);
                txtClass.Enabled = false;
                radGridView1.Enabled = false;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllInputControls(this);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mod = 2;//insert
            clearAllInputControls(this);
            changeStatusBtnControls(this, false);
            enableInputControls(this, true);
            // txtChequeNumber.Enabled = false;
            radGridView1.Enabled = false;
            //cmbStatus.SelectedIndex = 0;
        }

        private void txtTaxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtTaxUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtTaxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtAcountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtChequeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtFishNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtNationalCopCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.Width = 34;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.Width = 54;
            btnClear.BringToFront();

        }

        private void PicBsearch_Click(object sender, EventArgs e)
        {

            search();
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count >= 0)
            {
                DisplayDataInTopPanel(radGridView1.SelectedRows[0]);
            }
        }

        //private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        //{
        //    int row = e.RowIndex;
        //    int col = 8;
           
        //    if (this.radGridView1.Columns[e.ColumnIndex].Name == "KODVAZ")
        //    {
        //        switch (e.ColumnIndex)
        //        {
        //            case 0:
        //                radGridView1.Rows[row].Cells[e.ColumnIndex].Value = "Once";
        //                break;
        //            case 1:
        //                radGridView1.Rows[row].Cells[e.ColumnIndex].Value = "Mensually";
        //                break;
        //            case 5:
        //                radGridView1.Rows[row].Cells[e.ColumnIndex].Value = "Weekly";
        //                break;
                   
        //        }
        //    }
        //}
    }
}
