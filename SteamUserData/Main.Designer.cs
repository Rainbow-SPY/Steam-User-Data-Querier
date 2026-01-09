using Rox.Runtimes.Properties;

namespace SteamUserData
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pageHeader1 = new AntdUI.PageHeader();
            this.IInput = new AntdUI.Input();
            this.divider1 = new AntdUI.Divider();
            this.button1 = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.ISteamID64 = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.IUsername = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.IPersonaname = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.IFriendCode = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.ISteamID3 = new AntdUI.Input();
            this.label6 = new AntdUI.Label();
            this.ISteamID = new AntdUI.Input();
            this.label7 = new AntdUI.Label();
            this.ICMGroupID = new AntdUI.Input();
            this.ACMAbout = new AntdUI.Alert();
            this.ASteamCMVisibility = new AntdUI.Alert();
            this.AOnlineStatus = new AntdUI.Alert();
            this.label8 = new AntdUI.Label();
            this.IAccountCreatedStr = new AntdUI.Input();
            this.image3D1 = new AntdUI.Image3D();
            this.SuspendLayout();
            // 
            // pageHeader1
            // 
            this.pageHeader1.DividerShow = true;
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Margin = new System.Windows.Forms.Padding(6);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(1142, 48);
            this.pageHeader1.TabIndex = 32;
            this.pageHeader1.Text = "Steam 公开摘要查询 - v1.6.4.2619";
            // 
            // IInput
            // 
            this.IInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IInput.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.IInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.IInput.BorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IInput.Location = new System.Drawing.Point(317, 58);
            this.IInput.Margin = new System.Windows.Forms.Padding(4);
            this.IInput.Name = "IInput";
            this.IInput.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(100)))), ((int)(((byte)(127)))));
            this.IInput.PlaceholderText = "请输入要查询的SteamID";
            this.IInput.Size = new System.Drawing.Size(512, 51);
            this.IInput.SuffixText = "";
            this.IInput.TabIndex = 33;
            this.IInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // divider1
            // 
            this.divider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider1.BackColor = System.Drawing.Color.Transparent;
            this.divider1.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.divider1.Location = new System.Drawing.Point(0, 104);
            this.divider1.Margin = new System.Windows.Forms.Padding(4);
            this.divider1.Name = "divider1";
            this.divider1.OrientationMargin = 0F;
            this.divider1.Size = new System.Drawing.Size(1154, 34);
            this.divider1.TabIndex = 35;
            this.divider1.Text = "";
            this.divider1.Thickness = 1F;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(861, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 36;
            this.button1.Text = "Go";
            this.button1.Click += new System.EventHandler(this.GetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(33, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "SteamID64";
            // 
            // ISteamID64
            // 
            this.ISteamID64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISteamID64.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ISteamID64.Location = new System.Drawing.Point(186, 158);
            this.ISteamID64.Margin = new System.Windows.Forms.Padding(4);
            this.ISteamID64.Name = "ISteamID64";
            this.ISteamID64.ReadOnly = true;
            this.ISteamID64.Size = new System.Drawing.Size(487, 50);
            this.ISteamID64.TabIndex = 38;
            this.ISteamID64.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(33, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "用户名";
            // 
            // IUsername
            // 
            this.IUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IUsername.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IUsername.Location = new System.Drawing.Point(186, 200);
            this.IUsername.Margin = new System.Windows.Forms.Padding(4);
            this.IUsername.Name = "IUsername";
            this.IUsername.ReadOnly = true;
            this.IUsername.Size = new System.Drawing.Size(487, 50);
            this.IUsername.TabIndex = 38;
            this.IUsername.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // label3
            // 
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(33, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "真实姓名";
            // 
            // IPersonaname
            // 
            this.IPersonaname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPersonaname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPersonaname.Location = new System.Drawing.Point(186, 242);
            this.IPersonaname.Margin = new System.Windows.Forms.Padding(4);
            this.IPersonaname.Name = "IPersonaname";
            this.IPersonaname.ReadOnly = true;
            this.IPersonaname.Size = new System.Drawing.Size(487, 50);
            this.IPersonaname.TabIndex = 38;
            this.IPersonaname.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(33, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "好友代码";
            // 
            // IFriendCode
            // 
            this.IFriendCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IFriendCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IFriendCode.Location = new System.Drawing.Point(186, 284);
            this.IFriendCode.Margin = new System.Windows.Forms.Padding(4);
            this.IFriendCode.Name = "IFriendCode";
            this.IFriendCode.ReadOnly = true;
            this.IFriendCode.Size = new System.Drawing.Size(487, 50);
            this.IFriendCode.TabIndex = 38;
            this.IFriendCode.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // label5
            // 
            this.label5.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(33, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "SteamID3";
            // 
            // ISteamID3
            // 
            this.ISteamID3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISteamID3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ISteamID3.Location = new System.Drawing.Point(186, 326);
            this.ISteamID3.Margin = new System.Windows.Forms.Padding(4);
            this.ISteamID3.Name = "ISteamID3";
            this.ISteamID3.ReadOnly = true;
            this.ISteamID3.Size = new System.Drawing.Size(487, 50);
            this.ISteamID3.TabIndex = 38;
            this.ISteamID3.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // label6
            // 
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(33, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "SteamID";
            // 
            // ISteamID
            // 
            this.ISteamID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISteamID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ISteamID.Location = new System.Drawing.Point(186, 368);
            this.ISteamID.Margin = new System.Windows.Forms.Padding(4);
            this.ISteamID.Name = "ISteamID";
            this.ISteamID.ReadOnly = true;
            this.ISteamID.Size = new System.Drawing.Size(487, 50);
            this.ISteamID.TabIndex = 38;
            this.ISteamID.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // label7
            // 
            this.label7.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.Location = new System.Drawing.Point(33, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 32);
            this.label7.TabIndex = 37;
            this.label7.Text = "主要社区组ID";
            // 
            // ICMGroupID
            // 
            this.ICMGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMGroupID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ICMGroupID.Location = new System.Drawing.Point(186, 410);
            this.ICMGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.ICMGroupID.Name = "ICMGroupID";
            this.ICMGroupID.ReadOnly = true;
            this.ICMGroupID.Size = new System.Drawing.Size(487, 50);
            this.ICMGroupID.TabIndex = 38;
            this.ICMGroupID.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // ACMAbout
            // 
            this.ACMAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ACMAbout.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ACMAbout.Icon = AntdUI.TType.Success;
            this.ACMAbout.Location = new System.Drawing.Point(822, 148);
            this.ACMAbout.Margin = new System.Windows.Forms.Padding(4);
            this.ACMAbout.Name = "ACMAbout";
            this.ACMAbout.Size = new System.Drawing.Size(307, 90);
            this.ACMAbout.TabIndex = 39;
            this.ACMAbout.Text = "已填写";
            this.ACMAbout.TextTitle = "个人资料状态";
            // 
            // ASteamCMVisibility
            // 
            this.ASteamCMVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ASteamCMVisibility.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ASteamCMVisibility.Icon = AntdUI.TType.Success;
            this.ASteamCMVisibility.Location = new System.Drawing.Point(822, 246);
            this.ASteamCMVisibility.Margin = new System.Windows.Forms.Padding(4);
            this.ASteamCMVisibility.Name = "ASteamCMVisibility";
            this.ASteamCMVisibility.Size = new System.Drawing.Size(307, 90);
            this.ASteamCMVisibility.TabIndex = 39;
            this.ASteamCMVisibility.Text = " 可见";
            this.ASteamCMVisibility.TextTitle = "Steam 社区状态";
            // 
            // AOnlineStatus
            // 
            this.AOnlineStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AOnlineStatus.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AOnlineStatus.Icon = AntdUI.TType.Success;
            this.AOnlineStatus.Location = new System.Drawing.Point(822, 344);
            this.AOnlineStatus.Margin = new System.Windows.Forms.Padding(4);
            this.AOnlineStatus.Name = "AOnlineStatus";
            this.AOnlineStatus.Size = new System.Drawing.Size(307, 90);
            this.AOnlineStatus.TabIndex = 39;
            this.AOnlineStatus.Text = "想玩";
            this.AOnlineStatus.TextTitle = "在线状态";
            // 
            // label8
            // 
            this.label8.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(32, 456);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 32);
            this.label8.TabIndex = 37;
            this.label8.Text = "账号创建时间";
            // 
            // IAccountCreatedStr
            // 
            this.IAccountCreatedStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IAccountCreatedStr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IAccountCreatedStr.Location = new System.Drawing.Point(185, 450);
            this.IAccountCreatedStr.Margin = new System.Windows.Forms.Padding(4);
            this.IAccountCreatedStr.Name = "IAccountCreatedStr";
            this.IAccountCreatedStr.ReadOnly = true;
            this.IAccountCreatedStr.Size = new System.Drawing.Size(487, 50);
            this.IAccountCreatedStr.TabIndex = 38;
            this.IAccountCreatedStr.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // image3D1
            // 
            this.image3D1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.image3D1.Image = ((System.Drawing.Image)(resources.GetObject("image3D1.Image")));
            this.image3D1.Location = new System.Drawing.Point(0, 587);
            this.image3D1.Margin = new System.Windows.Forms.Padding(4);
            this.image3D1.Name = "image3D1";
            this.image3D1.Size = new System.Drawing.Size(178, 183);
            this.image3D1.TabIndex = 34;
            this.image3D1.Text = "image3D1";
            this.image3D1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Togawa_Sakiko_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1142, 741);
            this.Controls.Add(this.AOnlineStatus);
            this.Controls.Add(this.ASteamCMVisibility);
            this.Controls.Add(this.ACMAbout);
            this.Controls.Add(this.IAccountCreatedStr);
            this.Controls.Add(this.ICMGroupID);
            this.Controls.Add(this.ISteamID);
            this.Controls.Add(this.ISteamID3);
            this.Controls.Add(this.IFriendCode);
            this.Controls.Add(this.IPersonaname);
            this.Controls.Add(this.IUsername);
            this.Controls.Add(this.ISteamID64);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.image3D1);
            this.Controls.Add(this.IInput);
            this.Controls.Add(this.pageHeader1);
            this.Dark = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1142, 741);
            this.Mode = AntdUI.TAMode.Dark;
            this.Name = "Main";
            this.Text = "Steam 公开摘要查询 - v1.6.4.2619";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private AntdUI.PageHeader pageHeader1;

        #endregion

        private AntdUI.Input IInput;
        private AntdUI.Image3D image3D1;
        private AntdUI.Divider divider1;
        private AntdUI.Button button1;
        private AntdUI.Label label1;
        private AntdUI.Input ISteamID64;
        private AntdUI.Label label2;
        private AntdUI.Input IUsername;
        private AntdUI.Label label3;
        private AntdUI.Input IPersonaname;
        private AntdUI.Label label4;
        private AntdUI.Input IFriendCode;
        private AntdUI.Label label5;
        private AntdUI.Input ISteamID3;
        private AntdUI.Label label6;
        private AntdUI.Input ISteamID;
        private AntdUI.Label label7;
        private AntdUI.Input ICMGroupID;
        private AntdUI.Alert ACMAbout;
        private AntdUI.Alert ASteamCMVisibility;
        private AntdUI.Alert AOnlineStatus;
        private AntdUI.Label label8;
        private AntdUI.Input IAccountCreatedStr;
    }
}