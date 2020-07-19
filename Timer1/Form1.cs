using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Form1 : Form
    {
        private int h;
        private int m;
        private int s;

        public Form1()
        {
            InitializeComponent();
            DisplayCurrentTime();
            h = m = s = 0;
        }

        private void DisplayCurrentTime()
        {
            DateTime dt = DateTime.Now;
            clock.Text = dt.ToLongTimeString();
            if (dt.Hour == h && dt.Minute == m && dt.Second == s)
            {
                Process.Start(@"..\..\Audio\audio.mp3");
                //MessageBox.Show("Время истекло!", "Alarm", MessageBoxButtons.OK,
                    //MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCurrentTime();
        }

        private void start_Click(object sender, EventArgs e)
        {
            h = (int)hours.Value;
            m = (int)minutes.Value;
            s = (int)seconds.Value;

            hours.Enabled = false;
            minutes.Enabled = false;
            seconds.Enabled = false;

            MessageBox.Show("Будильник включен!", "Сообщение", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            h = m = s = 0;

            hours.Enabled = true;
            minutes.Enabled = true;
            seconds.Enabled = true;

            MessageBox.Show("Будильник выключен!", "Сообщение", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
