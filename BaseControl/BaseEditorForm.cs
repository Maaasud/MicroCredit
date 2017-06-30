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
    public partial class BaseEditorForm : BaseForm
    {
        public BaseEditorForm()
        {
            InitializeComponent();
        }

        private void BaseEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}