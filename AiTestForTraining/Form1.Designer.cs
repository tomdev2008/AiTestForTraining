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
            this.labInfoWarning = new System.Windows.Forms.LinkLabel();
            this.labinfo = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.labBatchCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSentimentBatch = new System.Windows.Forms.Button();
            this.btnSentimentSingle = new System.Windows.Forms.Button();
            this.txtSentimentOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSentimentInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.labCountTopic = new System.Windows.Forms.Label();
            this.btnTopicBatch = new System.Windows.Forms.Button();
            this.btnTopicSingle = new System.Windows.Forms.Button();
            this.txtTopicResult = new System.Windows.Forms.TextBox();
            this.labCatch = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTestTopic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtCarResult = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCar = new System.Windows.Forms.Button();
            this.imgCar = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTestTik = new System.Windows.Forms.TextBox();
            this.txtTopicLimit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOverLoad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            // labInfoWarning
            // 
            this.labInfoWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labInfoWarning.AutoSize = true;
            this.labInfoWarning.Location = new System.Drawing.Point(639, 395);
            this.labInfoWarning.Name = "labInfoWarning";
            this.labInfoWarning.Size = new System.Drawing.Size(65, 12);
            this.labInfoWarning.TabIndex = 8;
            this.labInfoWarning.TabStop = true;
            this.labInfoWarning.Text = "超限的结果";
            this.labInfoWarning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labInfoWarning_LinkClicked);
            // 
            // labinfo
            // 
            this.labinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labinfo.AutoSize = true;
            this.labinfo.Location = new System.Drawing.Point(639, 367);
            this.labinfo.Name = "labinfo";
            this.labinfo.Size = new System.Drawing.Size(77, 12);
            this.labinfo.TabIndex = 8;
            this.labinfo.TabStop = true;
            this.labinfo.Text = "批量处理结果";
            this.labinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labinfo_LinkClicked);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "已批量处理：";
            // 
            // labBatchCount
            // 
            this.labBatchCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labBatchCount.AutoSize = true;
            this.labBatchCount.Location = new System.Drawing.Point(519, 383);
            this.labBatchCount.Name = "labBatchCount";
            this.labBatchCount.Size = new System.Drawing.Size(0, 12);
            this.labBatchCount.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(145, 290);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(437, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 50;
            // 
            // btnSentimentBatch
            // 
            this.btnSentimentBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSentimentBatch.Location = new System.Drawing.Point(468, 332);
            this.btnSentimentBatch.Name = "btnSentimentBatch";
            this.btnSentimentBatch.Size = new System.Drawing.Size(141, 48);
            this.btnSentimentBatch.TabIndex = 2;
            this.btnSentimentBatch.Text = "批量测试（根据指定的数据库批量分析）";
            this.btnSentimentBatch.UseVisualStyleBackColor = true;
            this.btnSentimentBatch.Click += new System.EventHandler(this.btnSentimentBatch_Click);
            // 
            // btnSentimentSingle
            // 
            this.btnSentimentSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSentimentSingle.Location = new System.Drawing.Point(77, 332);
            this.btnSentimentSingle.Name = "btnSentimentSingle";
            this.btnSentimentSingle.Size = new System.Drawing.Size(154, 48);
            this.btnSentimentSingle.TabIndex = 2;
            this.btnSentimentSingle.Text = "单句测试";
            this.btnSentimentSingle.UseVisualStyleBackColor = true;
            this.btnSentimentSingle.Click += new System.EventHandler(this.btnSentimentSingle_Click);
            // 
            // txtSentimentOutput
            // 
            this.txtSentimentOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSentimentOutput.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.txtSentimentOutput.Location = new System.Drawing.Point(77, 150);
            this.txtSentimentOutput.Multiline = true;
            this.txtSentimentOutput.Name = "txtSentimentOutput";
            this.txtSentimentOutput.Size = new System.Drawing.Size(532, 127);
            this.txtSentimentOutput.TabIndex = 1;
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
            // txtSentimentInput
            // 
            this.txtSentimentInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSentimentInput.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSentimentInput.Location = new System.Drawing.Point(77, 7);
            this.txtSentimentInput.Multiline = true;
            this.txtSentimentInput.Name = "txtSentimentInput";
            this.txtSentimentInput.Size = new System.Drawing.Size(532, 127);
            this.txtSentimentInput.TabIndex = 1;
            this.txtSentimentInput.Text = "欢迎光临，我是贴心的智能助理虎妞，客服哥哥姐姐们都在忙碌接待中，为了减少亲的等待，将由我来先为亲服务！到店安装怎么弄呢?有什么活动吗轮毂适合我的车选择哪种有没有货" +
    "在的呢，有什么可以帮您的吗？ ";
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::AiTestForTraining.Properties.Resources.微信图片_20180221163013;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 79);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AiTestForTraining.Properties.Resources.微信图片_20180221163034;
            this.pictureBox2.Location = new System.Drawing.Point(584, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.linkLabel2);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.labCountTopic);
            this.tabPage3.Controls.Add(this.btnTopicBatch);
            this.tabPage3.Controls.Add(this.btnTopicSingle);
            this.tabPage3.Controls.Add(this.txtTopicResult);
            this.tabPage3.Controls.Add(this.labCatch);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtTestTopic);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtTopic);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(721, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "关键话题分析";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(636, 385);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "匹配的结果";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(636, 357);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 12);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "批量处理结果";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(424, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "已批量处理：";
            // 
            // labCountTopic
            // 
            this.labCountTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labCountTopic.AutoSize = true;
            this.labCountTopic.Location = new System.Drawing.Point(516, 373);
            this.labCountTopic.Name = "labCountTopic";
            this.labCountTopic.Size = new System.Drawing.Size(0, 12);
            this.labCountTopic.TabIndex = 10;
            // 
            // btnTopicBatch
            // 
            this.btnTopicBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopicBatch.Location = new System.Drawing.Point(468, 284);
            this.btnTopicBatch.Name = "btnTopicBatch";
            this.btnTopicBatch.Size = new System.Drawing.Size(141, 48);
            this.btnTopicBatch.TabIndex = 8;
            this.btnTopicBatch.Text = "批量测试（根据指定的数据库批量分析）";
            this.btnTopicBatch.UseVisualStyleBackColor = true;
            this.btnTopicBatch.Click += new System.EventHandler(this.btnTopicBatch_Click);
            // 
            // btnTopicSingle
            // 
            this.btnTopicSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTopicSingle.Location = new System.Drawing.Point(77, 284);
            this.btnTopicSingle.Name = "btnTopicSingle";
            this.btnTopicSingle.Size = new System.Drawing.Size(154, 48);
            this.btnTopicSingle.TabIndex = 9;
            this.btnTopicSingle.Text = "单句测试";
            this.btnTopicSingle.UseVisualStyleBackColor = true;
            this.btnTopicSingle.Click += new System.EventHandler(this.btnTopicSingle_Click);
            // 
            // txtTopicResult
            // 
            this.txtTopicResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTopicResult.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.txtTopicResult.Location = new System.Drawing.Point(77, 135);
            this.txtTopicResult.Multiline = true;
            this.txtTopicResult.Name = "txtTopicResult";
            this.txtTopicResult.Size = new System.Drawing.Size(532, 127);
            this.txtTopicResult.TabIndex = 7;
            // 
            // labCatch
            // 
            this.labCatch.AutoSize = true;
            this.labCatch.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCatch.ForeColor = System.Drawing.Color.Orange;
            this.labCatch.Location = new System.Drawing.Point(313, 106);
            this.labCatch.Name = "labCatch";
            this.labCatch.Size = new System.Drawing.Size(75, 28);
            this.labCatch.TabIndex = 6;
            this.labCatch.Text = "匹配！";
            this.labCatch.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "测试结果";
            // 
            // txtTestTopic
            // 
            this.txtTestTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestTopic.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.txtTestTopic.Location = new System.Drawing.Point(77, 49);
            this.txtTestTopic.Multiline = true;
            this.txtTestTopic.Name = "txtTestTopic";
            this.txtTestTopic.Size = new System.Drawing.Size(538, 54);
            this.txtTestTopic.TabIndex = 5;
            this.txtTestTopic.Text = "唉，我买的轮胎怎么还没走呢？";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "待检测语句";
            // 
            // txtTopic
            // 
            this.txtTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTopic.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.txtTopic.Location = new System.Drawing.Point(77, 6);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(538, 37);
            this.txtTopic.TabIndex = 3;
            this.txtTopic.Text = "轮胎未发货";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "话题";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtCarResult);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.btnCar);
            this.tabPage4.Controls.Add(this.imgCar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(721, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "车型识别";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtCarResult
            // 
            this.txtCarResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarResult.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.txtCarResult.Location = new System.Drawing.Point(514, 3);
            this.txtCarResult.Multiline = true;
            this.txtCarResult.Name = "txtCarResult";
            this.txtCarResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCarResult.Size = new System.Drawing.Size(207, 401);
            this.txtCarResult.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "识别结果：";
            // 
            // btnCar
            // 
            this.btnCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCar.Location = new System.Drawing.Point(25, 333);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(252, 52);
            this.btnCar.TabIndex = 1;
            this.btnCar.Text = "选择图片识别";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // imgCar
            // 
            this.imgCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCar.Image = global::AiTestForTraining.Properties.Resources._1__3_;
            this.imgCar.Location = new System.Drawing.Point(3, 3);
            this.imgCar.Name = "imgCar";
            this.imgCar.Size = new System.Drawing.Size(505, 324);
            this.imgCar.TabIndex = 0;
            this.imgCar.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTestTik);
            this.tabPage2.Controls.Add(this.txtTopicLimit);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtOverLoad);
            this.tabPage2.Controls.Add(this.label15);
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
            // txtTestTik
            // 
            this.txtTestTik.Location = new System.Drawing.Point(107, 203);
            this.txtTestTik.Name = "txtTestTik";
            this.txtTestTik.Size = new System.Drawing.Size(297, 21);
            this.txtTestTik.TabIndex = 4;
            this.txtTestTik.Text = "3000";
            // 
            // txtTopicLimit
            // 
            this.txtTopicLimit.Location = new System.Drawing.Point(107, 176);
            this.txtTopicLimit.Name = "txtTopicLimit";
            this.txtTopicLimit.Size = new System.Drawing.Size(297, 21);
            this.txtTopicLimit.TabIndex = 4;
            this.txtTopicLimit.Text = "0.5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "批量测试间隔时间";
            // 
            // txtOverLoad
            // 
            this.txtOverLoad.Location = new System.Drawing.Point(107, 151);
            this.txtOverLoad.Name = "txtOverLoad";
            this.txtOverLoad.Size = new System.Drawing.Size(297, 21);
            this.txtOverLoad.TabIndex = 4;
            this.txtOverLoad.Text = "20";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "关键话题阈值";
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
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(107, 245);
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
            this.txtColumn.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "TextColumn";
            this.label6.Visible = false;
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
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select String";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTopicBatch;
        private System.Windows.Forms.Button btnTopicSingle;
        private System.Windows.Forms.TextBox txtTopicResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTestTopic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtCarResult;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.PictureBox imgCar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labCountTopic;
        private System.Windows.Forms.TextBox txtTopicLimit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labCatch;
        private System.Windows.Forms.TextBox txtTestTik;
        private System.Windows.Forms.Label label16;
    }
}

