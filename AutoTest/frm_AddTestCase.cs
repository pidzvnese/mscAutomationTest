using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTest
{
    public partial class frm_AddTestCase : Form
    {
        public frm_AddTestCase()
        {
            InitializeComponent();
        }

        private void btnBrowserJava_Click(object sender, EventArgs e)
        {
            OpenFileDialog browserFile = new OpenFileDialog();
            browserFile.InitialDirectory = "C://Desktop";
            browserFile.Title = "Chọn file Java để upload.";
            browserFile.Filter = "Select Valid Document(*.java)|*.java";
            browserFile.FilterIndex = 1;
            try
            {
                if (browserFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (browserFile.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(browserFile.FileName);
                        txtJavaFileName.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBrowserClass_Click(object sender, EventArgs e)
        {
            OpenFileDialog browserFile = new OpenFileDialog();
            browserFile.InitialDirectory = "C://Desktop";
            browserFile.Title = "Chọn file Class để upload.";
            browserFile.Filter = "Select Valid Document(*.class)|*.class";
            browserFile.FilterIndex = 1;
            try
            {
                if (browserFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (browserFile.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(browserFile.FileName);
                        txtClassFileName.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowserXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog browserFile = new OpenFileDialog();
            browserFile.InitialDirectory = "C://Desktop";
            browserFile.Title = "Chọn file xml để upload.";
            browserFile.Filter = "Select Valid Document(*.xml)|*.xml";
            browserFile.FilterIndex = 1;
            try
            {
                if (browserFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (browserFile.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(browserFile.FileName);
                        txtXmlFileName.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String javaPath = @"src/demotest/";
            String classPath = @"bin/demotest/";
            String xmlPath = @"xml/";

            if (!Directory.Exists(classPath))
            {
                Directory.CreateDirectory(classPath);
            }

            if (!Directory.Exists(javaPath))
            {
                Directory.CreateDirectory(javaPath);
            }

            if (!Directory.Exists(xmlPath))
            {
                Directory.CreateDirectory(xmlPath);
            }
            bool matchFile = true;
            string javaFilename = System.IO.Path.GetFileName(txtJavaFileName.Text);
            string classFilename = System.IO.Path.GetFileName(txtClassFileName.Text);
            string xmlFilename = System.IO.Path.GetFileName(txtXmlFileName.Text);
            if (javaFilename == null)
            {
                MessageBox.Show("Please select a Java file.");
                matchFile = matchFile && false;
            } 
            
            if (classFilename == null)
            {
                MessageBox.Show("Please select a Class file.");
                matchFile = matchFile && false;
            }
  
            if (xmlFilename == null)
            {
                MessageBox.Show("Please select a xml file.");
                matchFile = matchFile && false;
            }

            if (matchFile == true)
            {
                try
                {
                    File.Copy(txtJavaFileName.Text, javaPath + javaFilename, true);
                    File.Copy(txtClassFileName.Text, classPath + classFilename, true);
                    File.Copy(txtXmlFileName.Text, xmlPath + xmlFilename, true);
                    MessageBox.Show("Upload testcase thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Upload testcase không thành công", "Thông báo");
                }
            }
        }

        private void frm_AddTestCase_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
