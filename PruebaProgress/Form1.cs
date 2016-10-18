using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaProgress
{
    public partial class Form1 : Form
    {

        TimeSpan tiempo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tiempo = TimeSpan.Parse("00:00:30");

            /*prog1.Minimum = 0;
            prog1.Maximum = 100;
            prog1.Step = 10;                    */
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*prog1.PerformStep();
            lbl1.Text = prog1.Value.ToString();            */

            tiempo = tiempo.Subtract(new TimeSpan(00, 00, 01));
            lbl2.Text = tiempo.ToString();

            if (tiempo == new TimeSpan(00, 00, 00))
            {
                timer1.Stop();
            }
           
        }
        
    }
}
