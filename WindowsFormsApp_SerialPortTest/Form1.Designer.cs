namespace WindowsFormsApp_SerialPortTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenCOM = new System.Windows.Forms.Button();
            this.btnCheckCOM = new System.Windows.Forms.Button();
            this.rbnHex = new System.Windows.Forms.RadioButton();
            this.rbnChar = new System.Windows.Forms.RadioButton();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRecvData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCleanData = new System.Windows.Forms.Button();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PC3_1 = new System.Windows.Forms.Label();
            this.PC2_0 = new System.Windows.Forms.Label();
            this.PC2_1 = new System.Windows.Forms.Label();
            this.PC3_0 = new System.Windows.Forms.Label();
            this.PC1_1 = new System.Windows.Forms.Label();
            this.PC1_0 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PC0_1 = new System.Windows.Forms.Label();
            this.PC0_0 = new System.Windows.Forms.Label();
            this.ModelShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnOpenCOM);
            this.groupBox1.Controls.Add(this.btnCheckCOM);
            this.groupBox1.Controls.Add(this.rbnHex);
            this.groupBox1.Controls.Add(this.rbnChar);
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.cbxCOMPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 87);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenCOM
            // 
            this.btnOpenCOM.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCOM.Location = new System.Drawing.Point(527, 42);
            this.btnOpenCOM.Name = "btnOpenCOM";
            this.btnOpenCOM.Size = new System.Drawing.Size(80, 30);
            this.btnOpenCOM.TabIndex = 13;
            this.btnOpenCOM.Text = "open";
            this.btnOpenCOM.UseVisualStyleBackColor = true;
            this.btnOpenCOM.Click += new System.EventHandler(this.btnOpenCOM_Click_1);
            // 
            // btnCheckCOM
            // 
            this.btnCheckCOM.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckCOM.Location = new System.Drawing.Point(422, 42);
            this.btnCheckCOM.Name = "btnCheckCOM";
            this.btnCheckCOM.Size = new System.Drawing.Size(80, 30);
            this.btnCheckCOM.TabIndex = 12;
            this.btnCheckCOM.Text = "test";
            this.btnCheckCOM.UseVisualStyleBackColor = true;
            this.btnCheckCOM.Click += new System.EventHandler(this.btnCheckCOM_Click_1);
            // 
            // rbnHex
            // 
            this.rbnHex.AutoSize = true;
            this.rbnHex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbnHex.Location = new System.Drawing.Point(316, 139);
            this.rbnHex.Name = "rbnHex";
            this.rbnHex.Size = new System.Drawing.Size(89, 24);
            this.rbnHex.TabIndex = 11;
            this.rbnHex.Text = "Hex显示";
            this.rbnHex.UseVisualStyleBackColor = true;
            // 
            // rbnChar
            // 
            this.rbnChar.AutoSize = true;
            this.rbnChar.Checked = true;
            this.rbnChar.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbnChar.Location = new System.Drawing.Point(220, 139);
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.Size = new System.Drawing.Size(90, 24);
            this.rbnChar.TabIndex = 10;
            this.rbnChar.TabStop = true;
            this.rbnChar.Text = "字符显示";
            this.rbnChar.UseVisualStyleBackColor = true;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(290, 88);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(100, 33);
            this.cbxDataBits.TabIndex = 9;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(290, 36);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(100, 33);
            this.cbxParity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "校验位";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(83, 135);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(100, 33);
            this.cbxStopBits.TabIndex = 5;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(83, 88);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(100, 33);
            this.cbxBaudRate.TabIndex = 4;
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(83, 39);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(100, 33);
            this.cbxCOMPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(6, 39);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(69, 26);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "串口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxRecvData);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(636, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收";
            // 
            // tbxRecvData
            // 
            this.tbxRecvData.BackColor = System.Drawing.SystemColors.Window;
            this.tbxRecvData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxRecvData.Location = new System.Drawing.Point(14, 30);
            this.tbxRecvData.Multiline = true;
            this.tbxRecvData.Name = "tbxRecvData";
            this.tbxRecvData.ReadOnly = true;
            this.tbxRecvData.Size = new System.Drawing.Size(400, 280);
            this.tbxRecvData.TabIndex = 0;
            this.tbxRecvData.TextChanged += new System.EventHandler(this.tbxRecvData_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.btnCleanData);
            this.groupBox3.Controls.Add(this.tbxSendData);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(636, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(333, 149);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // btnCleanData
            // 
            this.btnCleanData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCleanData.Location = new System.Drawing.Point(14, 149);
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.Size = new System.Drawing.Size(80, 30);
            this.btnCleanData.TabIndex = 1;
            this.btnCleanData.Text = "clear";
            this.btnCleanData.UseVisualStyleBackColor = true;
            this.btnCleanData.Click += new System.EventHandler(this.btnCleanData_Click_1);
            // 
            // tbxSendData
            // 
            this.tbxSendData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSendData.Location = new System.Drawing.Point(14, 31);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.Size = new System.Drawing.Size(399, 112);
            this.tbxSendData.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ModelShow);
            this.groupBox4.Controls.Add(this.PC3_1);
            this.groupBox4.Controls.Add(this.PC2_0);
            this.groupBox4.Controls.Add(this.PC2_1);
            this.groupBox4.Controls.Add(this.PC3_0);
            this.groupBox4.Controls.Add(this.PC1_1);
            this.groupBox4.Controls.Add(this.PC1_0);
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.PC0_1);
            this.groupBox4.Controls.Add(this.PC0_0);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(13, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(612, 529);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "模型展示";
            // 
            // PC3_1
            // 
            this.PC3_1.AutoSize = true;
            this.PC3_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC3_1.Location = new System.Drawing.Point(327, 414);
            this.PC3_1.Name = "PC3_1";
            this.PC3_1.Size = new System.Drawing.Size(61, 20);
            this.PC3_1.TabIndex = 11;
            this.PC3_1.Text = "Passive";
            // 
            // PC2_0
            // 
            this.PC2_0.AutoSize = true;
            this.PC2_0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC2_0.Location = new System.Drawing.Point(58, 391);
            this.PC2_0.Name = "PC2_0";
            this.PC2_0.Size = new System.Drawing.Size(47, 20);
            this.PC2_0.TabIndex = 10;
            this.PC2_0.Text = "Slave";
            // 
            // PC2_1
            // 
            this.PC2_1.AutoSize = true;
            this.PC2_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC2_1.Location = new System.Drawing.Point(146, 414);
            this.PC2_1.Name = "PC2_1";
            this.PC2_1.Size = new System.Drawing.Size(47, 20);
            this.PC2_1.TabIndex = 9;
            this.PC2_1.Text = "Slave";
            // 
            // PC3_0
            // 
            this.PC3_0.AutoSize = true;
            this.PC3_0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC3_0.Location = new System.Drawing.Point(407, 391);
            this.PC3_0.Name = "PC3_0";
            this.PC3_0.Size = new System.Drawing.Size(47, 20);
            this.PC3_0.TabIndex = 8;
            this.PC3_0.Text = "Slave";
            // 
            // PC1_1
            // 
            this.PC1_1.AutoSize = true;
            this.PC1_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC1_1.Location = new System.Drawing.Point(407, 186);
            this.PC1_1.Name = "PC1_1";
            this.PC1_1.Size = new System.Drawing.Size(47, 20);
            this.PC1_1.TabIndex = 7;
            this.PC1_1.Text = "Slave";
            // 
            // PC1_0
            // 
            this.PC1_0.AutoSize = true;
            this.PC1_0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC1_0.Location = new System.Drawing.Point(341, 100);
            this.PC1_0.Name = "PC1_0";
            this.PC1_0.Size = new System.Drawing.Size(47, 20);
            this.PC1_0.TabIndex = 6;
            this.PC1_0.Text = "Slave";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(394, 414);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 72);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(47, 414);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 72);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(394, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 72);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 81);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PC0_1
            // 
            this.PC0_1.AutoSize = true;
            this.PC0_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC0_1.Location = new System.Drawing.Point(58, 186);
            this.PC0_1.Name = "PC0_1";
            this.PC0_1.Size = new System.Drawing.Size(60, 20);
            this.PC0_1.TabIndex = 1;
            this.PC0_1.Text = "Master";
            // 
            // PC0_0
            // 
            this.PC0_0.AutoSize = true;
            this.PC0_0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PC0_0.Location = new System.Drawing.Point(146, 100);
            this.PC0_0.Name = "PC0_0";
            this.PC0_0.Size = new System.Drawing.Size(60, 20);
            this.PC0_0.TabIndex = 0;
            this.PC0_0.Text = "Master";
            // 
            // ModelShow
            // 
            this.ModelShow.Location = new System.Drawing.Point(221, 30);
            this.ModelShow.Name = "ModelShow";
            this.ModelShow.Size = new System.Drawing.Size(89, 35);
            this.ModelShow.TabIndex = 12;
            this.ModelShow.Text = "Show";
            this.ModelShow.UseVisualStyleBackColor = true;
            this.ModelShow.Click += new System.EventHandler(this.ModelShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 750);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "FiberHome火星人";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenCOM;
        private System.Windows.Forms.Button btnCheckCOM;
        private System.Windows.Forms.RadioButton rbnHex;
        private System.Windows.Forms.RadioButton rbnChar;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRecvData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCleanData;
        private System.Windows.Forms.TextBox tbxSendData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PC0_1;
        private System.Windows.Forms.Label PC0_0;
        private System.Windows.Forms.Label PC3_1;
        private System.Windows.Forms.Label PC2_0;
        private System.Windows.Forms.Label PC2_1;
        private System.Windows.Forms.Label PC3_0;
        private System.Windows.Forms.Label PC1_1;
        private System.Windows.Forms.Label PC1_0;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ModelShow;
    }
}

