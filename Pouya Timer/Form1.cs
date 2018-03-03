using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pouya_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean isStarted = false;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                dt_Start = DateTime.Now;
                timer1.Start();
                btn_Start.Text = "Pause";
                
                isStarted = true;
            }
            else
            {
                timer1.Stop();
                btn_Start.Text = "Start";
                this.Text += " (Paused)";
                isStarted = false;
            }
        }
        DateTime dt_Start = new DateTime();
        TimeSpan tsp = new TimeSpan(0, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
           tsp= tsp.Add(new TimeSpan(0,0,1));    
            //DateTime.Now - dt_Start;
            lbl_Time.Text = String.Format("{0}:{1}:{2}", tsp.Hours, tsp.Minutes, tsp.Seconds);
            this.Text = lbl_Time.Text;

            if (tsp.Hours > 9)
                lbl_Time.Font=new Font("Times New Roman",35,FontStyle.Bold);
                
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Realy RESET Timer??","Reset",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                tsp = new TimeSpan();
                btn_Start_Click(null, null);
                lbl_Time.Text = "0:0:0";
                this.Text = "Pouya Timer";
            }
        }

        private void checkBox_OnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_OnTop.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void checkBoxHideBorder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHideBorder.Checked)
            {
                this.TransparencyKey = Color.White;
                this.Opacity = 1;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.TransparencyKey = Color.LimeGreen;
                this.Opacity = 0.9;
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
        }
        
    }
}
