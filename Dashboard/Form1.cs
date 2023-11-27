using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void farbeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }




        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 159;
            int b = 255;

            colorDialQLockTwo.CustomColors = new int[]
            {
                ColorTranslator.ToOle(Color.FromArgb(r, g, b))
            };

            if (colorDialQLockTwo.ShowDialog() == DialogResult.OK)
            {
                Color on = colorDialQLockTwo.Color;
            }
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = 54;
            int g = 57;
            int b = 63;

            colorDialQLockTwoOff.CustomColors = new int[]
            {
                ColorTranslator.ToOle(Color.FromArgb(r, g, b))
            };

            if (colorDialQLockTwoOff.ShowDialog() == DialogResult.OK)
            {
                Color off = colorDialQLockTwoOff.Color;
            }
        }


        public void resetUnnötig()
        {
            Color off = colorDialQLockTwoOff.Color;

            label3.ForeColor = off;
            label7.ForeColor = off;
            label23.ForeColor = off;
            label24.ForeColor = off;
            label25.ForeColor = off;
            label26.ForeColor = off;
            label34.ForeColor = off;
            label35.ForeColor = off;
            label36.ForeColor = off;
            label37.ForeColor = off;
            label49.ForeColor = off;
            label60.ForeColor = off;
            label61.ForeColor = off;
            label62.ForeColor = off;
            label71.ForeColor = off;
            label72.ForeColor = off;
            label73.ForeColor = off;
            label83.ForeColor = off;
            label84.ForeColor = off;
            label107.ForeColor = off;
        }

        public void resetHour()
        {
            Color off = colorDialQLockTwoOff.Color;

            label95.ForeColor = off;
            label96.ForeColor = off;
            label97.ForeColor = off;
            label98.ForeColor = off;
            label99.ForeColor = off;
            label56.ForeColor = off;
            label57.ForeColor = off;
            label58.ForeColor = off;
            label59.ForeColor = off;
            label63.ForeColor = off;
            label64.ForeColor = off;
            label65.ForeColor = off;
            label66.ForeColor = off;
            label67.ForeColor = off;
            label68.ForeColor = off;
            label69.ForeColor = off;
            label70.ForeColor = off;
            label74.ForeColor = off;
            label75.ForeColor = off;
            label76.ForeColor = off;
            label77.ForeColor = off;
            label52.ForeColor = off;
            label53.ForeColor = off;
            label54.ForeColor = off;
            label55.ForeColor = off;
            label78.ForeColor = off;
            label79.ForeColor = off;
            label80.ForeColor = off;
            label81.ForeColor = off;
            label82.ForeColor = off;
            label89.ForeColor = off;
            label90.ForeColor = off;
            label91.ForeColor = off;
            label92.ForeColor = off;
            label93.ForeColor = off;
            label94.ForeColor = off;
            label85.ForeColor = off;
            label86.ForeColor = off;
            label87.ForeColor = off;
            label88.ForeColor = off;
            label103.ForeColor = off;
            label104.ForeColor = off;
            label105.ForeColor = off;
            label106.ForeColor = off;
            label100.ForeColor = off;
            label101.ForeColor = off;
            label102.ForeColor = off;
            label103.ForeColor = off;
            label56.ForeColor = off;
            label57.ForeColor = off;
            label58.ForeColor = off;
            label59.ForeColor = off;
            label50.ForeColor = off;
            label51.ForeColor = off;
            label52.ForeColor = off;
        }

        public void resetMinute()
        {
            Color off = colorDialQLockTwoOff.Color;

            label108.ForeColor = off;
            label109.ForeColor = off;
            label110.ForeColor = off;
            label8.ForeColor = off;
            label9.ForeColor = off;
            label10.ForeColor = off;
            label11.ForeColor = off;
            label12.ForeColor = off;
            label13.ForeColor = off;
            label14.ForeColor = off;
            label15.ForeColor = off;
            label27.ForeColor = off;
            label28.ForeColor = off;
            label29.ForeColor = off;
            label30.ForeColor = off;
            label31.ForeColor = off;
            label32.ForeColor = off;
            label33.ForeColor = off;
            label41.ForeColor = off;
            label42.ForeColor = off;
            label43.ForeColor = off;
            label44.ForeColor = off;
            label16.ForeColor = off;
            label17.ForeColor = off;
            label18.ForeColor = off;
            label19.ForeColor = off;
            label20.ForeColor = off;
            label21.ForeColor = off;
            label22.ForeColor = off;
            label38.ForeColor = off;
            label39.ForeColor = off;
            label40.ForeColor = off;
            label45.ForeColor = off;
            label46.ForeColor = off;
            label47.ForeColor = off;
            label48.ForeColor = off;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd. MMM yyyy");

            circSec.Value = DateTime.Now.Second +1;
            if (circSec.Value == 60)
            {
                circSec.AnimationSpeed = 500;
            }

            if (circSec.Value == 2)
            {
                circSec.AnimationSpeed = 2000;
            }            

            Color on = colorDialQLockTwo.Color;

            label1.ForeColor = on;
            label2.ForeColor = on;
            label4.ForeColor = on;
            label5.ForeColor = on;
            label6.ForeColor = on;

            resetUnnötig();





            if ((DateTime.Now.Hour == 0) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 0) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 1) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 1) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 2) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 2) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 3) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 3) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 4) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 4) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 5) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 5) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 6) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 6) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 7) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 7) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 8) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 8) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 9) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 9) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 10) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 10) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 11) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 11) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 12) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 12) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 13) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 13) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 14) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 14) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 15) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 15) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 16) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 16) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 17) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 17) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 18) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 18) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 19) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 19) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 20) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 20) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 21) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 21) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 22) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 22) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 23) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 23) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 24) && (DateTime.Now.Minute < 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 24) && (DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 0) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 0) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 1) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 1) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 2) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 2) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 3) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 3) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 4) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 4) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 5) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 5) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 6) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 6) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 7) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 7) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 8) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 8) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 9) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 9) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 10) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 10) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 11) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 11) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 12) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 12) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 13) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 13) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 14) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label63.ForeColor = on;
                label64.ForeColor = on;
                label65.ForeColor = on;
                label66.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 14) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 15) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label67.ForeColor = on;
                label68.ForeColor = on;
                label69.ForeColor = on;
                label70.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 15) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 16) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label74.ForeColor = on;
                label75.ForeColor = on;
                label76.ForeColor = on;
                label77.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 16) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 17) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label52.ForeColor = on;
                label53.ForeColor = on;
                label54.ForeColor = on;
                label55.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 17) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 18) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label78.ForeColor = on;
                label79.ForeColor = on;
                label80.ForeColor = on;
                label81.ForeColor = on;
                label82.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 18) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 19) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label89.ForeColor = on;
                label90.ForeColor = on;
                label91.ForeColor = on;
                label92.ForeColor = on;
                label93.ForeColor = on;
                label94.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 19) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 20) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label85.ForeColor = on;
                label86.ForeColor = on;
                label87.ForeColor = on;
                label88.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 20) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 21) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label103.ForeColor = on;
                label104.ForeColor = on;
                label105.ForeColor = on;
                label106.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 21) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 22) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label100.ForeColor = on;
                label101.ForeColor = on;
                label102.ForeColor = on;
                label103.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 22) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 23) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label50.ForeColor = on;
                label51.ForeColor = on;
                label52.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 23) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 24) && (DateTime.Now.Minute < 23) && (DateTime.Now.Second < 30))
            {
                resetHour();
                label95.ForeColor = on;
                label96.ForeColor = on;
                label97.ForeColor = on;
                label98.ForeColor = on;
                label99.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 24) && (DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label59.ForeColor = on;
            }









            if ((DateTime.Now.Hour == 1) && (DateTime.Now.Minute >= 0) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 3))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 1) && (DateTime.Now.Minute >= 0) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 2))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 0) && (DateTime.Now.Minute >= 58) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 60))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 0) && (DateTime.Now.Minute >= 57) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 60))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 13) && (DateTime.Now.Minute >= 0) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 3))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 13) && (DateTime.Now.Minute >= 0) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 2))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 12) && (DateTime.Now.Minute >= 58) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 60))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Hour == 12) && (DateTime.Now.Minute >= 57) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 60))
            {
                resetHour();
                label56.ForeColor = on;
                label57.ForeColor = on;
                label58.ForeColor = on;
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }











            if ((DateTime.Now.Minute >= 0) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 3))
            {
                resetMinute();
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 3) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 8))
            {
                resetMinute();
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 8) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 13))
            {
                resetMinute();
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label12.ForeColor = on;
                label13.ForeColor = on;
                label14.ForeColor = on;
                label15.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 13) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 18))
            {
                resetMinute();
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label27.ForeColor = on;
                label28.ForeColor = on;
                label29.ForeColor = on;
                label30.ForeColor = on;
                label31.ForeColor = on;
                label32.ForeColor = on;
                label33.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 18) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 23))
            {
                resetMinute();
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label16.ForeColor = on;
                label17.ForeColor = on;
                label18.ForeColor = on;
                label19.ForeColor = on;
                label20.ForeColor = on;
                label21.ForeColor = on;
                label22.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 23) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 28))
            {
                resetMinute();
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label45.ForeColor = on;
                label46.ForeColor = on;
                label47.ForeColor = on;
                label48.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 28) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 33))
            {
                resetMinute();
                label45.ForeColor = on;
                label46.ForeColor = on;
                label47.ForeColor = on;
                label48.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 33) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 38))
            {
                resetMinute();
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label45.ForeColor = on;
                label46.ForeColor = on;
                label47.ForeColor = on;
                label48.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 38) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 43))
            {
                resetMinute();
                label16.ForeColor = on;
                label17.ForeColor = on;
                label18.ForeColor = on;
                label19.ForeColor = on;
                label20.ForeColor = on;
                label21.ForeColor = on;
                label22.ForeColor = on;
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 43) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 48))
            {
                resetMinute();
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label27.ForeColor = on;
                label28.ForeColor = on;
                label29.ForeColor = on;
                label30.ForeColor = on;
                label31.ForeColor = on;
                label32.ForeColor = on;
                label33.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 48) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 53))
            {
                resetMinute();
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label12.ForeColor = on;
                label13.ForeColor = on;
                label14.ForeColor = on;
                label15.ForeColor = on;
            }
            if ((DateTime.Now.Minute >= 53) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 58))
            {
                resetMinute();
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 58) && (DateTime.Now.Second < 30) && (DateTime.Now.Minute < 60))
            {
                resetMinute();
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }












            if ((DateTime.Now.Minute >= 0) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 3))
            {
                resetMinute();
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 2) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 8))
            {
                resetMinute();
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 7) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 13))
            {
                resetMinute();
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label12.ForeColor = on;
                label13.ForeColor = on;
                label14.ForeColor = on;
                label15.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 12) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 18))
            {
                resetMinute();
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label27.ForeColor = on;
                label28.ForeColor = on;
                label29.ForeColor = on;
                label30.ForeColor = on;
                label31.ForeColor = on;
                label32.ForeColor = on;
                label33.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 17) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 23))
            {
                resetMinute();
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label16.ForeColor = on;
                label17.ForeColor = on;
                label18.ForeColor = on;
                label19.ForeColor = on;
                label20.ForeColor = on;
                label21.ForeColor = on;
                label22.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 22) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 28))
            {
                resetMinute();
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label45.ForeColor = on;
                label46.ForeColor = on;
                label47.ForeColor = on;
                label48.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 27) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 33))
            {
                resetMinute();
                label45.ForeColor = on;
                label46.ForeColor = on;
                label47.ForeColor = on;
                label48.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 32) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 38))
            {
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
                label41.ForeColor = on;
                label42.ForeColor = on;
                label43.ForeColor = on;
                label44.ForeColor = on;
                label45.ForeColor = on;
                label46.ForeColor = on;
                label47.ForeColor = on;
                label48.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 37) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 43))
            {
                resetMinute();
                label16.ForeColor = on;
                label17.ForeColor = on;
                label18.ForeColor = on;
                label19.ForeColor = on;
                label20.ForeColor = on;
                label21.ForeColor = on;
                label22.ForeColor = on;
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 42) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 48))
            {
                resetMinute();
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label27.ForeColor = on;
                label28.ForeColor = on;
                label29.ForeColor = on;
                label30.ForeColor = on;
                label31.ForeColor = on;
                label32.ForeColor = on;
                label33.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 47) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 53))
            {
                resetMinute();
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label12.ForeColor = on;
                label13.ForeColor = on;
                label14.ForeColor = on;
                label15.ForeColor = on;
            }
            if ((DateTime.Now.Minute >= 52) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 58))
            {
                resetMinute();
                label38.ForeColor = on;
                label39.ForeColor = on;
                label40.ForeColor = on;
                label8.ForeColor = on;
                label9.ForeColor = on;
                label10.ForeColor = on;
                label11.ForeColor = on;
            }

            if ((DateTime.Now.Minute >= 57) && (DateTime.Now.Second >= 30) && (DateTime.Now.Minute < 60))
            {
                resetMinute();
                label108.ForeColor = on;
                label109.ForeColor = on;
                label110.ForeColor = on;
            }
        }

        private void farbeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int r = 142;
            int g = 146;
            int b = 151;

            colorDialog1.CustomColors = new int[]
            {
                ColorTranslator.ToOle(Color.FromArgb(r, g, b))
            };

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                lblTime.ForeColor = color;
                lblSec.ForeColor = color;
                lblDate.ForeColor = color;
            }
        }

        bool mouseDown;
        private Point offset;

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void farbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 159;
            int b = 255;

            colorDialog2.CustomColors = new int[]
            {
                ColorTranslator.ToOle(Color.FromArgb(r, g, b))
            };

            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog2.Color;
                circSec.ProgressColor = color;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dbea6f0ba156.eu.ngrok.io ");
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mouseHover_Event(object sender, EventArgs e)
        {
            int r = 255;
            int g = 0;
            int b = 0;

            Color closecolor = (Color.FromArgb(r, g, b));
            close.BackColor = closecolor;
        }

        private void mouseLeave_Event(object sender, EventArgs e)
        {
            int r = 32;
            int g = 34;
            int b = 37;

            Color closecolor = (Color.FromArgb(r, g, b));
            close.BackColor = closecolor;
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void mouseClick_Event(object sender, MouseEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
