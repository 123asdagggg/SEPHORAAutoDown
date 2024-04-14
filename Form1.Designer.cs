using System.Windows.Forms;
using System.Drawing;

namespace AutoDownLoadFile
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.CbbFile = new System.Windows.Forms.ComboBox();
            this.ButSeachFile = new System.Windows.Forms.Button();
            this.ListBoxStore = new System.Windows.Forms.ListBox();
            this.ButSeachStore = new System.Windows.Forms.Button();
            this.txtBoxStorePath = new System.Windows.Forms.TextBox();
            this.listBoxReturn = new System.Windows.Forms.ListBox();
            this.ButReplce = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxTwo = new System.Windows.Forms.ListBox();
            this.listBoxOne = new System.Windows.Forms.ListBox();
            this.ButClose = new System.Windows.Forms.Button();
            this.ButOpen = new System.Windows.Forms.Button();
            this.TxtBoxList = new System.Windows.Forms.TextBox();
            this.ChcboxShutEPS = new System.Windows.Forms.CheckBox();
            this.ChcboxTrafficLight = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSavePath = new System.Windows.Forms.TextBox();
            this.ButGetData = new System.Windows.Forms.Button();
            this.ButGetPath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStorePath = new System.Windows.Forms.TextBox();
            this.Lab = new System.Windows.Forms.Label();
            this.txtScriptPath = new System.Windows.Forms.TextBox();
            this.DataSetView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtBoxStore = new System.Windows.Forms.TextBox();
            this.ButAuthority = new System.Windows.Forms.Button();
            this.RadButDiscount = new System.Windows.Forms.RadioButton();
            this.RadButCheck = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelScrollingText = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件名字";
            // 
            // CbbFile
            // 
            this.CbbFile.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CbbFile.FormattingEnabled = true;
            this.CbbFile.Location = new System.Drawing.Point(428, 96);
            this.CbbFile.Name = "CbbFile";
            this.CbbFile.Size = new System.Drawing.Size(298, 26);
            this.CbbFile.TabIndex = 1;
            this.CbbFile.Text = "请选择文件名称";
            // 
            // ButSeachFile
            // 
            this.ButSeachFile.Location = new System.Drawing.Point(488, 18);
            this.ButSeachFile.Name = "ButSeachFile";
            this.ButSeachFile.Size = new System.Drawing.Size(130, 49);
            this.ButSeachFile.TabIndex = 2;
            this.ButSeachFile.Text = "搜索文件";
            this.ButSeachFile.UseVisualStyleBackColor = true;
            this.ButSeachFile.Click += new System.EventHandler(this.ButSeachFile_Click);
            // 
            // ListBoxStore
            // 
            this.ListBoxStore.FormattingEnabled = true;
            this.ListBoxStore.ItemHeight = 18;
            this.ListBoxStore.Location = new System.Drawing.Point(222, 318);
            this.ListBoxStore.Name = "ListBoxStore";
            this.ListBoxStore.Size = new System.Drawing.Size(298, 292);
            this.ListBoxStore.TabIndex = 5;
            // 
            // ButSeachStore
            // 
            this.ButSeachStore.Location = new System.Drawing.Point(428, 210);
            this.ButSeachStore.Name = "ButSeachStore";
            this.ButSeachStore.Size = new System.Drawing.Size(92, 45);
            this.ButSeachStore.TabIndex = 6;
            this.ButSeachStore.Text = "搜索门店";
            this.ButSeachStore.UseVisualStyleBackColor = true;
            this.ButSeachStore.Click += new System.EventHandler(this.ButSeachStore_Click);
            // 
            // txtBoxStorePath
            // 
            this.txtBoxStorePath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxStorePath.Location = new System.Drawing.Point(428, 270);
            this.txtBoxStorePath.Name = "txtBoxStorePath";
            this.txtBoxStorePath.Size = new System.Drawing.Size(298, 28);
            this.txtBoxStorePath.TabIndex = 7;
            this.txtBoxStorePath.Text = "请输入门店list文件名称";
            this.txtBoxStorePath.Click += new System.EventHandler(this.txtBoxStorePath_Click);
            // 
            // listBoxReturn
            // 
            this.listBoxReturn.FormattingEnabled = true;
            this.listBoxReturn.ItemHeight = 18;
            this.listBoxReturn.Location = new System.Drawing.Point(602, 318);
            this.listBoxReturn.Name = "listBoxReturn";
            this.listBoxReturn.Size = new System.Drawing.Size(303, 292);
            this.listBoxReturn.TabIndex = 8;
            // 
            // ButReplce
            // 
            this.ButReplce.Location = new System.Drawing.Point(602, 210);
            this.ButReplce.Name = "ButReplce";
            this.ButReplce.Size = new System.Drawing.Size(124, 45);
            this.ButReplce.TabIndex = 9;
            this.ButReplce.Text = "开始替换";
            this.ButReplce.UseVisualStyleBackColor = true;
            this.ButReplce.Click += new System.EventHandler(this.ButReplce_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(428, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "盘符";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(551, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 28);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "文件路径";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "目标文件路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "+";
            // 
            // TabForm
            // 
            this.TabForm.Controls.Add(this.tabPage1);
            this.TabForm.Controls.Add(this.tabPage2);
            this.TabForm.Controls.Add(this.tabPage3);
            this.TabForm.Controls.Add(this.tabPage4);
            this.TabForm.Location = new System.Drawing.Point(12, 12);
            this.TabForm.Name = "TabForm";
            this.TabForm.SelectedIndex = 0;
            this.TabForm.Size = new System.Drawing.Size(1069, 754);
            this.TabForm.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButSeachFile);
            this.tabPage1.Controls.Add(this.listBoxReturn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CbbFile);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.ListBoxStore);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ButSeachStore);
            this.tabPage1.Controls.Add(this.ButReplce);
            this.tabPage1.Controls.Add(this.txtBoxStorePath);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1061, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件复制";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxTwo);
            this.tabPage2.Controls.Add(this.listBoxOne);
            this.tabPage2.Controls.Add(this.ButClose);
            this.tabPage2.Controls.Add(this.ButOpen);
            this.tabPage2.Controls.Add(this.TxtBoxList);
            this.tabPage2.Controls.Add(this.ChcboxShutEPS);
            this.tabPage2.Controls.Add(this.ChcboxTrafficLight);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "开启服务";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxTwo
            // 
            this.listBoxTwo.FormattingEnabled = true;
            this.listBoxTwo.ItemHeight = 18;
            this.listBoxTwo.Location = new System.Drawing.Point(569, 276);
            this.listBoxTwo.Name = "listBoxTwo";
            this.listBoxTwo.Size = new System.Drawing.Size(303, 292);
            this.listBoxTwo.TabIndex = 21;
            // 
            // listBoxOne
            // 
            this.listBoxOne.FormattingEnabled = true;
            this.listBoxOne.ItemHeight = 18;
            this.listBoxOne.Location = new System.Drawing.Point(189, 276);
            this.listBoxOne.Name = "listBoxOne";
            this.listBoxOne.Size = new System.Drawing.Size(298, 292);
            this.listBoxOne.TabIndex = 18;
            // 
            // ButClose
            // 
            this.ButClose.Location = new System.Drawing.Point(578, 168);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(115, 45);
            this.ButClose.TabIndex = 19;
            this.ButClose.Text = "关闭";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // ButOpen
            // 
            this.ButOpen.Location = new System.Drawing.Point(395, 168);
            this.ButOpen.Name = "ButOpen";
            this.ButOpen.Size = new System.Drawing.Size(115, 45);
            this.ButOpen.TabIndex = 22;
            this.ButOpen.Text = "开启";
            this.ButOpen.UseVisualStyleBackColor = true;
            this.ButOpen.Click += new System.EventHandler(this.ButOpen_Click);
            // 
            // TxtBoxList
            // 
            this.TxtBoxList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBoxList.Location = new System.Drawing.Point(395, 233);
            this.TxtBoxList.Name = "TxtBoxList";
            this.TxtBoxList.Size = new System.Drawing.Size(298, 28);
            this.TxtBoxList.TabIndex = 20;
            this.TxtBoxList.Text = "请输入门店list路径";
            this.TxtBoxList.Click += new System.EventHandler(this.TxtBoxList_Click);
            // 
            // ChcboxShutEPS
            // 
            this.ChcboxShutEPS.AutoSize = true;
            this.ChcboxShutEPS.Location = new System.Drawing.Point(596, 111);
            this.ChcboxShutEPS.Name = "ChcboxShutEPS";
            this.ChcboxShutEPS.Size = new System.Drawing.Size(97, 22);
            this.ChcboxShutEPS.TabIndex = 17;
            this.ChcboxShutEPS.Text = "EPS程序";
            this.ChcboxShutEPS.UseVisualStyleBackColor = true;
            // 
            // ChcboxTrafficLight
            // 
            this.ChcboxTrafficLight.AutoSize = true;
            this.ChcboxTrafficLight.Location = new System.Drawing.Point(395, 111);
            this.ChcboxTrafficLight.Name = "ChcboxTrafficLight";
            this.ChcboxTrafficLight.Size = new System.Drawing.Size(88, 22);
            this.ChcboxTrafficLight.TabIndex = 16;
            this.ChcboxTrafficLight.Text = "交通灯";
            this.ChcboxTrafficLight.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtBoxSavePath);
            this.tabPage3.Controls.Add(this.ButGetData);
            this.tabPage3.Controls.Add(this.ButGetPath);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtStorePath);
            this.tabPage3.Controls.Add(this.Lab);
            this.tabPage3.Controls.Add(this.txtScriptPath);
            this.tabPage3.Controls.Add(this.DataSetView);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1061, 722);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "拉取数据";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "文件名称";
            // 
            // txtBoxSavePath
            // 
            this.txtBoxSavePath.Location = new System.Drawing.Point(641, 73);
            this.txtBoxSavePath.Name = "txtBoxSavePath";
            this.txtBoxSavePath.Size = new System.Drawing.Size(342, 28);
            this.txtBoxSavePath.TabIndex = 7;
            // 
            // ButGetData
            // 
            this.ButGetData.Location = new System.Drawing.Point(849, 17);
            this.ButGetData.Name = "ButGetData";
            this.ButGetData.Size = new System.Drawing.Size(134, 50);
            this.ButGetData.TabIndex = 6;
            this.ButGetData.Text = "开始拉取数据";
            this.ButGetData.UseVisualStyleBackColor = true;
            this.ButGetData.Click += new System.EventHandler(this.ButGetData_Click);
            // 
            // ButGetPath
            // 
            this.ButGetPath.Location = new System.Drawing.Point(641, 17);
            this.ButGetPath.Name = "ButGetPath";
            this.ButGetPath.Size = new System.Drawing.Size(134, 50);
            this.ButGetPath.TabIndex = 5;
            this.ButGetPath.Text = "获取路径";
            this.ButGetPath.UseVisualStyleBackColor = true;
            this.ButGetPath.Click += new System.EventHandler(this.ButGetPath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "门店list路径";
            // 
            // txtStorePath
            // 
            this.txtStorePath.Location = new System.Drawing.Point(190, 77);
            this.txtStorePath.Name = "txtStorePath";
            this.txtStorePath.Size = new System.Drawing.Size(342, 28);
            this.txtStorePath.TabIndex = 3;
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Location = new System.Drawing.Point(101, 27);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(80, 18);
            this.Lab.TabIndex = 2;
            this.Lab.Text = "脚本路径";
            // 
            // txtScriptPath
            // 
            this.txtScriptPath.Location = new System.Drawing.Point(190, 17);
            this.txtScriptPath.Name = "txtScriptPath";
            this.txtScriptPath.Size = new System.Drawing.Size(342, 28);
            this.txtScriptPath.TabIndex = 1;
            // 
            // DataSetView
            // 
            this.DataSetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSetView.Location = new System.Drawing.Point(7, 134);
            this.DataSetView.Name = "DataSetView";
            this.DataSetView.ReadOnly = true;
            this.DataSetView.RowHeadersWidth = 62;
            this.DataSetView.RowTemplate.Height = 30;
            this.DataSetView.Size = new System.Drawing.Size(1051, 570);
            this.DataSetView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtBoxStore);
            this.tabPage4.Controls.Add(this.ButAuthority);
            this.tabPage4.Controls.Add(this.RadButDiscount);
            this.tabPage4.Controls.Add(this.RadButCheck);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1061, 722);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "开通权限";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtBoxStore
            // 
            this.txtBoxStore.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxStore.Location = new System.Drawing.Point(368, 237);
            this.txtBoxStore.Name = "txtBoxStore";
            this.txtBoxStore.Size = new System.Drawing.Size(348, 28);
            this.txtBoxStore.TabIndex = 3;
            this.txtBoxStore.Text = "请输入需要开通的门店号";
            this.txtBoxStore.Click += new System.EventHandler(this.txtBoxStore_Click);
            // 
            // ButAuthority
            // 
            this.ButAuthority.Location = new System.Drawing.Point(478, 156);
            this.ButAuthority.Name = "ButAuthority";
            this.ButAuthority.Size = new System.Drawing.Size(112, 46);
            this.ButAuthority.TabIndex = 2;
            this.ButAuthority.Text = "点击开通";
            this.ButAuthority.UseVisualStyleBackColor = true;
            this.ButAuthority.Click += new System.EventHandler(this.ButAuthority_Click);
            // 
            // RadButDiscount
            // 
            this.RadButDiscount.AutoSize = true;
            this.RadButDiscount.Location = new System.Drawing.Point(539, 308);
            this.RadButDiscount.Name = "RadButDiscount";
            this.RadButDiscount.Size = new System.Drawing.Size(177, 22);
            this.RadButDiscount.TabIndex = 1;
            this.RadButDiscount.TabStop = true;
            this.RadButDiscount.Text = "开通手工折扣权限";
            this.RadButDiscount.UseVisualStyleBackColor = true;
            // 
            // RadButCheck
            // 
            this.RadButCheck.AutoSize = true;
            this.RadButCheck.Location = new System.Drawing.Point(368, 308);
            this.RadButCheck.Name = "RadButCheck";
            this.RadButCheck.Size = new System.Drawing.Size(141, 22);
            this.RadButCheck.TabIndex = 0;
            this.RadButCheck.TabStop = true;
            this.RadButCheck.Text = "开通团购权限";
            this.RadButCheck.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelScrollingText
            // 
            this.labelScrollingText.AutoSize = true;
            this.labelScrollingText.BackColor = System.Drawing.Color.White;
            this.labelScrollingText.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScrollingText.ForeColor = System.Drawing.Color.Red;
            this.labelScrollingText.Location = new System.Drawing.Point(20, 785);
            this.labelScrollingText.Name = "labelScrollingText";
            this.labelScrollingText.Size = new System.Drawing.Size(133, 30);
            this.labelScrollingText.TabIndex = 17;
            this.labelScrollingText.Text = "滚动字幕";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1093, 824);
            this.Controls.Add(this.labelScrollingText);
            this.Controls.Add(this.TabForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "自动下发程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbbFile;
        private System.Windows.Forms.Button ButSeachFile;
        private System.Windows.Forms.ListBox ListBoxStore;
        private System.Windows.Forms.Button ButSeachStore;
        private System.Windows.Forms.TextBox txtBoxStorePath;
        private System.Windows.Forms.ListBox listBoxReturn;
        private System.Windows.Forms.Button ButReplce;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl TabForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ChcboxShutEPS;
        private System.Windows.Forms.CheckBox ChcboxTrafficLight;
        private System.Windows.Forms.ListBox listBoxTwo;
        private System.Windows.Forms.ListBox listBoxOne;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Button ButOpen;
        private System.Windows.Forms.TextBox TxtBoxList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStorePath;
        private System.Windows.Forms.Label Lab;
        private System.Windows.Forms.TextBox txtScriptPath;
        private System.Windows.Forms.DataGridView DataSetView;
        private System.Windows.Forms.Button ButGetData;
        private System.Windows.Forms.Button ButGetPath;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelScrollingText;
        private TabPage tabPage4;
        private RadioButton RadButDiscount;
        private RadioButton RadButCheck;
        private TextBox txtBoxStore;
        private Button ButAuthority;
        private Label label5;
        private TextBox txtBoxSavePath;
        private NotifyIcon notifyIcon1;
    }
}

