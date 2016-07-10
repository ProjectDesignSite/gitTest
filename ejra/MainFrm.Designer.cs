namespace ejra
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ucTaxFiles1 = new ejra.UCTaxFiles();
            this.userControl11 = new ejra.UCCheque();
            this.btnTaxFiles = new System.Windows.Forms.Button();
            this.btnChequeFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            // 
            // ucTaxFiles1
            // 
            this.ucTaxFiles1.BackColor = System.Drawing.Color.Transparent;
            this.ucTaxFiles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaxFiles1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucTaxFiles1.ForeColor = System.Drawing.Color.Black;
            this.ucTaxFiles1.Location = new System.Drawing.Point(0, 0);
            this.ucTaxFiles1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.ucTaxFiles1.Name = "ucTaxFiles1";
            this.ucTaxFiles1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucTaxFiles1.Size = new System.Drawing.Size(1022, 631);
            this.ucTaxFiles1.TabIndex = 5;
            this.ucTaxFiles1.Load += new System.EventHandler(this.ucTaxFiles1_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userControl11.ForeColor = System.Drawing.Color.Black;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userControl11.Size = new System.Drawing.Size(1022, 631);
            this.userControl11.TabIndex = 4;
            // 
            // btnTaxFiles
            // 
            this.btnTaxFiles.BackColor = System.Drawing.Color.White;
            this.btnTaxFiles.FlatAppearance.BorderSize = 0;
            this.btnTaxFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTaxFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTaxFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxFiles.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTaxFiles.ForeColor = System.Drawing.Color.Black;
            this.btnTaxFiles.Image = global::ejra.Properties.Resources._840188_thm;
            this.btnTaxFiles.Location = new System.Drawing.Point(153, 13);
            this.btnTaxFiles.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnTaxFiles.Name = "btnTaxFiles";
            this.btnTaxFiles.Size = new System.Drawing.Size(52, 59);
            this.btnTaxFiles.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnTaxFiles, "پرونده های مودیان");
            this.btnTaxFiles.UseVisualStyleBackColor = false;
            this.btnTaxFiles.Click += new System.EventHandler(this.btnTaxFiles_Click);
            this.btnTaxFiles.MouseLeave += new System.EventHandler(this.btnTaxFiles_MouseLeave);
            this.btnTaxFiles.MouseHover += new System.EventHandler(this.btnTaxFiles_MouseHover);
            // 
            // btnChequeFrm
            // 
            this.btnChequeFrm.BackColor = System.Drawing.Color.White;
            this.btnChequeFrm.FlatAppearance.BorderSize = 0;
            this.btnChequeFrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChequeFrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChequeFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChequeFrm.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChequeFrm.ForeColor = System.Drawing.Color.Black;
            this.btnChequeFrm.Image = global::ejra.Properties.Resources.images;
            this.btnChequeFrm.Location = new System.Drawing.Point(11, 13);
            this.btnChequeFrm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnChequeFrm.Name = "btnChequeFrm";
            this.btnChequeFrm.Size = new System.Drawing.Size(52, 59);
            this.btnChequeFrm.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnChequeFrm, "چک ها");
            this.btnChequeFrm.UseVisualStyleBackColor = false;
            this.btnChequeFrm.Click += new System.EventHandler(this.btnChequeFrm_Click);
            this.btnChequeFrm.MouseLeave += new System.EventHandler(this.btnChequeFrm_MouseLeave);
            this.btnChequeFrm.MouseHover += new System.EventHandler(this.btnChequeFrm_MouseHover);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClientSize = new System.Drawing.Size(1022, 631);
            this.Controls.Add(this.btnTaxFiles);
            this.Controls.Add(this.btnChequeFrm);
            this.Controls.Add(this.ucTaxFiles1);
            this.Controls.Add(this.userControl11);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "MainFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "نوا<font color=\"#6F3198\"></font><b></b>";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChequeFrm;
        private System.Windows.Forms.Button btnTaxFiles;
        private UCCheque userControl11;
        private UCTaxFiles ucTaxFiles1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}