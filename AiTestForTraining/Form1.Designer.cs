namespace AiTestForTraining
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConnectString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSentimentInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSentimentOutput = new System.Windows.Forms.TextBox();
            this.btnSentimentSingle = new System.Windows.Forms.Button();
            this.btnSentimentBatch = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labBatchCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labinfo = new System.Windows.Forms.LinkLabel();
            this.labInfoWarning = new System.Windows.Forms.LinkLabel();
            this.txtOverLoad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labInfoWarning);
            this.tabPage1.Controls.Add(this.labinfo);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.labBatchCount);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btnSentimentBatch);
            this.tabPage1.Controls.Add(this.btnSentimentSingle);
            this.tabPage1.Controls.Add(this.txtSentimentOutput);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtSentimentInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "情感倾向分析";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "测试语";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtOverLoad);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnSaveSettings);
            this.tabPage2.Controls.Add(this.txtColumn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtTable);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtConnectString);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtSecretKey);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtAppKey);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(107, 178);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(153, 27);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(107, 125);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(297, 21);
            this.txtColumn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "TextColumn";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(107, 98);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(297, 21);
            this.txtTable.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "TextTable";
            // 
            // txtConnectString
            // 
            this.txtConnectString.Location = new System.Drawing.Point(107, 71);
            this.txtConnectString.Name = "txtConnectString";
            this.txtConnectString.Size = new System.Drawing.Size(297, 21);
            this.txtConnectString.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ConnectString";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(107, 44);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(297, 21);
            this.txtSecretKey.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "SecretKey";
            // 
            // txtAppKey
            // 
            this.txtAppKey.Location = new System.Drawing.Point(107, 17);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.Size = new System.Drawing.Size(297, 21);
            this.txtAppKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "AppKey";
            // 
            // txtSentimentInput
            // 
            this.txtSentimentInput.Location = new System.Drawing.Point(77, 7);
            this.txtSentimentInput.Multiline = true;
            this.txtSentimentInput.Name = "txtSentimentInput";
            this.txtSentimentInput.Size = new System.Drawing.Size(532, 127);
            this.txtSentimentInput.TabIndex = 1;
            this.txtSentimentInput.Text = "欢迎光临，我是贴心的智能助理虎妞，客服哥哥姐姐们都在忙碌接待中，为了减少亲的等待，将由我来先为亲服务！到店安装怎么弄呢?有什么活动吗轮毂适合我的车选择哪种有没有货" +
    "在的呢，有什么可以帮您的吗？ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "测试结果";
            // 
            // txtSentimentOutput
            // 
            this.txtSentimentOutput.Location = new System.Drawing.Point(77, 150);
            this.txtSentimentOutput.Multiline = true;
            this.txtSentimentOutput.Name = "txtSentimentOutput";
            this.txtSentimentOutput.Size = new System.Drawing.Size(532, 127);
            this.txtSentimentOutput.TabIndex = 1;
            // 
            // btnSentimentSingle
            // 
            this.btnSentimentSingle.Location = new System.Drawing.Point(77, 332);
            this.btnSentimentSingle.Name = "btnSentimentSingle";
            this.btnSentimentSingle.Size = new System.Drawing.Size(154, 48);
            this.btnSentimentSingle.TabIndex = 2;
            this.btnSentimentSingle.Text = "单句测试";
            this.btnSentimentSingle.UseVisualStyleBackColor = true;
            this.btnSentimentSingle.Click += new System.EventHandler(this.btnSentimentSingle_Click);
            // 
            // btnSentimentBatch
            // 
            this.btnSentimentBatch.Location = new System.Drawing.Point(468, 332);
            this.btnSentimentBatch.Name = "btnSentimentBatch";
            this.btnSentimentBatch.Size = new System.Drawing.Size(141, 48);
            this.btnSentimentBatch.TabIndex = 2;
            this.btnSentimentBatch.Text = "批量测试（根据指定的数据库批量分析）";
            this.btnSentimentBatch.UseVisualStyleBackColor = true;
            this.btnSentimentBatch.Click += new System.EventHandler(this.btnSentimentBatch_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(145, 290);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(437, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AiTestForTraining.Properties.Resources.微信图片_20180221163013;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 79);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AiTestForTraining.Properties.Resources.微信图片_20180221163034;
            this.pictureBox2.Location = new System.Drawing.Point(584, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 76);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // labBatchCount
            // 
            this.labBatchCount.AutoSize = true;
            this.labBatchCount.Location = new System.Drawing.Point(519, 383);
            this.labBatchCount.Name = "labBatchCount";
            this.labBatchCount.Size = new System.Drawing.Size(0, 12);
            this.labBatchCount.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "已批量处理：";
            // 
            // labinfo
            // 
            this.labinfo.AutoSize = true;
            this.labinfo.Location = new System.Drawing.Point(639, 367);
            this.labinfo.Name = "labinfo";
            this.labinfo.Size = new System.Drawing.Size(77, 12);
            this.labinfo.TabIndex = 8;
            this.labinfo.TabStop = true;
            this.labinfo.Text = "批量处理结果";
            this.labinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labinfo_LinkClicked);
            // 
            // labInfoWarning
            // 
            this.labInfoWarning.AutoSize = true;
            this.labInfoWarning.Location = new System.Drawing.Point(639, 395);
            this.labInfoWarning.Name = "labInfoWarning";
            this.labInfoWarning.Size = new System.Drawing.Size(65, 12);
            this.labInfoWarning.TabIndex = 8;
            this.labInfoWarning.TabStop = true;
            this.labInfoWarning.Text = "超限的结果";
            this.labInfoWarning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labInfoWarning_LinkClicked);
            // 
            // txtOverLoad
            // 
            this.txtOverLoad.Location = new System.Drawing.Point(107, 151);
            this.txtOverLoad.Name = "txtOverLoad";
            this.txtOverLoad.Size = new System.Drawing.Size(297, 21);
            this.txtOverLoad.TabIndex = 4;
            this.txtOverLoad.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "情感超限阈值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "NLP测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConnectString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSentimentBatch;
        private System.Windows.Forms.Button btnSentimentSingle;
        private System.Windows.Forms.TextBox txtSentimentOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSentimentInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labBatchCount;
        private System.Windows.Forms.LinkLabel labInfoWarning;
        private System.Windows.Forms.LinkLabel labinfo;
        private System.Windows.Forms.TextBox txtOverLoad;
        private System.Windows.Forms.Label label9;
    }
}

