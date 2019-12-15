using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Weka.UI_Library.UI_Forms
{
    public partial class frm_splash : MetroForm
    {
        int count = 0, buffer = 0;
        public frm_splash()
        {
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.05;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (buffer == 30)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                var m = new frm_login();
                m.Show();
                timer3.Stop();
            }
            else
            {
                count--;
                Opacity = count * 0.05;
            }
        }
    }
}
