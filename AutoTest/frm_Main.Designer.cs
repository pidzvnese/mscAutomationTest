namespace AutoTest
{
    partial class frmMain
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
            this.lstTestCase = new System.Windows.Forms.ListBox();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.txtMaBn = new System.Windows.Forms.TextBox();
            this.txtMaBnMoi = new System.Windows.Forms.TextBox();
            this.txtTenMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaBnDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clSiteUrl = new System.Windows.Forms.CheckedListBox();
            this.cbRunSequence = new System.Windows.Forms.CheckBox();
            this.cbRunAll = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grLogin = new System.Windows.Forms.GroupBox();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusCountSite = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTotalSite = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSiteRunning = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.btnAddTestCase = new System.Windows.Forms.Button();
            this.grLogin.SuspendLayout();
            this.grInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTestCase
            // 
            this.lstTestCase.FormattingEnabled = true;
            this.lstTestCase.Location = new System.Drawing.Point(30, 46);
            this.lstTestCase.Name = "lstTestCase";
            this.lstTestCase.Size = new System.Drawing.Size(244, 199);
            this.lstTestCase.TabIndex = 0;
            this.lstTestCase.SelectedIndexChanged += new System.EventHandler(this.lstTestCase_SelectedIndexChanged);
            // 
            // btnRunTest
            // 
            this.btnRunTest.Enabled = false;
            this.btnRunTest.Location = new System.Drawing.Point(545, 296);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(149, 64);
            this.btnRunTest.TabIndex = 1;
            this.btnRunTest.Text = "Run";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // txtMaBn
            // 
            this.txtMaBn.Location = new System.Drawing.Point(133, 14);
            this.txtMaBn.Name = "txtMaBn";
            this.txtMaBn.Size = new System.Drawing.Size(271, 20);
            this.txtMaBn.TabIndex = 3;
            // 
            // txtMaBnMoi
            // 
            this.txtMaBnMoi.Location = new System.Drawing.Point(133, 40);
            this.txtMaBnMoi.Name = "txtMaBnMoi";
            this.txtMaBnMoi.Size = new System.Drawing.Size(271, 20);
            this.txtMaBnMoi.TabIndex = 4;
            // 
            // txtTenMoi
            // 
            this.txtTenMoi.Location = new System.Drawing.Point(133, 67);
            this.txtTenMoi.Name = "txtTenMoi";
            this.txtTenMoi.Size = new System.Drawing.Size(271, 20);
            this.txtTenMoi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã BN mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên BN mới";
            // 
            // txtMaBnDoc
            // 
            this.txtMaBnDoc.Location = new System.Drawing.Point(133, 95);
            this.txtMaBnDoc.Name = "txtMaBnDoc";
            this.txtMaBnDoc.Size = new System.Drawing.Size(271, 20);
            this.txtMaBnDoc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên BN đã đọc";
            // 
            // clSiteUrl
            // 
            this.clSiteUrl.FormattingEnabled = true;
            this.clSiteUrl.Location = new System.Drawing.Point(30, 296);
            this.clSiteUrl.Margin = new System.Windows.Forms.Padding(10);
            this.clSiteUrl.Name = "clSiteUrl";
            this.clSiteUrl.Size = new System.Drawing.Size(244, 169);
            this.clSiteUrl.TabIndex = 8;
            // 
            // cbRunSequence
            // 
            this.cbRunSequence.AutoSize = true;
            this.cbRunSequence.Enabled = false;
            this.cbRunSequence.Location = new System.Drawing.Point(299, 321);
            this.cbRunSequence.Name = "cbRunSequence";
            this.cbRunSequence.Size = new System.Drawing.Size(87, 17);
            this.cbRunSequence.TabIndex = 9;
            this.cbRunSequence.Text = "Chạy lần lượt";
            this.cbRunSequence.UseVisualStyleBackColor = true;
            // 
            // cbRunAll
            // 
            this.cbRunAll.AutoSize = true;
            this.cbRunAll.Enabled = false;
            this.cbRunAll.Location = new System.Drawing.Point(414, 321);
            this.cbRunAll.Name = "cbRunAll";
            this.cbRunAll.Size = new System.Drawing.Size(89, 17);
            this.cbRunAll.TabIndex = 9;
            this.cbRunAll.Text = "Chạy toàn bộ";
            this.cbRunAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(134, 18);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(271, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // grLogin
            // 
            this.grLogin.Controls.Add(this.label6);
            this.grLogin.Controls.Add(this.label8);
            this.grLogin.Controls.Add(this.txtUsername);
            this.grLogin.Controls.Add(this.txtPassword);
            this.grLogin.Location = new System.Drawing.Point(289, 17);
            this.grLogin.Name = "grLogin";
            this.grLogin.Size = new System.Drawing.Size(424, 72);
            this.grLogin.TabIndex = 14;
            this.grLogin.TabStop = false;
            // 
            // grInfo
            // 
            this.grInfo.Controls.Add(this.label2);
            this.grInfo.Controls.Add(this.txtMaBn);
            this.grInfo.Controls.Add(this.txtMaBnMoi);
            this.grInfo.Controls.Add(this.txtTenMoi);
            this.grInfo.Controls.Add(this.txtMaBnDoc);
            this.grInfo.Controls.Add(this.label3);
            this.grInfo.Controls.Add(this.label4);
            this.grInfo.Controls.Add(this.label5);
            this.grInfo.Location = new System.Drawing.Point(289, 102);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(424, 127);
            this.grInfo.TabIndex = 15;
            this.grInfo.TabStop = false;
            this.grInfo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách Testcase";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Danh sách site";
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(191, 272);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(81, 17);
            this.cbSelectAll.TabIndex = 22;
            this.cbSelectAll.Text = "Chọn tất cả";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusCountSite,
            this.statusTotalSite,
            this.toolStripStatusLabel2,
            this.statusSiteRunning});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // statusCountSite
            // 
            this.statusCountSite.Name = "statusCountSite";
            this.statusCountSite.Size = new System.Drawing.Size(0, 17);
            // 
            // statusTotalSite
            // 
            this.statusTotalSite.Name = "statusTotalSite";
            this.statusTotalSite.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Tiến trình: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel2.Text = "Site đang chạy";
            // 
            // statusSiteRunning
            // 
            this.statusSiteRunning.Name = "statusSiteRunning";
            this.statusSiteRunning.Size = new System.Drawing.Size(0, 17);
            this.statusSiteRunning.Click += new System.EventHandler(this.statusSiteRunning_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Location = new System.Drawing.Point(299, 430);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(87, 23);
            this.btnAddSite.TabIndex = 24;
            this.btnAddSite.Text = "Thêm Site";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // btnAddTestCase
            // 
            this.btnAddTestCase.Location = new System.Drawing.Point(414, 430);
            this.btnAddTestCase.Name = "btnAddTestCase";
            this.btnAddTestCase.Size = new System.Drawing.Size(89, 23);
            this.btnAddTestCase.TabIndex = 24;
            this.btnAddTestCase.Text = "Thêm Testcase";
            this.btnAddTestCase.UseVisualStyleBackColor = true;
            this.btnAddTestCase.Click += new System.EventHandler(this.btnAddTestCase_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 491);
            this.Controls.Add(this.btnAddTestCase);
            this.Controls.Add(this.btnAddSite);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grInfo);
            this.Controls.Add(this.grLogin);
            this.Controls.Add(this.cbRunAll);
            this.Controls.Add(this.cbRunSequence);
            this.Controls.Add(this.clSiteUrl);
            this.Controls.Add(this.btnRunTest);
            this.Controls.Add(this.lstTestCase);
            this.Name = "frmMain";
            this.Text = "Mesoco - Automation Test 1.1";
            this.Load += new System.EventHandler(this.frmName_Load);
            this.grLogin.ResumeLayout(false);
            this.grLogin.PerformLayout();
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTestCase;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.TextBox txtMaBn;
        private System.Windows.Forms.TextBox txtMaBnMoi;
        private System.Windows.Forms.TextBox txtTenMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaBnDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clSiteUrl;
        private System.Windows.Forms.CheckBox cbRunSequence;
        private System.Windows.Forms.CheckBox cbRunAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grLogin;
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusCountSite;
        private System.Windows.Forms.ToolStripStatusLabel statusTotalSite;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusSiteRunning;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Button btnAddTestCase;
    }
}

