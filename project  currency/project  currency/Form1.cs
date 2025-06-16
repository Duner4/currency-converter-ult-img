using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project__currency
{
    public partial class Form1 : Form
    {
        private readonly string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public Form1()
        {
            
            InitializeComponent();
            
        }
        int a = -1, b = -1;
        double[,] from = { { 1, 0.88, 144.93, 0.74, 1.54, 1.37, 0.82, 7.19, 85.79, 1.71 }, { 1.14, 1, 165.11, 0.84, 1.75, 1.56, 0.94, 8.2, 97.78, 1.96 }
            ,{ 0.0069,0.0061,1,0.0051,0.011,0.0094,0.0057,0.05,0.59,0.012 },{1.35,1.19,196.05,1,2.08,1.85,1.11,9.73,116.09,2.32},
            {0.65,0.57,94.1,0.48,1,0.89,0.53,4.67,55.73,1.11},{ 0.73,0.64,105.85,0.54,1.12,1,0.6,5.25,64.67,1.25},
            {1.22,1.07,176.23,0.9,1.87,1.67,1,8.74,104.35,2.08},{ 0.14,0.12,20.15,0.1,0.21,0.19,0.11,1,11.93,0.24},
            {0.012,0.01,1.69,0.0086,0.018,0.016,0.0096,0.084,1,0.02},{ 0.58,0.51,84.52,0.43,0.9,0.8,0.48,4.19,49.95,1} };

        string[,] courseimg = { { "one.png",//dolar
                              "usdtoeur.png",
                              "usdtoyen.png",
                              "usdtopound.png",
                              "usdtoaus.png",
                              "usdtocan.png",
                              "usdtoswis.png",
                              "usdtoch.png",
                              "usdtoru.png",
                              "usdtobgn.png"} ,

                            { "eurotousd.png",//euro
                              "one.png",
                              "eurotoyen.png",
                              "eurotopou.png",
                              "eurotoaus.png",
                              "eurotocan.png",
                              "eurotoswi.png",
                              "eurotochi.png",
                              "eurotorup.png",
                              "eurotobg.png"},

                            { "yentousd.png",//japanese yen
                              "yentoeuro.png",
                              "one.png",
                              "yentopound.png",
                              "yentoaus.png",
                              "yentocan.png",
                              "yentoswis.png",
                              "yentochi.png",
                              "yentorup.png",
                              "yentobgn.png"},

                            { "poundtousd.png",//pound
                              "poundtoeuro.png",
                              "poundtoyen.png",
                              "one.png",
                              "poundtoaus.png",
                              "poundtocan.png",
                              "poundtoswis.png",
                              "poundtochi.png",
                              "poundtorupee.png",
                              "poundtobgn.png"},

                            { "austousd.png",//australia
                              "austoeuro.png",
                              "austoyen.png",
                              "austopound.png",
                              "one.png",
                              "austocad.png",
                              "austoswis.png",
                              "austochi.png",
                              "austorup.png",
                              "austobgn.png"},

                            { "cantousd.png",//canada
                              "cadtoeuro.png",
                              "cadtoyen.png",
                              "cadtopound.png",
                              "cadtoaus.png",
                              "one.png",
                              "cadtoswis.png",
                              "cadtochi.png",
                              "cadtorup.png",
                              "cadtobgn.png"} ,

                            { "swisstousd.png",//swiss
                              "swisstoeuro.png",
                              "swisstoyen.png",
                              "swisstopound.png",
                              "swisstoaus.png",
                              "swisstocad.png",
                              "one.png",
                              "swisstochi.png",
                              "swisstorupee.png",
                              "swisstobgn.png"},

                            { "chitousd.png",//china
                              "chitoeuro.png",
                              "chitoyen.png",
                              "chitopound.png",
                              "chitoaus.png",
                              "chitocad.png",
                              "chitoswis.png",
                              "one.png",
                              "chitorupee.png",
                              "chitobgn.png"},

                            { "rupeetousd.png",//rupee
                              "rupeetoeuro.png",
                              "rupeetoyen.png",
                              "rupeetopound.png",
                              "rupeetoaus.png",
                              "rupeetocad.png",
                              "rupeetoswiss.png",
                              "rupeetochi.png",
                              "one.png",
                              "rupeetobgn.png"},

                            { "bgntousd.png",//leva
                              "bgntoeuro.png",
                              "bgntoyen.png",
                              "bgntopound.png",
                              "bgntoaus.png",
                              "bgntocad.png",
                              "bgntoswiss.png",
                              "bgntochi.png",
                              "bgntorupee.png",
                              "one.png"}
                              };


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = 4;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = 3;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = 5;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            a = 6;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            a = 7;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            a = 8;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            a = 9;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            b = 0;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            b = 1;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            b = 2;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            b = 3;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            b = 4;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            b = 5;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            b = 6;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            b = 7;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            b = 8;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            b = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        
        private void radioButton30_CheckedChanged(object sender, EventArgs e)//dollar
        {
           
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c=-1;
            c = a;
            a = b;
            b = c;
            if (a == 0) radioButton1.Checked = true;
            if (a == 1) radioButton2.Checked = true;
            if (a == 2) radioButton3.Checked = true;
            if (a == 3) radioButton4.Checked = true;
            if (a == 4) radioButton5.Checked = true;
            if (a == 5) radioButton6.Checked = true;
            if (a == 6) radioButton7.Checked = true;
            if (a == 7) radioButton8.Checked = true;
            if (a == 8) radioButton9.Checked = true;
            if (a == 9) radioButton10.Checked = true;
            
            if (b == 0) radioButton20.Checked = true;
            if (b == 1) radioButton19.Checked = true;
            if (b == 2) radioButton18.Checked = true;
            if (b == 3) radioButton17.Checked = true;
            if (b == 4) radioButton16.Checked = true;
            if (b == 5) radioButton11.Checked = true;
            if (b == 6) radioButton13.Checked = true;
            if (b == 7) radioButton15.Checked = true;
            if (b == 8) radioButton14.Checked = true;
            if (b == 9) radioButton12.Checked = true;
            double fro = double.Parse(textBox1.Text);
            double to;
            to = fro * from[a, b];
            textBox2.Text = to.ToString();
            pictureBox9.Image = Image.FromFile(path + "\\images\\" + courseimg[a, b]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(path + "\\images\\" + courseimg[a, b]);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fro = double.Parse(textBox1.Text);
            double to;
            to = fro * from[a, b];
            textBox2.Text = to.ToString();
            pictureBox9.Image = Image.FromFile(path + "\\images\\" + courseimg[a, b]);
        }
    }
}
