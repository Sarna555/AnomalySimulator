using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnomaliePaliw
{
    public partial class MainForm : Form
    {
        List<Anomaly> AnomalyList;
        public MainForm()
        {
            AnomalyList = new List<Anomaly>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (StableOption.Checked)
            {
                EnableB(true);
                EnableA(false);
            }
            else
            {
                EnableB(false);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EnableA(bool state)
        {
            TextBoxA.Enabled = state;
        }

        private void EnableB(bool state)
        {
            TextBoxB.Enabled = state;
        }

        private void EnableC(bool state)
        {
            TextBoxB.Enabled = state;
        }

        private void VariousOption_CheckedChanged(object sender, EventArgs e)
        {
            if (VariousOption.Checked)
            {
                EnableB(true);
                EnableA(true);
            }
            else
            {
                EnableB(false);
                EnableC(false);
            }
        }

        private void PipeOption_CheckedChanged(object sender, EventArgs e)
        {
            if (PipeOption.Checked)
            {
                EnableB(true);
                EnableA(true);
            }
            else
            {
                EnableB(false);
                EnableC(false);
            }
        }
      
      
      
    }
}
