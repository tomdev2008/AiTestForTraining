using AiTestForTraining.Properties;
using Baidu.Aip.Nlp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiTestForTraining
{
    public partial class Form1 : Form
    {
        private Nlp nlp;
        private TxtRecorder txtRecorder;
        public Form1()
        {
            InitializeComponent();
            txtRecorder = new TxtRecorder();
            GetSettings();
            nlp = new Nlp(txtAppKey.Text, txtSecretKey.Text);
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
        }

        private void labinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory + "\\AiTest\\");
        }

        private void labInfoWarning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory + "\\AiTestWarning\\");
        }
    }
}
