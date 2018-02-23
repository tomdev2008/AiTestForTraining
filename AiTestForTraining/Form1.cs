using AiTestForTraining.Properties;
using Baidu.Aip.ImageClassify;
using Baidu.Aip.Nlp;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiTestForTraining
{
    public partial class Form1 : Form
    {
        private Nlp nlp;
        private ImageClassify imageClassify;
        private TxtRecorder txtRecorder;
        private CancellationTokenSource cts;
        private CancellationToken ct;
        public Form1()
        {
            InitializeComponent();
            txtRecorder = new TxtRecorder();
            GetSettings();
            nlp = new Nlp(txtAppKey.Text, txtSecretKey.Text);
            imageClassify = new ImageClassify(txtAppKey.Text, txtSecretKey.Text);
            
        }

        private void GetSettings()
        {
            txtAppKey.Text = Settings.Default.AppKey;
            txtSecretKey.Text = Settings.Default.SecretKey;
            txtConnectString.Text = Settings.Default.ConnectString;
            txtTable.Text = Settings.Default.TextTable;
            txtColumn.Text = Settings.Default.TextColumn;
            txtOverLoad.Text = Settings.Default.OverLoad;
            txtTopicLimit.Text = Settings.Default.TopicLimit;
            txtTestTik.Text = Settings.Default.TestTik;
        }
        private void SaveSettings()
        {
            Settings.Default.AppKey = txtAppKey.Text;
            Settings.Default.SecretKey = txtSecretKey.Text;
            Settings.Default.ConnectString = txtConnectString.Text;
            Settings.Default.TextTable = txtTable.Text;
            Settings.Default.TextColumn = txtColumn.Text;
            Settings.Default.OverLoad = txtOverLoad.Text;
            Settings.Default.TopicLimit = txtTopicLimit.Text;
            Settings.Default.TestTik = txtTestTik.Text;
            Settings.Default.Save();
            nlp = new Nlp(txtAppKey.Text, txtSecretKey.Text);
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btnSentimentSingle_Click(object sender, EventArgs e)
        {
            SentimentSingle();
        }

        private void SentimentSingle()
        {
            var result = nlp.SentimentClassify(txtSentimentInput.Text);
            txtSentimentOutput.Text = result.ToString();
            progressBar1.Value = decimal.TryParse(result.SelectToken("items[0].positive_prob")?.ToString(), out var positive) ? Convert.ToInt32(positive * 100) : 0;
            txtRecorder.TxtWrite(txtSentimentOutput.Text, "AiTest");
            if (progressBar1.Value < Convert.ToInt32(txtOverLoad.Text))
            {
                pictureBox2.BackColor = Color.Red;
                txtRecorder.TxtWrite($"情感预警【{progressBar1.Value}】{txtSentimentInput.Text}", "AiTestWarning");
            }else pictureBox2.BackColor = Color.Transparent;
        }

        private void btnSentimentBatch_Click(object sender, EventArgs e)
        {
            if (btnSentimentBatch.Text == "执行中...")
            {
                cts.Cancel();
                btnSentimentBatch.Text = "批量测试（根据指定的数据库批量分析）";
            }
            else {
                btnSentimentBatch.Text = "执行中...";
                cts = new CancellationTokenSource();
                ct = cts.Token;
                try
                {
                    Task.Run(() => StartSentimentBatch(ct));
                }
                catch { }
            }
        }

        private void StartSentimentBatch(CancellationToken ct)
        {
            if (txtConnectString.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("请填写数据库设置后执行批处理！");
                return;
            }
            MySqlConnection connection = new MySqlConnection(txtConnectString.Text);
            var query = connection.Query<string>($"{txtTable.Text}");
            labBatchCount.Text = $"0/{query.Count().ToString()}";
            int count = 0;
            foreach (var s in query)
            {
                if (ct.IsCancellationRequested) return;
                count++;
                labBatchCount.Text = $"{count.ToString()}/{query.Count().ToString()}";
                txtSentimentInput.Text = s;
                SentimentSingle();
                Thread.Sleep(Convert.ToInt32(txtTestTik.Text));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            btnSentimentSingle.PerformClick();
            btnTopicSingle_Click(null,null);
            CatDect();
        }

        private void labinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory + "\\AiTest\\");
        }

        private void labInfoWarning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory + "\\AiTestWarning\\");
        }

        private void btnTopicSingle_Click(object sender, EventArgs e)
        {
            TopicSingle();              
        }

        private void TopicSingle()
        {
            var result = nlp.Simnet(txtTopic.Text, txtTestTopic.Text);
            txtTopicResult.Text = result.ToString();
            txtRecorder.TxtWrite(txtTopicResult.Text, "Topic");

           var dec = decimal.TryParse(result.SelectToken("score")?.ToString(), out var positive) ? Convert.ToInt32(positive * 100) : 0;

            if (positive > Convert.ToDecimal(txtTopicLimit.Text))
            {
                txtRecorder.TxtWrite($"关键话题匹配【{positive}】{txtTopicResult.Text}", "TopicCatch");
                txtTopicResult.BackColor = Color.Orange;
                labCatch.Visible = true;
            }
            else
            {
                txtTopicResult.BackColor = Color.White;
                labCatch.Visible = false;
            }
        }

        private void btnTopicBatch_Click(object sender, EventArgs e)
        {
            if (btnTopicBatch.Text == "执行中...")
            {
                cts.Cancel();
                btnTopicBatch.Text = "批量测试（根据指定的数据库批量分析）";
            }
            else
            {
                btnTopicBatch.Text = "执行中...";
                cts = new CancellationTokenSource();
                ct = cts.Token;
                try
                {
                    Task.Run(() => StartTopicBatch(ct));
                }
                catch { }
            }
        }

        private void StartTopicBatch(CancellationToken ct)
        {
            if (txtConnectString.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("请填写数据库设置后执行批处理！");
                return;
            }
            MySqlConnection connection = new MySqlConnection(txtConnectString.Text);
            var query = connection.Query<string>($"{txtTable.Text}");
            labBatchCount.Text = $"0/{query.Count().ToString()}";
            int count = 0;
            foreach (var s in query)
            {
                if (ct.IsCancellationRequested) return;
                count++;
                labCountTopic.Text = $"{count.ToString()}/{query.Count().ToString()}";
                txtTestTopic.Text = s;
                TopicSingle();
                Thread.Sleep(Convert.ToInt32(txtTestTik.Text));
            }
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                var file = open.OpenFile();
                imgCar.Image = Image.FromStream(file);
                CatDect();
               
            }
        }

        private void CatDect()
        {
            MemoryStream ms = new MemoryStream();
            imgCar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            string base64 = Convert.ToBase64String(StreamToBytes(ms)); //ImgToBase64String(open.FileName);
            var result = imageClassify.CarDetect(StreamToBytes(ms));//Convert.FromBase64String(base64));
            txtCarResult.Text = result.ToString();
        }

        public byte[] StreamToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }
        private string ImgToBase64String(string Imagefilename)
        {
            try
            {
                Bitmap bmp = new Bitmap(Imagefilename);
                
                //FileStream fs = new FileStream(Imagefilename + ".txt", FileMode.Create);
                //StreamWriter sw = new StreamWriter(fs);

                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                String strbaser64 = Convert.ToBase64String(arr);
                //sw.Write(strbaser64);

                //sw.Close();
                //fs.Close();
                return strbaser64;
                // MessageBox.Show("转换成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ImgToBase64String 转换失败\nException:" + ex.Message);
            }
            return "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory + "\\Topic\\");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory + "\\TopicCatch\\");
        }
    }
}
