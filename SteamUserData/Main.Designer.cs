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
            this.input1 = new AntdUI.Input();
            this.image3D1 = new AntdUI.Image3D();
            this.divider1 = new AntdUI.Divider();
            this.button1 = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.ISteamID64 = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.IUsername = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.input4 = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.input5 = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.input6 = new AntdUI.Input();
            this.label6 = new AntdUI.Label();
            this.input7 = new AntdUI.Input();
            this.label7 = new AntdUI.Label();
            this.input8 = new AntdUI.Input();
            this.alert1 = new AntdUI.Alert();
            this.alert2 = new AntdUI.Alert();
            this.alert3 = new AntdUI.Alert();
            this.SuspendLayout();
            // 
            // pageHeader1
            // 
            this.pageHeader1.DividerShow = true;
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(781, 32);
            this.pageHeader1.TabIndex = 32;
            this.pageHeader1.Text = "Steam 公开摘要查询 - v1.6.4.2619";
            // 
            // input1
            // 
            this.input1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input1.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.input1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.input1.BorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.input1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input1.Location = new System.Drawing.Point(217, 39);
            this.input1.Name = "input1";
            this.input1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(100)))), ((int)(((byte)(127)))));
            this.input1.PlaceholderText = "请输入要查询的SteamID";
            this.input1.Size = new System.Drawing.Size(341, 34);
            this.input1.SuffixText = "";
            this.input1.TabIndex = 33;
            // 
            // image3D1
            // 
            this.image3D1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.image3D1.Image = ((System.Drawing.Image)(resources.GetObject("image3D1.Image")));
            this.image3D1.Location = new System.Drawing.Point(0, 409);
            this.image3D1.Name = "image3D1";
            this.image3D1.Size = new System.Drawing.Size(119, 122);
            this.image3D1.TabIndex = 34;
            this.image3D1.Text = "image3D1";
            // 
            // divider1
            // 
            this.divider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider1.BackColor = System.Drawing.Color.Transparent;
            this.divider1.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.divider1.Location = new System.Drawing.Point(0, 69);
            this.divider1.Name = "divider1";
            this.divider1.OrientationMargin = 0F;
            this.divider1.Size = new System.Drawing.Size(781, 23);
            this.divider1.TabIndex = 35;
            this.divider1.Text = "";
            this.divider1.Thickness = 1F;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(580, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 34);
            this.button1.TabIndex = 36;
            this.button1.Text = "Go";
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "SteamID64";
            // 
            // ISteamID64
            // 
            this.ISteamID64.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ISteamID64.Location = new System.Drawing.Point(124, 105);
            this.ISteamID64.Name = "ISteamID64";
            this.ISteamID64.Size = new System.Drawing.Size(415, 33);
            this.ISteamID64.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(22, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "用户名";
            // 
            // IUsername
            // 
            this.IUsername.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IUsername.Location = new System.Drawing.Point(124, 133);
            this.IUsername.Name = "IUsername";
            this.IUsername.Size = new System.Drawing.Size(415, 33);
            this.IUsername.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "SteamID64";
            // 
            // input4
            // 
            this.input4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input4.Location = new System.Drawing.Point(124, 161);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(415, 33);
            this.input4.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "SteamID64";
            // 
            // input5
            // 
            this.input5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input5.Location = new System.Drawing.Point(124, 189);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(415, 33);
            this.input5.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(22, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "SteamID64";
            // 
            // input6
            // 
            this.input6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input6.Location = new System.Drawing.Point(124, 217);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(415, 33);
            this.input6.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(22, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "SteamID64";
            // 
            // input7
            // 
            this.input7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input7.Location = new System.Drawing.Point(124, 245);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(415, 33);
            this.input7.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.Location = new System.Drawing.Point(22, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "SteamID64";
            // 
            // input8
            // 
            this.input8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input8.Location = new System.Drawing.Point(124, 273);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(415, 33);
            this.input8.TabIndex = 38;
            // 
            // alert1
            // 
            this.alert1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.alert1.Icon = AntdUI.TType.Success;
            this.alert1.Location = new System.Drawing.Point(571, 109);
            this.alert1.Name = "alert1";
            this.alert1.Size = new System.Drawing.Size(182, 31);
            this.alert1.TabIndex = 39;
            this.alert1.Text = "填写个人资料";
            this.alert1.TextTitle = "";
            // 
            // alert2
            // 
            this.alert2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.alert2.Icon = AntdUI.TType.Warn;
            this.alert2.Location = new System.Drawing.Point(571, 146);
            this.alert2.Name = "alert2";
            this.alert2.Size = new System.Drawing.Size(182, 31);
            this.alert2.TabIndex = 39;
            this.alert2.Text = "Steam 社区状态 可见";
            this.alert2.TextTitle = "";
            // 
            // alert3
            // 
            this.alert3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.alert3.Icon = AntdUI.TType.Success;
            this.alert3.Location = new System.Drawing.Point(571, 183);
            this.alert3.Name = "alert3";
            this.alert3.Size = new System.Drawing.Size(182, 60);
            this.alert3.TabIndex = 39;
            this.alert3.Text = "想玩";
            this.alert3.TextTitle = "在线状态";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(781, 531);
            this.Controls.Add(this.alert3);
            this.Controls.Add(this.alert2);
            this.Controls.Add(this.alert1);
            this.Controls.Add(this.input8);
            this.Controls.Add(this.input7);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.IUsername);
            this.Controls.Add(this.ISteamID64);
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
            this.Controls.Add(this.input1);
            this.Controls.Add(this.pageHeader1);
            this.Dark = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Mode = AntdUI.TAMode.Dark;
            this.Name = "Main";
            this.Text = "Steam 公开摘要查询 - v1.6.4.2619";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private AntdUI.PageHeader pageHeader1;

        #endregion

        private AntdUI.Input input1;
        private AntdUI.Image3D image3D1;
        private AntdUI.Divider divider1;
        private AntdUI.Button button1;
        private AntdUI.Label label1;
        private AntdUI.Input ISteamID64;
        private AntdUI.Label label2;
        private AntdUI.Input IUsername;
        private AntdUI.Label label3;
        private AntdUI.Input input4;
        private AntdUI.Label label4;
        private AntdUI.Input input5;
        private AntdUI.Label label5;
        private AntdUI.Input input6;
        private AntdUI.Label label6;
        private AntdUI.Input input7;
        private AntdUI.Label label7;
        private AntdUI.Input input8;
        private AntdUI.Alert alert1;
        private AntdUI.Alert alert2;
        private AntdUI.Alert alert3;
    }
}