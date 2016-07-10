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
    public partial class UCCheque : UserControl
    {
        static int mod=0;
        
        public UCCheque()
        {
            InitializeComponent();
        }

        
        private void RetrieveDetails()
        {
            myDataClassesDataContext dtContext = new myDataClassesDataContext();
            var query = from m in dtContext.rejects
                        select new
                        {
                            classChequeNumber = m.PARVANDE,
                            firstname = m.NAME,
                            lastName = m.FAMIL,                           
                            father = m.FATHER,                           
                            NationalCode = m.NO_SHEN,
                            regCopCode = m.NO_SABT,
                            taxUnit = m.HOZE,
                            taxYear = m.SAL,
                            AccountNumber = m.HESAB_J,
                            chequeNumber = m.SH_CHEK,
                            taxMahal = m.MAHAL,
                            fishNumber = m.TARTIB_BAN,
                            taxType = m.NOW_M,
                            taxAmount = m.MABLAG,
                            branchBank = m.SHOBE2,
                            DateCheque = m.TARIK_2,
                            DateReject = m.DAT_REJECT,
                            DateActionDate = m.DATE_ACT,
                            DateVosol = m.TARIK_3,
                            address1 = m.ADDRESS_1,
                            comments = m.comments,
                            m.status,
                           comments2 = m.comments2,
                           id=m.ID,
                            //m.DATE_VOSOL,
                            //m.SHOBE,
                            //m.SAHEB,
                           
                        };

            radGridView1.DataSource = query.Take(10);

            AdjustDataGridView();

        }

        private void AdjustDataGridView()
        {
                        string[] headerColumnArray = new string[] {"کلاسه", "نام", "نام خانوادگی", "نام پدر", "شماره شناسنامه", "شناسه ملی", "حوزه", 
            "سال عملکرد","شماره حساب","شماره چک","محل","شماره فیش","نوع مالیات","مبلغ","شعبه","تاریخ چک","تاریخ برگشت","تاریخ ابلاغ","تاریخ وصول", "آدرس","توضیحات","وضعیت"};
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
           

            for (int i = 0; i < headerColumnArray.Length; i++)
            {
                this.radGridView1.Columns[i].HeaderText=headerColumnArray[i];
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
                DisplayDataInTopPanel(e.Row);

                
            }
        }

        private void DisplayDataInTopPanel(GridViewRowInfo row)
        {
            txtID.Text = row.Cells["id"].Value.ToString();

            if (row.Cells["firstName"].Value == null)
                txtFirstName.Text = "";
            else
                txtFirstName.Text = row.Cells["firstName"].Value.ToString();

            if (row.Cells["LastName"].Value == null)
                txtLastName.Text = "";
            else
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
            if (row.Cells["father"].Value == null)
                txtFatherName.Text = "";
            else
                txtFatherName.Text = row.Cells["father"].Value.ToString();
            if (row.Cells["fishNumber"].Value == null)
                txtFishNumber.Text = "";
            else
                txtFishNumber.Text = row.Cells["fishNumber"].Value.ToString();
            if (row.Cells["regCopCode"].Value == null)
                txtNationalCopCode.Text = "";
            else
                txtNationalCopCode.Text = row.Cells["regCopCode"].Value.ToString();

            if (row.Cells["taxYear"].Value == null)
                txtTaxYear.Text = "";
            else
                txtTaxYear.Text = row.Cells["taxYear"].Value.ToString();
            if (row.Cells["AccountNumber"].Value == null)
                txtAcountNumber.Text = "";
            else
                txtAcountNumber.Text = row.Cells["AccountNumber"].Value.ToString();
            if (row.Cells["taxType"].Value == null)
                cmbTaxType.Text = "";
            else
                cmbTaxType.SelectedIndex = Int32.Parse(row.Cells["taxType"].Value.ToString()) - 11;

            if (row.Cells["branchBank"].Value == null)
                txtBranchOfBank.Text = "";
            else
                txtBranchOfBank.Text = row.Cells["branchBank"].Value.ToString();

            if (row.Cells["taxUnit"].Value == null)
                txtTaxUnit.Text = "";
            else
                txtTaxUnit.Text = row.Cells["taxUnit"].Value.ToString();

            if (row.Cells["address1"].Value == null)
                txtAddress.Text = "";
            else
                txtAddress.Text = row.Cells["address1"].Value.ToString();

            if (row.Cells["classChequeNumber"].Value == null)
                txtClass.Text = "";
            else
                txtClass.Text = row.Cells["classChequeNumber"].Value.ToString();
            if (row.Cells["status"].Value == null)
                cmbChequeStatus.SelectedIndex = -1;
            else
                cmbChequeStatus.SelectedIndex = Int32.Parse(row.Cells["status"].Value.ToString());
            if (row.Cells["taxmahal"].Value == null)
                cmbBank.SelectedIndex = -1;
            else
                cmbBank.SelectedIndex = Int32.Parse(row.Cells["taxmahal"].Value.ToString());
            if (row.Cells["taxAmount"].Value == null)
                txtTaxAmount.Text = "";
            else
                txtTaxAmount.Text = row.Cells["taxAmount"].Value.ToString();
            if (row.Cells["AccountNumber"].Value == null)
                txtAcountNumber.Text = "";
            else
                txtAcountNumber.Text = row.Cells["AccountNumber"].Value.ToString();
            if (row.Cells["chequeNumber"].Value == null)
                txtChequeNumber.Text = "";
            else
                txtChequeNumber.Text = row.Cells["chequeNumber"].Value.ToString();
            if (row.Cells["comments"].Value == null)
                txtComments.Text = "";
            else
                txtComments.Text = row.Cells["comments"].Value.ToString();
            if (row.Cells["comments2"].Value == null)
                txtComments2.Text = "";
            else
                txtComments2.Text = row.Cells["comments2"].Value.ToString();


            if (row.Cells["DateActionDate"].Value == null)
                mtxtDateAction.Text = "";
            else
                mtxtDateAction.Text = row.Cells["DateActionDate"].Value.ToString();

            if (row.Cells["DateCheque"].Value == null)
                mtxtCheque.Text = "";
            else
                mtxtCheque.Text = row.Cells["DateCheque"].Value.ToString();

            if (row.Cells["DateVosol"].Value == null)
                mtxtAccept.Text = "";
            else
                mtxtAccept.Text = row.Cells["DateVosol"].Value.ToString();

            if (row.Cells["DateReject"].Value == null)
                mtxtRejectDate.Text = "";
            else
                mtxtRejectDate.Text = row.Cells["DateReject"].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //string[] keyWords = txtSearch.Text.Split('%');
            // keyWords[0].Replace('ی', 'ي').Replace('ک', 'ك');
            search();

        }

        private void search()
        {
            myDataClassesDataContext dtContext = new myDataClassesDataContext();
            var query = from m in dtContext.rejects
                        // where m.NAME.Contains(keyWords[0]) //|| m.FAMIL.Contains(keyWords[1]) || m.PARVANDE.Value.ToString().Contains(keyWords[2])
                        select new
                        {
                           
                            classChequeNumber = m.PARVANDE,
                            firstname = m.NAME,
                            lastName = m.FAMIL,
                            father = m.FATHER,
                            NationalCode = m.NO_SHEN,
                            regCopCode = m.NO_SABT,
                            taxUnit = m.HOZE,
                            taxYear = m.SAL,
                            AccountNumber = m.HESAB_J,
                            chequeNumber = m.SH_CHEK,
                            taxMahal = m.MAHAL,
                            fishNumber = m.TARTIB_BAN,
                            taxType = m.NOW_M,
                            taxAmount = m.MABLAG,
                            branchBank = m.SHOBE2,
                            DateCheque = m.TARIK_2,
                            DateReject = m.DAT_REJECT,
                            DateActionDate = m.DATE_ACT,
                            DateVosol = m.TARIK_3,
                            address1 = m.ADDRESS_1,
                            comments = m.comments,
                            m.status,
                            comments2 = m.comments2,
                            id = m.ID,
                            //m.DATE_VOSOL,
                            //m.SHOBE,
                            //m.SAHEB,
                        };

            if (rdbFirestName.Checked) query = query.Where(m => m.firstname.Contains(txtSearch.Text));
            else if (rdbLastName.Checked) query = query.Where(m => m.lastName.Contains(txtSearch.Text));
            else if (rdbClass.Checked) query = query.Where(m => m.chequeNumber.Contains(txtSearch.Text));
            radGridView1.DataSource = query;

            AdjustDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
            if (txtChequeNumber.Text == "")
            {
                showMessage("لطفا برای حذف ، شماره چکی معتبر انتخاب کنید");
            }

            else
            {
                if (!checkExistChequeNumber(txtChequeNumber.Text))
                {
                    showMessage("چنین شماره چکی وجود ندارد");                    
                }

                else
                {
                    string btnClicked = FrmMessage.ShowBox("آیا از حذف چک " + txtChequeNumber.Text.Trim() + " مطمئن هستید؟ ");

                    if (btnClicked == "1")
                    {
                        using (myDataClassesDataContext dtContext = new myDataClassesDataContext())
                        {
                            reject Udetails = dtContext.rejects.SingleOrDefault(x => x.ID == Int32.Parse( txtID.Text));
                            dtContext.rejects.DeleteOnSubmit(Udetails);
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
        private bool checkExistChequeNumber(string str)
        {
            myDataClassesDataContext db1 = new myDataClassesDataContext();
            var query = (from m in db1.rejects
                         where m.SH_CHEK == str
                         select m).Count();
            if (query.ToString() == "0")
                return false;
            return true;

        }
        private void clearAllInputControls(Control con)
        {
            clearAllTextBox(this);
            mtxtAccept.ResetText();
            mtxtCheque.ResetText();
            mtxtDateAction.ResetText();
            mtxtRejectDate.ResetText();
            cmbChequeStatus.SelectedIndex = -1;
            cmbTaxType.SelectedIndex = -1;
            cmbBank.SelectedIndex = -1;
            
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
            mtxtAccept.Enabled = flag;
            mtxtCheque.Enabled = flag;
            mtxtDateAction.Enabled = flag;
            mtxtRejectDate.Enabled = flag;
            // txtSearchFirstName.Enabled = true;
            txtSearch.Enabled = true;
            //txtSearchClass.Enabled = true;
            cmbChequeStatus.Enabled = flag;
            cmbBank.Enabled = flag;
            cmbTaxType.Enabled = flag;

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
                if( isEnteredNessaryData())
               {
                   using (myDataClassesDataContext dtContext = new myDataClassesDataContext())
                   {
                       reject chequeDetails = dtContext.rejects.SingleOrDefault(x => x.ID ==Int32.Parse(txtID.Text));
                       //chequeDetails.SH_CHEK = txtChequeNumber.Text;
                       //فعلا شماره چک را قابل ویرایش نگداشتم
                       chequeDetails.NAME = txtFirstName.Text;
                       chequeDetails.FAMIL = txtLastName.Text;
                       chequeDetails.FATHER = txtFatherName.Text;
                       chequeDetails.HOZE = Int32.Parse(txtTaxYear.Text);
                       chequeDetails.HESAB_J = txtAcountNumber.Text;
                       chequeDetails.NOW_M = (short)(cmbTaxType.SelectedIndex+11);
                       chequeDetails.ADDRESS_1 = txtAddress.Text;
                       chequeDetails.NO_SABT = txtNationalCopCode.Text;
                       chequeDetails.MAHAL = (short)(cmbBank.SelectedIndex );
                       chequeDetails.SAL = Int32.Parse(txtTaxUnit.Text);
                       chequeDetails.comments = txtComments.Text;
                       chequeDetails.comments2 = txtComments2.Text;
                       chequeDetails.DAT_REJECT = mtxtRejectDate.MaskCompleted ? mtxtRejectDate.Text : "0000-00-00";
                       chequeDetails.TARIK_3 = mtxtAccept.MaskCompleted ? mtxtAccept.Text : "0000-00-00";
                       chequeDetails.DATE_ACT = mtxtDateAction.MaskCompleted ? mtxtDateAction.Text : "0000-00-00";
                       chequeDetails.TARIK_2 = mtxtCheque.MaskCompleted ? mtxtCheque.Text : "0000-00-00";
                       chequeDetails.NO_SHEN = txtNationalCode.Text;
                       chequeDetails.MABLAG = Int32.Parse(txtTaxAmount.Text);
                       chequeDetails.status = (short)cmbChequeStatus.SelectedIndex;

                       dtContext.SubmitChanges();
                       showMessage("تغییرات ثبت شد");
                       
                       enableInputControls(this, false);
                       radGridView1.Enabled = true;
                       changeStatusBtnControls(this, true);
                       RetrieveDetails();
                       mod = 0;
                   }
                }
            }
            else if (mod == 2)
            {
               if( isEnteredNessaryData())
               {

                   if (checkExistChequeNumber(txtChequeNumber.Text))
                   {
                       showMessage("شماره چک تکراری است");
                      
                   }
                   else
                   {
                       using (myDataClassesDataContext dtContext = new myDataClassesDataContext())
                       {
                           reject chequeDetails = new reject
                           {
                               SH_CHEK = txtChequeNumber.Text,
                               NAME = txtFirstName.Text,
                               FAMIL = txtLastName.Text,
                               FATHER = txtFatherName.Text,
                               HOZE = Int32.Parse(txtTaxYear.Text),
                               MAHAL = (short)cmbBank.SelectedIndex,
                               HESAB_J = txtAcountNumber.Text,
                               NOW_M = (short)( cmbChequeStatus.SelectedIndex+11),
                               ADDRESS_1 = txtAddress.Text,
                               NO_SABT = txtNationalCopCode.Text,
                               SAL = Int32.Parse(txtTaxUnit.Text),
                               comments = txtComments.Text,
                               comments2 = txtComments2.Text,
                               DAT_REJECT = mtxtRejectDate.MaskCompleted ? mtxtRejectDate.Text : null,
                               TARIK_3 = mtxtAccept.MaskCompleted ? mtxtAccept.Text : null,
                               DATE_ACT = mtxtDateAction.MaskCompleted ? mtxtDateAction.Text : null,
                               TARIK_2 = mtxtCheque.MaskCompleted ? mtxtCheque.Text : null,
                               NO_SHEN = txtNationalCode.Text,
                               MABLAG = Int32.Parse(txtTaxAmount.Text),
                               status = (short) cmbChequeStatus.SelectedIndex
                           };
                           dtContext.rejects.InsertOnSubmit(chequeDetails);
                           dtContext.SubmitChanges();
                           showMessage("تغییرات ثبت شد");
                           
                           enableInputControls(this, false);
                           radGridView1.Enabled = true;
                           changeStatusBtnControls(this, true);
                           RetrieveDetails();
                           mod = 0;
                       }//end of using

                   }
            }
            }//end of mod=2
            
            else
            {

            }
        }

        private bool isEnteredNessaryData()
        {
            
                if(txtFirstName.Text =="")
                {
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
                if (txtTaxYear.Text == "")
                {
                    errorProvider1.SetError(txtTaxYear, "*");
                    return false;
                }
                errorProvider1.SetError(txtTaxYear, "");
                if (txtTaxAmount.Text == "")
                {
                    errorProvider1.SetError(txtTaxAmount, "*");
                    return false;
                }
                errorProvider1.SetError(txtTaxAmount, "");

                if (cmbChequeStatus.Text == "")
                {
                    errorProvider1.SetError(cmbChequeStatus, "*");
                    return false;
                }
                errorProvider1.SetError(cmbChequeStatus, "");
                if (cmbTaxType.Text == "")
                {
                    errorProvider1.SetError(cmbTaxType, "*");
                    return false;
                }
                errorProvider1.SetError(cmbTaxType, "");

                if (txtChequeNumber.Text == "")
                {
                    errorProvider1.SetError(txtChequeNumber, "*");
                    return false;
                }
                errorProvider1.SetError(txtChequeNumber, "");
                return true;
              }
        private bool isEnteredNessaryData2()
        {

            if (txtFirstName.Text == "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = "نام را وارد کنید";
                return false;
            }
            if (txtLastName.Text == "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = "نام خانوادگی را وارد کنید";
                return false;
            }
            if (txtChequeNumber.Text == "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = "شماره چک را وارد کنید";
                return false;
            }
            if (txtTaxAmount.Text == "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = "مبلغ را وارد کنید";
                return false;
            }
            else if (txtTaxUnit.Text == "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = "سال را  وارد کنید";
                return false;
            }
            else if (txtTaxYear.Text == "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = "حوزه مالیاتی را  وارد کنید";
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtChequeNumber.Text == "")
            {
                showMessage("کلاسه را جهت ویرایش وارد کنید");
             
            }

            else if (!checkExistChequeNumber(txtChequeNumber.Text))
            {
                 showMessage("چنین شماره چکی وجود ندارد");
                
            }
            else
            {

                mod = 1;//edit
                changeStatusBtnControls(this, false);
                enableInputControls(this, true);
                txtChequeNumber.Enabled = false;
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if ((txtSearch.Text == "جستجو بر اساس نام") || (txtSearch.Text == "جستجو بر اساس کلاسه") ||
                txtSearch.Text == "جستجو بر اساس نام خانوادگی" || txtSearch.Text == "فیلتر جستجو را مشخص کنید")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0 || (txtSearch.Text == "جستجو بر اساس نام") || (txtSearch.Text == "جستجو بر اساس کلاسه") ||
                txtSearch.Text == "جستجو بر اساس نام خانوادگی" || txtSearch.Text == "فیلتر جستجو را مشخص کنید")
            {
                txtSearch.ForeColor = SystemColors.GrayText;
                if (rdbClass.Checked)
                    txtSearch.Text = "جستجو بر اساس کلاسه";
                else if (rdbFirestName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام";
                else if (rdbLastName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام خانوادگی";
                else
                    txtSearch.Text = "فیلتر جستجو را مشخص کنید";
            }
        }

        private void rdbLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0 || (txtSearch.Text == "جستجو بر اساس نام") || (txtSearch.Text == "جستجو بر اساس کلاسه") ||
                txtSearch.Text == "جستجو بر اساس نام خانوادگی" || txtSearch.Text == "فیلتر جستجو را مشخص کنید")
            {
                txtSearch.ForeColor = SystemColors.GrayText;
                if (rdbClass.Checked)
                    txtSearch.Text = "جستجو بر اساس کلاسه";
                else if (rdbFirestName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام";
                else if (rdbLastName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام خانوادگی";
                else
                    txtSearch.Text = "فیلتر جستجو را مشخص کنید";
            }
        }

        private void rdbFirestName_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0 || (txtSearch.Text == "جستجو بر اساس نام") || (txtSearch.Text == "جستجو بر اساس کلاسه") ||
                txtSearch.Text == "جستجو بر اساس نام خانوادگی" || txtSearch.Text == "فیلتر جستجو را مشخص کنید")
            {
                txtSearch.ForeColor = SystemColors.GrayText;
                if (rdbClass.Checked)
                    txtSearch.Text = "جستجو بر اساس کلاسه";
                else if (rdbFirestName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام";
                else if (rdbLastName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام خانوادگی";
                else
                    txtSearch.Text = "فیلتر جستجو را مشخص کنید";
            }
        }

        private void rdbClass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0 || (txtSearch.Text == "جستجو بر اساس نام") || (txtSearch.Text == "جستجو بر اساس کلاسه") ||
                txtSearch.Text == "جستجو بر اساس نام خانوادگی" || txtSearch.Text == "فیلتر جستجو را مشخص کنید")
            {
                txtSearch.ForeColor = SystemColors.GrayText;
                if (rdbClass.Checked)
                    txtSearch.Text = "جستجو بر اساس کلاسه";
                else if (rdbFirestName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام";
                else if (rdbLastName.Checked)
                    txtSearch.Text = "جستجو بر اساس نام خانوادگی";
                else
                    txtSearch.Text = "فیلتر جستجو را مشخص کنید";
            }
        }

        private void PicBsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {           
            if (radGridView1.SelectedRows.Count >= 0)
            {
                DisplayDataInTopPanel(radGridView1.SelectedRows[0]);
            }
        
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.F2)
            {
                this.btnDelete.PerformClick();
                return true;
             }
            else if(keyData ==Keys.F10)
            {
                this.btnNew.PerformClick();
                return true;
            }
            else if (keyData == Keys.F1)
            {
                this.btnEdit.PerformClick();
                return true;
            }
            else if (keyData == Keys.F8 && (mod==1 || mod==2))
            {
                this.btnApply.PerformClick();
                return true;
            }
            else if (keyData == Keys.Escape && (mod==1 || mod==2))
            {
                this.btnCancel.PerformClick();
                return true;
            }
         return base.ProcessCmdKey(ref msg, keyData);            
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

     
    }
    class ErrorTracker
    {
        private HashSet<Control> mErrors = new HashSet<Control>();
        private ErrorProvider mProvider;

        public ErrorTracker(ErrorProvider provider)
        {
            mProvider = provider;
        }
        public void SetError(Control ctl, string text)
        {
            if (string.IsNullOrEmpty(text)) mErrors.Remove(ctl);
            else if (!mErrors.Contains(ctl)) mErrors.Add(ctl);
            mProvider.SetError(ctl, text);
        }


    }
}
