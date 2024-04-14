using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.ServiceProcess;
using System.Threading;
using System.Data;
//using System.Management.Automation;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Media.Animation;

namespace AutoDownLoadFile
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // 添加自定义TabControl
            CustomTabControl tabControl = new CustomTabControl();
            TabForm.Dock = DockStyle.Fill;
            this.Controls.Add(TabForm);
        }


        /// <summary>
        /// 查询要替换的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButSeachFile_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("D:\\TPBackup\\AutoDown\\cfg\\FilePath.xml"); // 替换为你的XML文件路径
                XmlNodeList nodes = doc.SelectNodes("//FilePaths"); // 根据你的XML结构调整XPath表达式
                                                                    // 循环遍历XML中的每个登录项进行验证
                foreach (XmlNode node in nodes)
                {
                    string storedUsername = node["FilePath"].InnerText;
                    // 获取文件列表
                    string[] fileNames = Directory.GetFiles(storedUsername);
                    bool folderExists = File.Exists(storedUsername);
                    // 将文件名添加到列表框中
                    CbbFile.Items.Clear();
                    foreach (string fileName in fileNames)
                    {

                        CbbFile.Items.Add(fileName.Substring(27));
                        LogerHelper.WriteLog("已经找到文件--" + fileName.Substring(27));
                    }
                }
                MessageBox.Show("文件查找完成");
            }
            catch (Exception ex)
            {
                LogerHelper.WriteLog("Error: " + ex.Message);
            }
        }
        /// <summary>
        /// 开始搜索门店信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButSeachStore_Click(object sender, EventArgs e)
        {
            ListBoxStore.Items.Clear();
            listBoxReturn.Items.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\TPBackup\\AutoDown\\cfg\\FilePath.xml"); // 替换为你的XML文件路径
            XmlNodeList nodes = doc.SelectNodes("//StoreFiles"); // 根据你的XML结构调整XPath表达式
            string StorePath = txtBoxStorePath.Text;
            foreach (XmlNode node in nodes)
            {
                string StorelistPath = node["StoreFile"].InnerText + "\\" + StorePath;
                bool folderExists = File.Exists(StorelistPath);
                if (folderExists == true)
                {
                    // 打开文件并逐行读取内容
                    using (StreamReader reader = new StreamReader(StorelistPath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            using (var ping = new Ping())
                            {
                                var reply = ping.Send(line);
                                if (reply.Status == IPStatus.Success)
                                {
                                    listBoxReturn.Items.Add(($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms"));
                                    ListBoxStore.Items.Add(line);
                                    LogerHelper.WriteLog((($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms")));
                                }
                                else
                                {
                                    listBoxReturn.Items.Add(($"Ping {line} failed with error: {reply.Status}"));
                                    ListBoxStore.Items.Add(line);
                                    LogerHelper.WriteLog(($"Ping {line} failed with error: {reply.Status}"));
                                }
                            }
                            LogerHelper.WriteLog("获取门店list完成");
                        }
                    }
                    //CbbFile.Items.Add(fileName.Substring(27));
                    //LogerHelper.WriteLog("已经找到文件--" + fileName.Substring(27));

                }
                MessageBox.Show("文件查找完成");

            }


        }
        /// <summary>
        /// 界面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LogerHelper.WriteLog("写入日志");
            labelScrollingText.Text = "郭哥出品，必属精品（此程序仅Sephora Support L2团队使用）";
            timer.Enabled = true;

        }
        /// <summary>
        /// 开始替换操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButReplce_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\TPBackup\\AutoDown\\cfg\\FilePath.xml"); // 替换为你的XML文件路径
            XmlNodeList nodes = doc.SelectNodes("//FilePaths"); // 根据你的XML结构调整XPath表达式
            foreach (XmlNode node in nodes)
            {
                string storedUsername = node["FilePath"].InnerText;
                // 获取文件列表
                string[] fileNames = Directory.GetFiles(storedUsername);
                bool folderExists = File.Exists(storedUsername);
                // 将文件名添加到列表框中
                CbbFile.Items.Clear();
                foreach (string fileName in fileNames)
                {
                    foreach (var item in ListBoxStore.Items)
                    {
                        LogerHelper.WriteLog("开始执行替换步骤");
                        string remoteFilePath = "\\\\" + item + "\\" + textBox1.Text + "$" + textBox2.Text + "\\" + CbbFile.Text;
                        LogerHelper.WriteLog(remoteFilePath + "远程文件夹远程路径");
                        ReplaceServerFile(fileName, remoteFilePath);
                        LogerHelper.WriteLog("访问ReplaceServerFile方法，带参进入");
                    }
                    LogerHelper.WriteLog("已经找到文件--" + fileName.Substring(27));
                }
            }                                        // 循环遍历XML中的每个登录项进行验证

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LogerHelper.WriteLog("textBox1文本清空");
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            LogerHelper.WriteLog("textBox2文本清空");
        }
        private void TxtBoxList_Click(object sender, EventArgs e)
        {
            TxtBoxList.Text = "";
        }
        private void txtBoxStorePath_Click(object sender, EventArgs e)
        {
            txtBoxStorePath.Text = "";
            LogerHelper.WriteLog("txtBoxStorePath文本清空");
        }
        /// <summary>
        /// 替换文件方法
        /// </summary>
        /// <param name="localFilePath">替换的文件路径</param>
        /// <param name="remoteFilePath">源文件路径</param>
        public void ReplaceServerFile(string localFilePath, string remoteFilePath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("D:\\TPBackup\\AutoDown\\cfg\\MachineUser.xml"); // 替换为你的XML文件路径
                XmlNodeList nodes = doc.SelectNodes("//TillUsers"); // 根据你的XML结构调整XPath表达式
                                                                    // 循环遍历XML中的每个登录项进行验证

                // 循环遍历XML中的每个登录项进行验证
                foreach (XmlNode node in nodes)
                {
                    string TillUserName = node["TillUser"].InnerText;
                    string TillPassword = node["TillPassword"].InnerText; // 这里应进行实际的密码验证逻辑
                    if (TillUserName != null && TillPassword != null) // 这里仅为示例，实际应使用安全的密码验证方法
                    {

                        // 如果需要的话，这里可以添加对远程文件的网络凭证
                        NetworkCredential credential = new NetworkCredential(TillUserName, TillPassword);

                        // 使用CredentialCache存储网络凭证
                        CredentialCache cache = new CredentialCache();
                        cache.Add(new Uri(remoteFilePath), "Negotiate", credential);

                        // 使用File类的Copy方法复制文件
                        File.Delete(remoteFilePath);
                        LogerHelper.WriteLog("删除文件完成" + remoteFilePath);
                        Thread.Sleep(10000);
                        File.Copy(localFilePath, remoteFilePath, true);

                        LogerHelper.WriteLog("复制文件完成" + remoteFilePath);

                    }

                }
                MessageBox.Show("文件查找完成");
            }
            catch (Exception ex)
            {
                LogerHelper.WriteLog("Error: " + ex.Message);
            }
        }
        /// <summary>
        /// 停止服务方法
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="remoteMachine"></param>
        public void StopServiceRemotely(string serviceName, string remoteMachine)
        {
            ServiceController sc = new ServiceController(serviceName, remoteMachine);
            try
            {
                if (sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                    ///存在BUG，可以关闭，但是关闭后会报错
                    //sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(1000));
                    LogerHelper.WriteLog(remoteMachine + "的" + serviceName + "关闭成功");
                    return;
                }
                else
                {
                    LogerHelper.WriteLog(remoteMachine + "的" + serviceName + "已经关闭");
                    return;
                }
            }
            catch (InvalidOperationException ex)
            {
                // 服务名称可能不存在
                LogerHelper.WriteLog(ex.Message);
            }
        }
        /// <summary>
        /// 停止进程方法
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="processMachine"></param>
        public static void KillRemoteProcess(string processName, String processMachine)
        {
            Process[] processes = Process.GetProcessesByName(processName, processMachine);
            foreach (Process process in processes)
            {
                process.Kill();
                process.WaitForExit(); // 等待进程退出
                LogerHelper.WriteLog(processName + "的" + processName + "关闭成功");
            }
        }
        /// <summary>
        /// 开启服务方法
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="remoteMachine"></param>
        public void StartServiceRemotely(string serviceName, string remoteMachine)
        {
            ServiceController sc = new ServiceController(serviceName, remoteMachine);
            try
            {
                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    sc.Start();
                    ///存在BUG，可以关闭，但是关闭后会报错
                    //sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                    LogerHelper.WriteLog(remoteMachine + "的" + serviceName + "开启成功");
                    return;
                }
                else
                {
                    LogerHelper.WriteLog(remoteMachine + "的" + serviceName + "已经开启");
                    return;
                }
            }
            catch (InvalidOperationException ex)
            {
                // 服务名称可能不存在
                LogerHelper.WriteLog(ex.Message);
            }
        }
        /// <summary>
        /// 开启进程方法
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="processMachine"></param>
        public static void StartRemoteProcess(string processName, String processMachine)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(processName, processMachine);
                foreach (Process process in processes)
                {
                    LogerHelper.WriteLog(processName + "的" + processName + "关闭成功");
                    process.Start();
                    process.WaitForExit(); // 等待进程退出
                }
            }
            catch (Exception ex)
            {

                LogerHelper.WriteLog(ex.ToString());
            }

        }
        /// <summary>
        /// Tab2中打开按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButOpen_Click(object sender, EventArgs e)
        {
            ListBoxStore.Items.Clear();
            listBoxReturn.Items.Clear();
            string StorelistPath = TxtBoxList.Text + "\\Mag_List.txt";
            LogerHelper.WriteLog("门店列表路径--" + StorelistPath);
            // 确保文件存在
            if (!File.Exists(StorelistPath))
            {
                LogerHelper.WriteLog("路径未找到，请再次确认门店list路径");
            }

            // 打开文件并逐行读取内容
            using (StreamReader reader = new StreamReader(StorelistPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    using (var ping = new Ping())
                    {
                        var reply = ping.Send(line);
                        if (reply.Status == IPStatus.Success)
                        {
                            if (ChcboxTrafficLight.Checked == true)
                            {
                                if (ChcboxShutEPS.Checked == true)
                                {
                                    StartServiceRemotely("TPDotnet Process Manager", line.ToString());
                                    StartRemoteProcess("TPDotnet.EPS", line.ToString());
                                    listBoxTwo.Items.Add(($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms"));
                                    listBoxOne.Items.Add(line);
                                    LogerHelper.WriteLog((($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms")));
                                    LogerHelper.WriteLog("已经打开交通灯&EPS进程");
                                }
                                else
                                {
                                    StartServiceRemotely("TPDotnet Process Manager", line.ToString());
                                    listBoxTwo.Items.Add(($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms"));
                                    listBoxOne.Items.Add(line);
                                    LogerHelper.WriteLog((($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms")));
                                    LogerHelper.WriteLog("已经打开交通灯");
                                }
                            }
                            else
                            {
                                if (ChcboxShutEPS.Checked == true)
                                {
                                    StartRemoteProcess("TPDotnet.EPS", line.ToString());
                                    listBoxTwo.Items.Add(($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms"));
                                    listBoxOne.Items.Add(line);
                                    LogerHelper.WriteLog((($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms")));
                                    LogerHelper.WriteLog("已经打开EPS进程");
                                }
                                else
                                {
                                    MessageBox.Show("请选择需要打开的服务");
                                    LogerHelper.WriteLog("用户没有选择争取的服务！！！");
                                }
                            }
                        }
                        else
                        {
                            listBoxTwo.Items.Add(($"Ping {line} failed with error: {reply.Status}"));
                            listBoxOne.Items.Add(line);
                            LogerHelper.WriteLog(($"Ping {line} failed with error: {reply.Status}"));
                        }
                    }
                    LogerHelper.WriteLog("获取门店list完成");
                }
            }
        }

        /// <summary>
        /// Tab2中关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButClose_Click(object sender, EventArgs e)
        {
            ListBoxStore.Items.Clear();
            listBoxReturn.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\TPBackup\\AutoDown\\cfg\\FilePath.xml"); // 替换为你的XML文件路径
            XmlNodeList nodes = doc.SelectNodes("//ServiceStores"); // 根据你的XML结构调整XPath表达式
                                                                    // 循环遍历XML中的每个登录项进行验证
                                                                    // 循环遍历XML中的每个登录项进行验证
            foreach (XmlNode node in nodes)
            {
                string TillPassword = node["ServiceStore"].InnerText; // 这里应进行实际的密码验证逻辑
                if (TillPassword != null) // 这里仅为示例，实际应使用安全的密码验证方法
                {
                    if (!File.Exists(TillPassword + "\\" + TxtBoxList.Text))
                    {
                        LogerHelper.WriteLog("路径未找到，请再次确认门店list路径");
                    }
                    // 打开文件并逐行读取内容
                    using (StreamReader reader = new StreamReader(TillPassword + "\\" + TxtBoxList.Text))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            using (var ping = new Ping())
                            {
                                var reply = ping.Send(line);
                                if (reply.Status == IPStatus.Success)
                                {
                                    if (ChcboxTrafficLight.Checked == true)
                                    {
                                        if (ChcboxShutEPS.Checked == true)
                                        {
                                            StopServiceRemotely("TPDotnet Process Manager", line.ToString());
                                            KillRemoteProcess("TPDotnet.EPS.exe", line.ToString());
                                            listBoxTwo.Items.Add(($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms"));
                                            listBoxOne.Items.Add(line);
                                            LogerHelper.WriteLog((($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms")));
                                            LogerHelper.WriteLog("已经关闭交通灯&EPS进程");
                                        }
                                        else
                                        {
                                            StopServiceRemotely("TPDotnet Process Manager", line.ToString());
                                            listBoxTwo.Items.Add(($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms"));
                                            listBoxOne.Items.Add(line);
                                            listBoxTwo.Refresh();
                                            listBoxOne.Refresh();
                                            LogerHelper.WriteLog((($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms")));
                                            LogerHelper.WriteLog("已经关闭交通灯");

                                        }
                                    }
                                    else
                                    {
                                        if (ChcboxShutEPS.Checked == true)
                                        {
                                            KillRemoteProcess("TPDotnet.EPS", line.ToString());
                                            listBoxTwo.Items.Add(($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms"));
                                            listBoxOne.Items.Add(line);
                                            LogerHelper.WriteLog((($"Ping {line} succeeded. Time: {reply.RoundtripTime} ms")));
                                            LogerHelper.WriteLog("已经关闭EPS进程");
                                        }
                                        else
                                        {
                                            MessageBox.Show("请选择需要关闭的服务");
                                            LogerHelper.WriteLog("用户没有选择正确的服务！！！");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("出现未知网络问题，门店无法Ping通！！！");
                                    LogerHelper.WriteLog(($"Ping {line} failed with error: {reply.Status}"));
                                }
                            }
                            LogerHelper.WriteLog("获取门店list完成");
                        }
                    }
                }

            }
            //string StorelistPath = TxtBoxList.Text + "\\Mag_List.txt";
            //LogerHelper.WriteLog("门店列表路径--" + StorelistPath);
            // 确保文件存在

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelScrollingText.Left -= 15;
            if (labelScrollingText.Right < 0)
            {
                labelScrollingText.Left = this.Width;
            }
        }

        private void ButGetPath_Click(object sender, EventArgs e)
        {
            //string Querytxt = "D:\\Backup\\Backup" + "\\Query1.txt";
            //string Storetxt = "D:\\Backup\\Backup\\Mag_List.txt";

            List<DataTable> dataList = new List<DataTable>();
            DataTable table = new DataTable();
            int TableRow = 0;


            ListBoxStore.Items.Clear();
            listBoxReturn.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\TPBackup\\AutoDown\\cfg\\FilePath.xml"); // 替换为你的XML文件路径
            XmlNodeList nodes = doc.SelectNodes("//PushPutDatas"); // 根据你的XML结构调整XPath表达式
                                                                   // 循环遍历XML中的每个登录项进行验证
                                                                   // 循环遍历XML中的每个登录项进行验证
            foreach (XmlNode node in nodes)
            {
                string TillPassword = node["PushPutData"].InnerText; // 这里应进行实际的密码验证逻辑
                if (TillPassword != null) // 这里仅为示例，实际应使用安全的密码验证方法
                {
                    if (!File.Exists(TillPassword + "\\" + txtScriptPath.Text))
                    {
                        LogerHelper.WriteLog("路径未找到，请再次确认门店list路径");
                    }
                    else
                    {
                        //txtScriptPath
                        //txtStorePath
                        // 打开文件并逐行读取内容
                        using (StreamReader ReaderStoew = new StreamReader(TillPassword + "\\" + txtStorePath.Text))
                        {
                            while (!ReaderStoew.EndOfStream)
                            {
                                string Stoewline = ReaderStoew.ReadLine();
                                using (var ping = new Ping())
                                {
                                    var reply = ping.Send(Stoewline);
                                    if (reply.Status == IPStatus.Success)
                                    {
                                        StreamReader reader = new StreamReader(TillPassword + "\\" + txtScriptPath.Text);
                                        string txtscript = reader.ReadLine();
                                        table = DataBaseHelper.GetDataTable(txtscript, Stoewline);
                                        dataList.Add(table);
                                        LogerHelper.WriteLog("获取数据成功--" + txtscript);
                                        TableRow += table.Rows.Count;
                                        LogerHelper.WriteLog((($"Ping {Stoewline} succeeded. Time: {reply.RoundtripTime} ms")));
                                    }
                                    else
                                    {
                                        LogerHelper.WriteLog(($"Ping {Stoewline} failed with error: {reply.Status}"));
                                    }
                                }
                            }
                        }
                        DataTable combinedData = CombineDataTables(dataList);
                        LogerHelper.WriteLog(combinedData.Rows.Count.ToString());
                        DataSetView.DataSource = combinedData;
                        MessageBox.Show("本次查询，总共获取到" + TableRow + "条数据！！！");
                        LogerHelper.WriteLog("获取数据的方法完成");
                    }
                }


            }
        }
        private DataTable CombineDataTables(List<DataTable> dataTables)
        {
            if (dataTables.Count == 0)
                return new DataTable();

            DataTable firstTable = dataTables[0];
            DataTable combinedTable = firstTable.Clone();

            foreach (DataTable table in dataTables)
            {
                foreach (DataRow row in table.Rows)
                {
                    combinedTable.ImportRow(row);
                }
            }

            return combinedTable;
        }

        private void txtBoxStore_Click(object sender, EventArgs e)
        {
            txtBoxStore.Text = "";
            txtBoxStore.ForeColor = Color.Black;
        }

        private void ButAuthority_Click(object sender, EventArgs e)
        {
            try
            {
                bool containsField = txtBoxStore.Text.Contains("CNTS");
                //判断输入的门店号是否包含CNTS,否则提示问题
                if (containsField == true)
                {
                    //判断开通团购的选项是否勾选
                    if (RadButCheck.Checked == true)
                    {
                        //开始ping输入的门店号
                        using (var ping = new Ping())
                        {
                            var reply = ping.Send(txtBoxStore.Text);
                            if (reply.Status == IPStatus.Success)
                            {
                                string StrQuery = "update Employee set szEmplName=N'Jack Dong' where lEmployeeID=7";
                                bool ReturnResoult = DataBaseHelper.ExecuteNonQuery(StrQuery, txtBoxStore.Text);
                                if (ReturnResoult == true)
                                {
                                    MessageBox.Show("开通权限正常，请通知门店！！！");
                                    LogerHelper.WriteLog("开通权限正常，请通知门店！！！");
                                }
                                else
                                {
                                    MessageBox.Show("开通出现未知异常，请手动开通后通知门店！！！");
                                    LogerHelper.WriteLog("开通出现未知异常，请手动开通后通知门店！！！");
                                }
                            }
                            else
                            {
                                MessageBox.Show("门店网络出现异常，请检查网络后重试！！！");
                                LogerHelper.WriteLog("门店网络出现异常，请检查网络后重试！！！");
                            }
                        }
                    }
                    else
                    {
                        if (RadButDiscount.Checked == true)
                        {
                            MessageBox.Show("开通手工折扣权限");
                        }
                        else
                        {
                            MessageBox.Show("请选择要开通的权限");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确的门店号码!!!");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ButGetData_Click(object sender, EventArgs e)
        {
            // 假设dataGridView1是你的DataGridView控件
            DataTable dt = DataSetView.DataSource as DataTable;
            if (dt != null)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // 将DataTable中的数据写入Excel工作表
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dt.Columns[i].ColumnName; // 写入列名
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dt.Rows[i][j].ToString(); // 写入数据行
                        }
                    }

                    XmlDocument doc = new XmlDocument();
                    doc.Load("D:\\TPBackup\\AutoDown\\cfg\\FilePath.xml"); // 替换为你的XML文件路径
                    XmlNodeList nodes = doc.SelectNodes("//SaveExcels"); // 根据你的XML结构调整XPath表达式
                                                                         // 循环遍历XML中的每个登录项进行验证
                    foreach (XmlNode node in nodes)
                    {
                        string SaveExcelPath = node["SaveExcel"].InnerText; // 这里应进行实际的密码验证逻辑
                                                                           // 保存Excel文件
                        string filePath = SaveExcelPath+"\\"+ txtBoxSavePath.Text + ".xlsx"; // 你想要保存的文件路径和名称
                        package.SaveAs(new System.IO.FileInfo(filePath));
                        MessageBox.Show("文件导出正常，请至" + SaveExcelPath + "内查找！！！");
                        LogerHelper.WriteLog("文件导出正常，请至" + SaveExcelPath + "内查找！！！");

                    }
                }
            }
        }
    }
}
