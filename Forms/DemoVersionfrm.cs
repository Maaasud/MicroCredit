using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MicroCredit.Forms
{
    public partial class DemoVersionfrm : DevExpress.XtraEditors.XtraForm
    {
        public DemoVersionfrm()
        {
            InitializeComponent();
        }
        long count;
        private void DemoVersionfrm_Load(object sender, EventArgs e)
        {
            timerCount.Start();
            count = 0;
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            count++;
            long dot = (10 -count);
            string p ="";
            for(long i =(count%5); i >= 0;i--)
                p +="." ;

            lblWait.Text = "Please wait for " + dot.ToString() + " Secound(s) "+p; 
            if (count >= 10)
            {
                btnClose.Visible = true;
                timerCount.Stop();
                lblWait.Visible = false;
                this.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}