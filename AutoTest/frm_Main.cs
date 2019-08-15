using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoTest
{
    public partial class frmMain : Form
    {
        private Dictionary<string, string> listSite = new Dictionary<string, string>();
        public frmMain()
        {
            InitializeComponent();
            loadTestCase();

            lstTestCase.SelectionMode = SelectionMode.MultiSimple;

            loadLstSiteTestCase();
        }

        void loadTestCase()
        {
            
            DirectoryInfo d = new DirectoryInfo(@"xml");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
            lstTestCase.Items.Clear();
            foreach (FileInfo file in Files)
            {
                lstTestCase.Items.Add(file.Name);
            }
            lstTestCase.Refresh();
        }

        void loadLstSiteTestCase()
        {
            listSite = readListSite();
            clSiteUrl.DisplayMember = "Text";
            clSiteUrl.ValueMember = "Value";
            clSiteUrl.Items.Clear();
            for (int i = 0; i < listSite.Count; i++)
            {
                clSiteUrl.Items.Insert(i, new ListBoxItem { Text = listSite.Keys.ElementAt(i), Value = listSite.Keys.ElementAt(i) });
            }
            clSiteUrl.Refresh();
        }

        public class ListBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
        }

        public class SiteInfo
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Result {
            string testCaseName;
            string resultTest;
            string resultUrl;
            string rsPath;

            public string TestCaseName
            {
                get { return testCaseName; }
                set { testCaseName = value; }
            }

            public string ResultTest
            {
                get { return resultTest; }
                set { resultTest = value; }
            }

            public string ResultUrl
            {
                get { return resultUrl; }
                set { resultUrl = value; }
            }

            public string RsPath
            {
                get { return rsPath; }
                set { rsPath = value; }
            }

        }

        private void lstTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listboxSel = new List<string>();
            foreach (int i in lstTestCase.SelectedIndices)
            {
                listboxSel.Add(lstTestCase.Items[i].ToString());
            }

            if ((!listboxSel.Contains("1_login_testcase.xml") && listboxSel.Count > 0))
            {
                grInfo.Visible = true;
                btnRunTest.Enabled = true;
                listboxSel = null;
            }
            else if ((listboxSel.Contains("1_login_testcase.xml") && listboxSel.Count > 1))
            {
                grInfo.Visible = true;
                btnRunTest.Enabled = true;
                listboxSel = null;
            }
            else if (listboxSel.Contains("1_login_testcase.xml") && listboxSel.Count == 1)
            {
                grInfo.Visible = false;
                btnRunTest.Enabled = true;
                listboxSel = null;
            }
            else
            {
                grInfo.Visible = false;
                btnRunTest.Enabled = false;
            }
            listboxSel = null;
        }

        private void frmName_Load(object sender, EventArgs e)
        {

        }
        List<string> lstSelTestCase = new List<string>();
        List<string> lstSelSite = new List<string>();
        public string tmpFolder = "";
        private void btnRunTest_Click(object sender, EventArgs e)
        {
            
            DateTime today = DateTime.Now;
            tmpFolder = @"temp\" + today.ToShortDateString().Replace(@"/", "");
            if (!Directory.Exists(tmpFolder))
            {
                System.IO.Directory.CreateDirectory(tmpFolder);
            }
            foreach (int i in lstTestCase.SelectedIndices)
            {
                lstSelTestCase.Add(lstTestCase.Items[i].ToString());
            }

            foreach (ListBoxItem k in clSiteUrl.CheckedItems)
            {
                lstSelSite.Add(k.Value);
            }
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private bool enterSiteName(string tempPath,string xmlName, string url, string maBn, string newName, string tenBn, string maBnMoi, string userName, string password, out string batchPath, out string batName, out string tmpNumberF, out string logPath)
        {
            bool checkEnterSite = false;
            string text = File.ReadAllText(@"xml\" + xmlName);
            text = text.Replace("%url%", url).Replace("%maBn%", maBn).Replace("%newName%", newName).Replace("%tenBn%", tenBn).Replace("%maBnMoi%", maBnMoi).Replace("%userName%", userName).Replace("%password%", password);
            string siteName = url.Replace(".", "").Replace(":", "").Replace("/", "").Replace("http","");
            string newFileName = xmlName.Replace("_","").Replace(".","").Replace("xml","") + "-" + siteName;

            string tmpFolder = tempPath + @"\" + newFileName;
            string tmpName = "";
            string tmpNumber = "";
            if (!File.Exists(tmpFolder + @"\" + newFileName + ".xml"))
            {
                tmpName = newFileName;
            }
            else
            {
                Random rd = new Random();
                tmpNumber = rd.Next(1, 9999).ToString();
                tmpName = newFileName + "-" + tmpNumber;
            }
            string projectDirectory = System.IO.Directory.GetCurrentDirectory();
            System.IO.Directory.CreateDirectory(tmpFolder);
            File.WriteAllText(tmpFolder + @"\" + tmpName + ".xml", text);
            String batOg = File.ReadAllText(@"autoTest.bat");
            batOg = batOg.Replace("{batname}", tmpFolder + @"\" + tmpName).Replace("{path}", projectDirectory);
            String newBatchName = tmpName + ".bat";
            File.WriteAllText(tmpFolder + @"\" + newBatchName, batOg);
            if (File.Exists(tmpFolder + @"\" + tmpName + ".xml") && File.Exists(tmpFolder + @"\" + newBatchName))
            {
                checkEnterSite = true;
            }
            else
            {
                checkEnterSite = false;
            }
            batchPath = projectDirectory + @"\" + tmpFolder + @"\" + newBatchName;
            batName = tmpName;
            tmpNumberF = tmpNumber;
            logPath = tmpFolder;
            return checkEnterSite;
        }

        public void RunBatchFile(string url, string xmlName, string tmpPath, out string tmpNumber, out string logPath)
        {
            string maBn = txtMaBn.Text;
            string newName = txtTenMoi.Text;
            string tenBn = txtMaBnDoc.Text;
            string maBnMoi = txtMaBnMoi.Text;
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string batchPath = "";
            string batName = "";
            string tmpNumberF = "";
            string logPathF = "";
            bool result = enterSiteName(tmpPath, xmlName, url, maBn, newName, tenBn, maBnMoi, userName, password, out batchPath, out batName, out tmpNumberF, out logPathF);
            if (result == true)
            {
                try
                {
                    using (Process myProcess = new Process())
                    {
                        
                        int exitCode;
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(batchPath);
                        //myProcess.StartInfo.FileName = Path.GetFileName(batchPath);
                        myProcess.StartInfo.FileName = batchPath;
                        myProcess.StartInfo.CreateNoWindow = true;
                        myProcess.StartInfo.RedirectStandardError = true;
                        myProcess.StartInfo.RedirectStandardOutput = true;

                        myProcess.Start();

                        myProcess.OutputDataReceived += (object send, DataReceivedEventArgs ev) =>
                        Console.WriteLine("output>>" + ev.Data);
                        myProcess.BeginOutputReadLine();

                        myProcess.ErrorDataReceived += (object send, DataReceivedEventArgs ev) =>
                            Console.WriteLine("error>>" + ev.Data);
                        myProcess.BeginErrorReadLine();

                        // *** Read the streams ***
                        string output = myProcess.StandardOutput.ReadToEnd();
                        string error = myProcess.StandardError.ReadToEnd();

                        exitCode = myProcess.ExitCode;

                        Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
                        Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
                        Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
                        myProcess.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            else
            {

            }
            logPath = logPathF;
            tmpNumber = tmpNumberF;
        }

        public bool CheckExitsFile(string tmpPath, string tmpNumber, string testCaseName, out string resultF, out string urlRs, out string rsPath)
        {
            String result = null;
            bool matchingFile = false;
            String tmpRsPath = null;
            string rsPathTmp = "";
            if (Directory.Exists("test-output"))
            {
                System.Threading.Thread.Sleep(5000);
                string rsHtml = File.ReadAllText(@"test-output\Suite\" + testCaseName + ".html");
                if (rsHtml.Contains("PASSED TESTS"))
                {
                    result = "pass";
                    Directory.Delete(@"test-output", true);
                }
                else
                {
                    result = "fail";
                    string folderLog = "test-output" + tmpNumber;
                    string logPath =@"result\" + folderLog;

                    if (!Directory.Exists(logPath))
                    {
                        Directory.Move(@"test-output", logPath);
                        rsPathTmp = logPath + @"\Suite\" + testCaseName + ".html";
                        tmpRsPath = "../" + logPath.Replace(@"\", "/") + @"/Suite/" + testCaseName + ".html";
                    }
                    else
                    {
                        Random rd = new Random();
                        string numrd = rd.Next(1, 9999).ToString();
                        Directory.Move(@"test-output", logPath + "-" + numrd);
                        rsPathTmp = logPath + "-" + numrd + @"\Suite\" + testCaseName + ".html";
                        tmpRsPath = "../" + (logPath + "-" + numrd).Replace(@"\", "/") + @"/Suite/" + testCaseName + ".html";
                    }
                }
                matchingFile = true;
            } else {
                matchingFile = false;
            }
            rsPath = rsPathTmp;
            urlRs = tmpRsPath;
            resultF = result;
            return matchingFile;
        }

        public Dictionary<string, string> readListSite()
        {
            Dictionary<string, string> listSite = new Dictionary<string, string>();

            XElement xmlSiteInfo = XElement.Load("siteInfo.xml");
            IEnumerable<XElement> sites = xmlSiteInfo.Elements();

            foreach (var site in sites)
            {
                string siteName = site.Element("name").Value;
                string siteUrl = site.Element("url").Value;
                listSite.Add(siteName, siteUrl);
            }

            return listSite;
        }

        private void clTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked == true)
            {
                for (int i = 0; i < clSiteUrl.Items.Count; i++)
                    clSiteUrl.SetItemChecked(i, true);
            }
            else
            {
                for (int i = 0; i < clSiteUrl.Items.Count; i++)
                    clSiteUrl.SetItemChecked(i, false);
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            Dictionary<string, List<Result>> resultFinal = new Dictionary<string, List<Result>>();
            int count = 0;
            statusCountSite.Text = count.ToString();
            statusTotalSite.Text = "/ " + lstSelSite.Count.ToString();
            for (int t = 0; t < lstSelSite.Count; t++)
            {

                string siteUrl = null;
                string siteName = lstSelSite[t];
                statusSiteRunning.Text = siteName;
                if (listSite.ContainsKey(siteName))
                {
                    
                    siteUrl = listSite[siteName];
                    string tmpNumber = "";
                    string logPath = "";
                    string rsPath = "";
                    List<Result> rs = new List<Result>();
                    for (int j = 0; j < lstSelTestCase.Count; j++)
                    {
                        String urlRs = null;
                        string result = "";
                        string xmlName = lstSelTestCase[j];
                        RunBatchFile(siteUrl, xmlName, tmpFolder, out tmpNumber, out logPath);
                        bool matchResult = CheckExitsFile(logPath, tmpNumber, xmlName.Substring(0, xmlName.IndexOf(".")), out result, out urlRs, out rsPath);
                        while (matchResult == false)
                        {
                            matchResult = CheckExitsFile(logPath, tmpNumber, xmlName.Substring(0, xmlName.IndexOf(".")), out result, out urlRs, out rsPath);
                        }
                        if (matchResult == true)
                        {
                            Result data = new Result();
                            data.TestCaseName = xmlName;
                            data.ResultTest = result;
                            data.RsPath = rsPath;
                            data.ResultUrl = urlRs;
                            rs.Add(data);
                            continue;
                        }
                    }
                    
                    resultFinal.Add(siteUrl, rs);
                    
                }
                else
                {
                    continue;
                }
                if (t == lstSelSite.Count - 1)
                {
                    lstSelSite.Clear();
                    lstSelTestCase.Clear();
                }
                count++;
                statusCountSite.Text = count.ToString();
                Console.WriteLine(siteName + "\t" + siteUrl);
            }
            //render kết quả test
            String htmlResult = null;
            foreach (KeyValuePair<string, List<Result>> item in resultFinal)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
                String urlSite = item.Key;
                List<Result> listResult = item.Value;

                String table = null;
                for (int c = 0; c < listResult.Count; c++)
                {
                    Result kq = new Result();
                    kq = listResult[c];
                    String testName = kq.TestCaseName;
                    String kqTest = kq.ResultTest;
                    string rltPath = kq.RsPath;
                    string urlRst = kq.ResultUrl;
                    if (kqTest.Contains("pass"))
                    {

                    }
                    else
                    {
                        htmlResult += "<p>" + urlSite + "</p>";
                        htmlResult += "<table class=\"table table-bordered\"><thead><tr><th>Test case</th><th>Result</th><th>Exception</th></tr></thead><tbody>";
                        string testRep = testName.Substring(0, testName.IndexOf("."));
                        string rsHtmlF = File.ReadAllText(rltPath);
                        rsHtmlF = rsHtmlF.Replace(testRep, urlSite + " - " + testRep);
                        File.WriteAllText(rltPath, rsHtmlF);
                        table += "<tr><td>" + testName + "</td><td style=\"color:red;\">" + kqTest + "</td><td>" + "<a target=\"_blank\" rel=\"noopener noreferrer\" href=\"" + urlRst + "\">Xem lỗi</a>" + "</td></tr>";
                    }
                }
                htmlResult += table;
                htmlResult += "</tbody></table>";

            }
            string text = File.ReadAllText("result.html");
            text = text.Replace("{result}", htmlResult);
            File.WriteAllText(@"result\result.html", text);
            System.Diagnostics.Process.Start("Chrome", Uri.EscapeDataString(@"result\result.html"));
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusSiteRunning_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTestCase_Click(object sender, EventArgs e)
        {
            frm_AddTestCase fAT = new frm_AddTestCase();
            DialogResult dr = fAT.ShowDialog();
            if (dr.ToString().Contains("Cancel"))
            {
                loadTestCase();
            }
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            frm_AddSite fAS = new frm_AddSite();
            DialogResult dr = fAS.ShowDialog();
            if (dr.ToString().Contains("Cancel"))
            {
                loadLstSiteTestCase();
            }
        }
    }
}