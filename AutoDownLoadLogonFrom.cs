using AutoDownLoadFile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoDownLoadFile
{
    public partial class AutoDownLoadLogonFrom : Form
    {
        public AutoDownLoadLogonFrom()
        {
            InitializeComponent();
        }
        private bool qqTxtFocus = false;
        private bool pwdTxtFocus = false;
        private bool qqTxtHover = false;
        private bool pwdTxtHover = false;
        private void AutoDownLoadLogonFrom_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, 734, 117);
            Color fromColor = Color.FromArgb(66, 84, 255);
            Color toColor = Color.FromArgb(124, 228, 255);
            Brush brush = new LinearGradientBrush(rectangle, fromColor, toColor, LinearGradientMode.ForwardDiagonal);
            graphics.FillRectangle(brush, rectangle);

            Rectangle rectangle1 = new Rectangle(0, 0, 734, 117);
            Brush brush1 = new LinearGradientBrush(rectangle1, fromColor, toColor, LinearGradientMode.BackwardDiagonal);
            graphics.FillRectangle(brush1, rectangle1);

            //登录按钮美化
            ButLogin.Size = new Size(220, 42); // 控件大小
            ButLogin.Text = "登    录"; // 控件文本
            GraphicsPath path = new GraphicsPath();
            int radius = 8; // 圆角半径
            Rectangle rect = new Rectangle(0, 0, ButLogin.Width, ButLogin.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // 左上角
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // 右上角
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // 右下角
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // 左下角
            path.CloseFigure();
            ButLogin.Region = new Region(path); // 设置圆角矩形区域
            ButLogin.BackColor = Color.LightBlue; // 设置背景颜色
            ButLogin.FlatStyle = FlatStyle.Flat; // 设置为无边框样式
            ButLogin.FlatAppearance.BorderSize = 0; // 去掉边框
            

        }

        private void AutoDownLoadLogonFrom_Load(object sender, EventArgs e)
        {
            //关闭显示密码
            txtPwd.UseSystemPasswordChar = true;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(this.picHead.ClientRectangle);
            this.picHead.Region = new Region(graphicsPath);
        }

        private void PniInput_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            //绘制QQ号下方横线
            Graphics g = e.Graphics;
            Color qqUnderline;
            if (qqTxtFocus)
            {
                qqUnderline = Color.DodgerBlue;
            }
            else
            {
                if (qqTxtHover)
                    qqUnderline = Color.Gray;
                else
                    qqUnderline = Color.LightGray;
            }
            Pen qqPen = new Pen(qqUnderline, 1);

            g.DrawLine(qqPen, 5, 35, PniInput.Width - 5, 35);
            //绘制密码下方横线
            Color pwdUnderline;
            if (pwdTxtFocus)
            {
                pwdUnderline = Color.DodgerBlue;
            }
            else
            {
                if (pwdTxtHover)
                    pwdUnderline = Color.Gray;
                else
                    pwdUnderline = Color.LightGray;
            }

            Pen pwdPen = new Pen(pwdUnderline, 1);
            g.DrawLine(pwdPen, 5, 79, PniInput.Width - 5, 79);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            qqTxtFocus = true;
            this.PniInput.Refresh();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            qqTxtFocus = false;
            this.PniInput.Refresh();
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            qqTxtHover = true;
            this.PniInput.Refresh();
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            qqTxtHover = false;
            this.PniInput.Refresh();
        }


        private void txtPwd_Leave(object sender, EventArgs e)
        {
            pwdTxtFocus = false;
            this.PniInput.Refresh();
        }

        private void txtPwd_MouseEnter(object sender, EventArgs e)
        {
            pwdTxtHover = true;
            this.PniInput.Refresh();
        }

        private void txtPwd_MouseLeave(object sender, EventArgs e)
        {
            pwdTxtHover = false;
            this.PniInput.Refresh();
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            pwdTxtFocus = true;
            this.PniInput.Refresh();
        }

        private void ButLogin_MouseEnter(object sender, EventArgs e)
        {
            //ButLogin.BackgroundImage = Resources.login;
            this.PniInput.Refresh();
        }

        private void ButLogin_MouseLeave(object sender, EventArgs e)
        {
            //ButLogin.BackgroundImage = Resources.Logout;
            this.PniInput.Refresh();
        }
        private Point mPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private bool settingHover = false;
        private bool minHover = false;

        private void ButHide_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rectangle = ButHide.ClientRectangle;
            if (minHover)
            {
                SolidBrush solidBrush = new SolidBrush(Color.FromArgb(50, 255, 255, 255));
                g.FillRectangle(solidBrush, rectangle);
            }
            else
            {
                SolidBrush solidBrush = new SolidBrush(Color.FromArgb(0, 255, 255, 255));
                g.FillRectangle(solidBrush, rectangle);
            }
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButHide_MouseEnter(object sender, EventArgs e)
        {
            minHover = true;
            ButHide.Refresh();
        }

        private void ButHide_MouseLeave(object sender, EventArgs e)
        {
            minHover = false;
            ButHide.Refresh();
        }

        private void ButHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButLogin_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\TPBackup\\AutoDown\\cfg\\loginData.xml"); // 替换为你的XML文件路径
            LogerHelper.WriteLog("读取登录完成");
            XmlNodeList nodes = doc.SelectNodes("//Login"); // 根据你的XML结构调整XPath表达式

            // 假设你有用户名和密码输入控件，如 textBoxUsername 和 textBoxPassword
            string enteredUsername = txtUser.Text;
            string enteredPassword = txtPwd.Text; // 这里应进行密码验证逻辑，如哈希比较等

            // 循环遍历XML中的每个登录项进行验证
            foreach (XmlNode node in nodes)
            {
                string storedUsername = node["Username"].InnerText;
                string storedPassword = node["Password"].InnerText; // 这里应进行实际的密码验证逻辑
                if (enteredUsername == storedUsername && enteredPassword == storedPassword) // 这里仅为示例，实际应使用安全的密码验证方法
                {
                    LogerHelper.WriteLog(txtUser.Text + "登入成功");
                    this.Hide();
                    Form1 from = new Form1();
                    from.Show();
                    this.ShowInTaskbar = false;
                    return; // 找到匹配项后退出循环
                }

            }
            MessageBox.Show("用户名或密码错误，请从新输入！！！");
        }

        private void ButCheckPwd_Click(object sender, EventArgs e)
        {
            // 切换密码显示状态
            if (txtPwd.UseSystemPasswordChar)
            {
                txtPwd.UseSystemPasswordChar = false; // 显示密码
                ButCheckPwd.BackgroundImage = Resources.CheckPwdHide;
                this.PniInput.Refresh();
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true; // 隐藏密码
                ButCheckPwd.BackgroundImage = Resources.CheckPwdShow;
                this.PniInput.Refresh();
            }
        }

        /**/
    }
}
