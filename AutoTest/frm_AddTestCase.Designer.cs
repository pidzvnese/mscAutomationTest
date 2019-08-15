namespace AutoTest
{
    partial class frm_AddTestCase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJavaFileName = new System.Windows.Forms.TextBox();
            this.txtClassFileName = new System.Windows.Forms.TextBox();
            this.txtXmlFileName = new System.Windows.Forms.TextBox();
            this.btnBrowserJava = new System.Windows.Forms.Button();
            this.btnBrowserClass = new System.Windows.Forms.Button();
            this.btnBrowserXml = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn file Java";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn file class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn file XML";
            // 
            // txtJavaFileName
            // 
            this.txtJavaFileName.Location = new System.Drawing.Point(122, 29);
            this.txtJavaFileName.Name = "txtJavaFileName";
            this.txtJavaFileName.Size = new System.Drawing.Size(295, 20);
            this.txtJavaFileName.TabIndex = 1;
            // 
            // txtClassFileName
            // 
            this.txtClassFileName.Location = new System.Drawing.Point(122, 69);
            this.txtClassFileName.Name = "txtClassFileName";
            this.txtClassFileName.Size = new System.Drawing.Size(295, 20);
            this.txtClassFileName.TabIndex = 1;
            // 
            // txtXmlFileName
            // 
            this.txtXmlFileName.Location = new System.Drawing.Point(122, 109);
            this.txtXmlFileName.Name = "txtXmlFileName";
            this.txtXmlFileName.Size = new System.Drawing.Size(295, 20);
            this.txtXmlFileName.TabIndex = 1;
            // 
            // btnBrowserJava
            // 
            this.btnBrowserJava.Location = new System.Drawing.Point(466, 27);
            this.btnBrowserJava.Name = "btnBrowserJava";
            this.btnBrowserJava.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserJava.TabIndex = 2;
            this.btnBrowserJava.Text = "Chọn file";
            this.btnBrowserJava.UseVisualStyleBackColor = true;
            this.btnBrowserJava.Click += new System.EventHandler(this.btnBrowserJava_Click);
            // 
            // btnBrowserClass
            // 
            this.btnBrowserClass.Location = new System.Drawing.Point(466, 69);
            this.btnBrowserClass.Name = "btnBrowserClass";
            this.btnBrowserClass.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserClass.TabIndex = 2;
            this.btnBrowserClass.Text = "Chọn file";
            this.btnBrowserClass.UseVisualStyleBackColor = true;
            this.btnBrowserClass.Click += new System.EventHandler(this.btnBrowserClass_Click);
            // 
            // btnBrowserXml
            // 
            this.btnBrowserXml.Location = new System.Drawing.Point(466, 106);
            this.btnBrowserXml.Name = "btnBrowserXml";
            this.btnBrowserXml.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserXml.TabIndex = 2;
            this.btnBrowserXml.Text = "Chọn file";
            this.btnBrowserXml.UseVisualStyleBackColor = true;
            this.btnBrowserXml.Click += new System.EventHandler(this.btnBrowserXml_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(179, 158);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(223, 43);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Thêm testcase";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // frm_AddTestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 224);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowserXml);
            this.Controls.Add(this.btnBrowserClass);
            this.Controls.Add(this.btnBrowserJava);
            this.Controls.Add(this.txtXmlFileName);
            this.Controls.Add(this.txtClassFileName);
            this.Controls.Add(this.txtJavaFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_AddTestCase";
            this.Text = "Mesoco - Thêm testcase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_AddTestCase_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJavaFileName;
        private System.Windows.Forms.TextBox txtClassFileName;
        private System.Windows.Forms.TextBox txtXmlFileName;
        private System.Windows.Forms.Button btnBrowserJava;
        private System.Windows.Forms.Button btnBrowserClass;
        private System.Windows.Forms.Button btnBrowserXml;
        private System.Windows.Forms.Button btnUpload;
    }
}