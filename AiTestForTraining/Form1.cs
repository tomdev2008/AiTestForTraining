using AiTestForTraining.Properties;
using Baidu.Aip.ImageClassify;
using Baidu.Aip.Nlp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiTestForTraining
{
    public partial class Form1 : Form
    {
        private Nlp nlp;
        private ImageClassify imageClassify;
        private TxtRecorder txtRecorder;
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
        }
        private void SaveSettings()
        {
            Settings.Default.AppKey = txtAppKey.Text;
            Settings.Default.SecretKey = txtSecretKey.Text;
            Settings.Default.ConnectString = txtConnectString.Text;
            Settings.Default.TextTable = txtTable.Text;
            Settings.Default.TextColumn = txtColumn.Text;
            Settings.Default.OverLoad = txtOverLoad.Text;
            Settings.Default.Save();
            nlp = new Nlp(txtAppKey.Text, txtSecretKey.Text);
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btnSentimentSingle_Click(object sender, EventArgs e)
        {
            var result = nlp.SentimentClassify(txtSentimentInput.Text);
            txtSentimentOutput.Text = result.ToString();
            progressBar1.Value = decimal.TryParse(result.SelectToken("items[0].positive_prob")?.ToString(), out var positive) ? Convert.ToInt32(positive * 100) : 0;
            txtRecorder.TxtWrite(txtSentimentOutput.Text);
            if(progressBar1.Value< Convert.ToInt32(txtOverLoad.Text))
                txtRecorder.TxtWriteWarning($"情感预警【{progressBar1.Value}】{txtSentimentInput.Text}");
        }

        private void btnSentimentBatch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            var result = nlp.Simnet(txtTopic.Text,txtTestTopic.Text);
            txtTopicResult.Text = result.ToString();
              txtRecorder.TxtWrite(txtTopicResult.Text);           
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
    }
}
