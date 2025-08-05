namespace SteamUserData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Tinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TsteamID64 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TsteamID3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TprofileVisable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TcommunityLook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TrealName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Turl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tavator = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TacCreateTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TRegistryRegoin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Tnow = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TfriendCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TmainGroup = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TsteamID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BcommunityGroup = new System.Windows.Forms.Button();
            this.btnToggleConsole = new System.Windows.Forms.Button();
            this.ThookGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steam 个人数据查询";
            // 
            // Tinput
            // 
            this.Tinput.BackColor = System.Drawing.Color.Thistle;
            this.Tinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tinput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tinput.HideSelection = false;
            this.Tinput.Location = new System.Drawing.Point(171, 119);
            this.Tinput.Name = "Tinput";
            this.Tinput.Size = new System.Drawing.Size(238, 26);
            this.Tinput.TabIndex = 1;
            this.Tinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(351, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Tusername
            // 
            this.Tusername.BackColor = System.Drawing.Color.Thistle;
            this.Tusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tusername.Enabled = false;
            this.Tusername.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tusername.HideSelection = false;
            this.Tusername.Location = new System.Drawing.Point(171, 172);
            this.Tusername.Name = "Tusername";
            this.Tusername.ReadOnly = true;
            this.Tusername.Size = new System.Drawing.Size(238, 26);
            this.Tusername.TabIndex = 1;
            this.Tusername.WordWrap = false;
            this.Tusername.DoubleClick += new System.EventHandler(this.TDC_username);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名";
            // 
            // TsteamID64
            // 
            this.TsteamID64.BackColor = System.Drawing.Color.Thistle;
            this.TsteamID64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TsteamID64.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TsteamID64.Enabled = false;
            this.TsteamID64.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsteamID64.HideSelection = false;
            this.TsteamID64.Location = new System.Drawing.Point(171, 386);
            this.TsteamID64.Name = "TsteamID64";
            this.TsteamID64.ReadOnly = true;
            this.TsteamID64.Size = new System.Drawing.Size(238, 26);
            this.TsteamID64.TabIndex = 1;
            this.TsteamID64.WordWrap = false;
            this.TsteamID64.DoubleClick += new System.EventHandler(this.TDC_steamID64);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "SteamID64";
            // 
            // TsteamID3
            // 
            this.TsteamID3.BackColor = System.Drawing.Color.Thistle;
            this.TsteamID3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TsteamID3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TsteamID3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsteamID3.HideSelection = false;
            this.TsteamID3.Location = new System.Drawing.Point(171, 354);
            this.TsteamID3.Name = "TsteamID3";
            this.TsteamID3.ReadOnly = true;
            this.TsteamID3.Size = new System.Drawing.Size(238, 26);
            this.TsteamID3.TabIndex = 1;
            this.TsteamID3.WordWrap = false;
            this.TsteamID3.DoubleClick += new System.EventHandler(this.TDC_steamID3);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "SteamID3";
            // 
            // TprofileVisable
            // 
            this.TprofileVisable.BackColor = System.Drawing.Color.Thistle;
            this.TprofileVisable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TprofileVisable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TprofileVisable.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TprofileVisable.HideSelection = false;
            this.TprofileVisable.Location = new System.Drawing.Point(171, 204);
            this.TprofileVisable.Name = "TprofileVisable";
            this.TprofileVisable.ReadOnly = true;
            this.TprofileVisable.Size = new System.Drawing.Size(128, 26);
            this.TprofileVisable.TabIndex = 1;
            this.TprofileVisable.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(28, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "个人资料可见性";
            // 
            // TcommunityLook
            // 
            this.TcommunityLook.BackColor = System.Drawing.Color.Thistle;
            this.TcommunityLook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TcommunityLook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TcommunityLook.Enabled = false;
            this.TcommunityLook.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TcommunityLook.HideSelection = false;
            this.TcommunityLook.Location = new System.Drawing.Point(171, 546);
            this.TcommunityLook.Name = "TcommunityLook";
            this.TcommunityLook.ReadOnly = true;
            this.TcommunityLook.Size = new System.Drawing.Size(128, 26);
            this.TcommunityLook.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "社区查看权限";
            // 
            // TrealName
            // 
            this.TrealName.BackColor = System.Drawing.Color.Thistle;
            this.TrealName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrealName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TrealName.Enabled = false;
            this.TrealName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TrealName.HideSelection = false;
            this.TrealName.Location = new System.Drawing.Point(171, 418);
            this.TrealName.Name = "TrealName";
            this.TrealName.ReadOnly = true;
            this.TrealName.Size = new System.Drawing.Size(238, 26);
            this.TrealName.TabIndex = 1;
            this.TrealName.WordWrap = false;
            this.TrealName.DoubleClick += new System.EventHandler(this.TDC_realName);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(28, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "真实姓名";
            // 
            // Turl
            // 
            this.Turl.BackColor = System.Drawing.Color.Thistle;
            this.Turl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Turl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Turl.Enabled = false;
            this.Turl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Turl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Turl.HideSelection = false;
            this.Turl.Location = new System.Drawing.Point(171, 450);
            this.Turl.Name = "Turl";
            this.Turl.ReadOnly = true;
            this.Turl.Size = new System.Drawing.Size(238, 26);
            this.Turl.TabIndex = 1;
            this.Turl.WordWrap = false;
            this.Turl.Click += new System.EventHandler(this.Turl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(28, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "社区主页地址";
            // 
            // Tavator
            // 
            this.Tavator.BackColor = System.Drawing.Color.Thistle;
            this.Tavator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tavator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tavator.Enabled = false;
            this.Tavator.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tavator.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Tavator.HideSelection = false;
            this.Tavator.Location = new System.Drawing.Point(171, 482);
            this.Tavator.Name = "Tavator";
            this.Tavator.ReadOnly = true;
            this.Tavator.Size = new System.Drawing.Size(238, 26);
            this.Tavator.TabIndex = 1;
            this.Tavator.WordWrap = false;
            this.Tavator.Click += new System.EventHandler(this.Tavator_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(28, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "头像地址";
            // 
            // TacCreateTime
            // 
            this.TacCreateTime.BackColor = System.Drawing.Color.Thistle;
            this.TacCreateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TacCreateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TacCreateTime.Enabled = false;
            this.TacCreateTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TacCreateTime.HideSelection = false;
            this.TacCreateTime.Location = new System.Drawing.Point(171, 514);
            this.TacCreateTime.Name = "TacCreateTime";
            this.TacCreateTime.ReadOnly = true;
            this.TacCreateTime.Size = new System.Drawing.Size(238, 26);
            this.TacCreateTime.TabIndex = 1;
            this.TacCreateTime.WordWrap = false;
            this.TacCreateTime.DoubleClick += new System.EventHandler(this.TDC_acCreateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(28, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "账号创建日期";
            // 
            // TRegistryRegoin
            // 
            this.TRegistryRegoin.BackColor = System.Drawing.Color.Thistle;
            this.TRegistryRegoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TRegistryRegoin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TRegistryRegoin.Enabled = false;
            this.TRegistryRegoin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TRegistryRegoin.HideSelection = false;
            this.TRegistryRegoin.Location = new System.Drawing.Point(171, 578);
            this.TRegistryRegoin.Name = "TRegistryRegoin";
            this.TRegistryRegoin.ReadOnly = true;
            this.TRegistryRegoin.Size = new System.Drawing.Size(128, 26);
            this.TRegistryRegoin.TabIndex = 1;
            this.TRegistryRegoin.WordWrap = false;
            this.TRegistryRegoin.DoubleClick += new System.EventHandler(this.TDC_RegistryRegoin);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(28, 578);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "注册地区";
            // 
            // Tnow
            // 
            this.Tnow.BackColor = System.Drawing.Color.Thistle;
            this.Tnow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tnow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tnow.Enabled = false;
            this.Tnow.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tnow.HideSelection = false;
            this.Tnow.Location = new System.Drawing.Point(171, 610);
            this.Tnow.Name = "Tnow";
            this.Tnow.ReadOnly = true;
            this.Tnow.Size = new System.Drawing.Size(128, 26);
            this.Tnow.TabIndex = 1;
            this.Tnow.WordWrap = false;
            this.Tnow.DoubleClick += new System.EventHandler(this.TDC_now);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(28, 610);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "当前状态";
            // 
            // TfriendCode
            // 
            this.TfriendCode.BackColor = System.Drawing.Color.Thistle;
            this.TfriendCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TfriendCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TfriendCode.Enabled = false;
            this.TfriendCode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TfriendCode.HideSelection = false;
            this.TfriendCode.Location = new System.Drawing.Point(171, 642);
            this.TfriendCode.Name = "TfriendCode";
            this.TfriendCode.ReadOnly = true;
            this.TfriendCode.Size = new System.Drawing.Size(128, 26);
            this.TfriendCode.TabIndex = 1;
            this.TfriendCode.WordWrap = false;
            this.TfriendCode.DoubleClick += new System.EventHandler(this.TDC_friendCode);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(28, 642);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "好友代码";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(27, 684);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "保存为文档";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(254, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "提示: 双击文本框可以复制内容";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(243, 684);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "查看头像";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(139, 684);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "查看主页";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.LimeGreen;
            this.label17.Location = new System.Drawing.Point(167, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 21);
            this.label17.TabIndex = 6;
            this.label17.Text = "提示: 按下回车查询";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 17F);
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(26, 737);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(215, 30);
            this.label18.TabIndex = 7;
            this.label18.Text = "正在查询中...请稍等";
            this.label18.Visible = false;
            // 
            // TmainGroup
            // 
            this.TmainGroup.BackColor = System.Drawing.Color.Thistle;
            this.TmainGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TmainGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TmainGroup.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TmainGroup.HideSelection = false;
            this.TmainGroup.Location = new System.Drawing.Point(171, 236);
            this.TmainGroup.Name = "TmainGroup";
            this.TmainGroup.ReadOnly = true;
            this.TmainGroup.Size = new System.Drawing.Size(238, 26);
            this.TmainGroup.TabIndex = 1;
            this.TmainGroup.WordWrap = false;
            this.TmainGroup.DoubleClick += new System.EventHandler(this.TDC_mailGroup);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(28, 236);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "主要社区组ID";
            // 
            // TsteamID
            // 
            this.TsteamID.BackColor = System.Drawing.Color.Thistle;
            this.TsteamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TsteamID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TsteamID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsteamID.HideSelection = false;
            this.TsteamID.Location = new System.Drawing.Point(171, 322);
            this.TsteamID.Name = "TsteamID";
            this.TsteamID.ReadOnly = true;
            this.TsteamID.Size = new System.Drawing.Size(238, 26);
            this.TsteamID.TabIndex = 1;
            this.TsteamID.WordWrap = false;
            this.TsteamID.DoubleClick += new System.EventHandler(this.TDC_steamID);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(28, 322);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 21);
            this.label20.TabIndex = 2;
            this.label20.Text = "SteamID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(469, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "请输入SteamID3、ID64、好友代码、自定义URL、个人主页链接";
            // 
            // BcommunityGroup
            // 
            this.BcommunityGroup.BackColor = System.Drawing.Color.Transparent;
            this.BcommunityGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BcommunityGroup.Enabled = false;
            this.BcommunityGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BcommunityGroup.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.BcommunityGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BcommunityGroup.Location = new System.Drawing.Point(351, 724);
            this.BcommunityGroup.Name = "BcommunityGroup";
            this.BcommunityGroup.Size = new System.Drawing.Size(102, 34);
            this.BcommunityGroup.TabIndex = 3;
            this.BcommunityGroup.Text = "查看社区组";
            this.BcommunityGroup.UseVisualStyleBackColor = false;
            this.BcommunityGroup.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnToggleConsole
            // 
            this.btnToggleConsole.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToggleConsole.FlatAppearance.BorderSize = 0;
            this.btnToggleConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnToggleConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnToggleConsole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleConsole.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnToggleConsole.ForeColor = System.Drawing.Color.Transparent;
            this.btnToggleConsole.Location = new System.Drawing.Point(351, 12);
            this.btnToggleConsole.Name = "btnToggleConsole";
            this.btnToggleConsole.Size = new System.Drawing.Size(130, 42);
            this.btnToggleConsole.TabIndex = 8;
            this.btnToggleConsole.Text = "显示控制台";
            this.btnToggleConsole.UseVisualStyleBackColor = false;
            this.btnToggleConsole.Click += new System.EventHandler(this.BtnToggleConsole_Click);
            // 
            // ThookGroup
            // 
            this.ThookGroup.BackColor = System.Drawing.Color.Thistle;
            this.ThookGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThookGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThookGroup.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThookGroup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ThookGroup.HideSelection = false;
            this.ThookGroup.Location = new System.Drawing.Point(171, 268);
            this.ThookGroup.Name = "ThookGroup";
            this.ThookGroup.ReadOnly = true;
            this.ThookGroup.Size = new System.Drawing.Size(238, 26);
            this.ThookGroup.TabIndex = 1;
            this.ThookGroup.WordWrap = false;
            this.ThookGroup.Click += new System.EventHandler(this.TcommunityGroup_Click);
            this.ThookGroup.DoubleClick += new System.EventHandler(this.TDC_mailGroup);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "识别的社区组";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label21.Enabled = false;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(12, 297);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(477, 21);
            this.label21.TabIndex = 2;
            this.label21.Text = "该功能需要系统代理 Steam 社区, 单击文字可尝试使用浏览器访问";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(490, 781);
            this.Controls.Add(this.btnToggleConsole);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BcommunityGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ThookGroup);
            this.Controls.Add(this.TmainGroup);
            this.Controls.Add(this.TprofileVisable);
            this.Controls.Add(this.TsteamID);
            this.Controls.Add(this.TsteamID3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TfriendCode);
            this.Controls.Add(this.Tnow);
            this.Controls.Add(this.TRegistryRegoin);
            this.Controls.Add(this.TacCreateTime);
            this.Controls.Add(this.Tavator);
            this.Controls.Add(this.Turl);
            this.Controls.Add(this.TrealName);
            this.Controls.Add(this.TcommunityLook);
            this.Controls.Add(this.TsteamID64);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tusername);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Tinput);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(506, 820);
            this.MinimumSize = new System.Drawing.Size(506, 820);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam 个人数据查询 by Rainbow SPY -  v1.3.0.25804";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TsteamID64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TsteamID3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TprofileVisable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TcommunityLook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TrealName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Turl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tavator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TacCreateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TRegistryRegoin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Tnow;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TfriendCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TmainGroup;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TsteamID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BcommunityGroup;
        private System.Windows.Forms.Button btnToggleConsole;
        private System.Windows.Forms.TextBox ThookGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
    }
}

