using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MicroCredit.BaseControl
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public string FrmText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
    }   
}