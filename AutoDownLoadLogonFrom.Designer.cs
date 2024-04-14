namespace AutoDownLoadFile
{
    partial class AutoDownLoadLogonFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoDownLoadLogonFrom));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.PniInput = new System.Windows.Forms.Panel();
            this.ButCheckPwd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ButClose = new System.Windows.Forms.Button();
            this.ButHide = new System.Windows.Forms.Button();
            this.ButLogin = new System.Windows.Forms.Button();
            this.picHead = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PniInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUser.Location = new System.Drawing.Point(81, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(219, 28);
            this.txtUser.TabIndex = 4;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            this.txtUser.MouseEnter += new System.EventHandler(this.txtUser_MouseEnter);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_MouseLeave);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(80, 81);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(224, 28);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.Enter += new System.EventHandler(this.txtPwd_Enter);
            this.txtPwd.Leave += new System.EventHandler(this.txtPwd_Leave);
            this.txtPwd.MouseEnter += new System.EventHandler(this.txtPwd_MouseEnter);
            this.txtPwd.MouseLeave += new System.EventHandler(this.txtPwd_MouseLeave);
            // 
            // PniInput
            // 
            this.PniInput.Controls.Add(this.ButCheckPwd);
            this.PniInput.Controls.Add(this.txtPwd);
            this.PniInput.Controls.Add(this.pictureBox1);
            this.PniInput.Controls.Add(this.txtUser);
            this.PniInput.Controls.Add(this.pictureBox2);
            this.PniInput.Location = new System.Drawing.Point(214, 176);
            this.PniInput.Name = "PniInput";
            this.PniInput.Size = new System.Drawing.Size(323, 147);
            this.PniInput.TabIndex = 7;
            this.PniInput.Paint += new System.Windows.Forms.PaintEventHandler(this.PniInput_Paint);
            // 
            // ButCheckPwd
            // 
            this.ButCheckPwd.BackColor = System.Drawing.Color.Transparent;
            this.ButCheckPwd.BackgroundImage = global::AutoDownLoadFile.Properties.Resources.CheckPwdShow;
            this.ButCheckPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButCheckPwd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButCheckPwd.FlatAppearance.BorderSize = 0;
            this.ButCheckPwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.ButCheckPwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ButCheckPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButCheckPwd.Location = new System.Drawing.Point(285, 76);
            this.ButCheckPwd.Name = "ButCheckPwd";
            this.ButCheckPwd.Size = new System.Drawing.Size(35, 36);
            this.ButCheckPwd.TabIndex = 11;
            this.ButCheckPwd.UseVisualStyleBackColor = true;
            this.ButCheckPwd.Click += new System.EventHandler(this.ButCheckPwd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(75, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "SEPHORA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButClose);
            this.panel1.Controls.Add(this.ButHide);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 45);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AutoDownLoadFile.Properties.Resources.Sephora;
            this.pictureBox3.Location = new System.Drawing.Point(22, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // ButClose
            // 
            this.ButClose.BackColor = System.Drawing.Color.Transparent;
            this.ButClose.BackgroundImage = global::AutoDownLoadFile.Properties.Resources.close1;
            this.ButClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButClose.FlatAppearance.BorderSize = 0;
            this.ButClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButClose.Location = new System.Drawing.Point(708, 1);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(34, 35);
            this.ButClose.TabIndex = 1;
            this.ButClose.UseVisualStyleBackColor = false;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // ButHide
            // 
            this.ButHide.BackColor = System.Drawing.Color.Transparent;
            this.ButHide.BackgroundImage = global::AutoDownLoadFile.Properties.Resources.Hide;
            this.ButHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButHide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButHide.FlatAppearance.BorderSize = 0;
            this.ButHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.ButHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ButHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButHide.Image = ((System.Drawing.Image)(resources.GetObject("ButHide.Image")));
            this.ButHide.Location = new System.Drawing.Point(671, 1);
            this.ButHide.Name = "ButHide";
            this.ButHide.Size = new System.Drawing.Size(35, 36);
            this.ButHide.TabIndex = 0;
            this.ButHide.UseVisualStyleBackColor = true;
            this.ButHide.Click += new System.EventHandler(this.ButHide_Click);
            this.ButHide.Paint += new System.Windows.Forms.PaintEventHandler(this.ButHide_Paint);
            this.ButHide.MouseEnter += new System.EventHandler(this.ButHide_MouseEnter);
            this.ButHide.MouseLeave += new System.EventHandler(this.ButHide_MouseLeave);
            // 
            // ButLogin
            // 
            this.ButLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButLogin.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButLogin.Image = ((System.Drawing.Image)(resources.GetObject("ButLogin.Image")));
            this.ButLogin.Location = new System.Drawing.Point(214, 357);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.Size = new System.Drawing.Size(323, 42);
            this.ButLogin.TabIndex = 8;
            this.ButLogin.Text = "等     录";
            this.ButLogin.UseVisualStyleBackColor = true;
            this.ButLogin.Click += new System.EventHandler(this.ButLogin_Click);
            this.ButLogin.MouseEnter += new System.EventHandler(this.ButLogin_MouseEnter);
            this.ButLogin.MouseLeave += new System.EventHandler(this.ButLogin_MouseLeave);
            // 
            // picHead
            // 
            this.picHead.Image = ((System.Drawing.Image)(resources.GetObject("picHead.Image")));
            this.picHead.Location = new System.Drawing.Point(313, 50);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(120, 120);
            this.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHead.TabIndex = 2;
            this.picHead.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-22, -22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AutoDownLoadLogonFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButLogin);
            this.Controls.Add(this.PniInput);
            this.Controls.Add(this.picHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoDownLoadLogonFrom";
            this.Text = "AutoDownLoadLogonFrom";
            this.Load += new System.EventHandler(this.AutoDownLoadLogonFrom_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AutoDownLoadLogonFrom_Paint);
            this.PniInput.ResumeLayout(false);
            this.PniInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButHide;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PniInput;
        private System.Windows.Forms.Button ButLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButCheckPwd;
        private System.Windows.Forms.Button button1;
    }
}