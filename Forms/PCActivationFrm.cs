using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Management;
using MicroCredit.DataSets;


namespace MicroCredit.Forms
{
    public partial class PCActivationFrm : DevExpress.XtraEditors.XtraForm
    {
        String MBSerial = "";
        String PSerial = "";
        public bool _Cancel;
        public PCActivationFrm()
        {
            InitializeComponent();
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                MBSerial = mo["SerialNumber"].ToString();
            }

            ManagementObjectCollection mbsList1 = null;
            ManagementObjectSearcher mbs1 = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList1 = mbs1.Get();
            foreach (ManagementObject mo in mbsList1)
            {
                PSerial = mo["ProcessorID"].ToString();
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                Guid gid = new Guid(txtPassword.Text);
                DemoSecurityDataSet dsDemo = new DemoSecurityDataSet();
                dsDemo.ActiveMachine.Merge(DataHelper.GetTableData(dsDemo.ActiveMachine, "Where SerialCode = '"+txtPassword.Text+"'").Tables[0]);
                if (dsDemo.ActiveMachine.Rows.Count > 0)
                {
                    MessageBox.Show("Serial number is already used", "Invalid Serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataRow dr = dsDemo.ActiveMachine.NewRow();
                dr["IID"] = Guid.NewGuid();
                dr["Processor"] = PSerial;
                dr["Matherboard"] = MBSerial;
                dr["ActiveMachine"] = System.Net.Dns.GetHostName();
                dr["SerialCode"] = txtPassword.Text;
                dsDemo.ActiveMachine.Rows.Add(dr);
                DataHelper.UpdateData(dsDemo.ActiveMachine);
                _Cancel = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial number is not correct","Invalid Serial",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }            
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _Cancel = false;
            this.Dispose();
        }
    }
}