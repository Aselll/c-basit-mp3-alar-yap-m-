using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ac = new OpenFileDialog();
        private void Btnac_Click(object sender, EventArgs e)
        {
            
            ac.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            if(ac.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = ac.FileName.ToString();
            }

        }

        private void Btnoynat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ac.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void Btndurdur_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();


        }
    }
}
