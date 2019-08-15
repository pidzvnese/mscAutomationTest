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
    public partial class frm_AddSite : Form
    {
        public frm_AddSite()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText(@"siteInfo.xml");
            string newSite = "<site>\n\t\t<name>" + txtTenBV.Text + "</name>\n\t\t<url>" + txtSiteUrl.Text + "</url>\n\t</site>\n\t{%newsite%}";
            text = text.Replace("{%newsite%}", newSite);
            try
            {
                File.WriteAllText("siteInfo.xml", text);
                MessageBox.Show("Thêm site thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm site không thành công", "Thông báo");
            }
        }

        private void frm_AddSite_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
