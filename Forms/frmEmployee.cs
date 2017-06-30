using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MicroCredit.BaseControl;
using MicroCredit.DataSets;

namespace MicroCredit.Forms
{
    public partial class frmEmployee : BaseEditViewForm
    {
        bool _isNew = false;
        bool _isUpdate = false;
        string _EditID = "";
        string _DeleteID = "";
        EmployeeDataset dsEmployee;
        
        public frmEmployee()
        {
            InitializeComponent();
            dsEmployee = new EmployeeDataset();
            InitializedDataset();
            LockAllText(true);
        }

        private void InitializedDataset()
        {
            dsEmployee.Employee.Clear();
            dsEmployee.Employee.Merge(DataHelper.GetTableData(dsEmployee.Employee).Tables[0]);
            dgEmployee.DataSource = dsEmployee.Employee;
        }

        private void SaveEmployee()
        {
            throw new NotImplementedException();
        }

        private bool ErrorFound()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MainErrorProvider.SetError(txtName, "Insert Employee Name");
                return true;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MainErrorProvider.SetError(txtAddress, "Insert Employee Address");
                return true;
            }
            return false;
        }

        private void nbiNew_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _isNew = true;
            _isUpdate = false;
            btnApply.Enabled = true;
            LockAllText(false);
            ClearallText();
            txtCode.Focus();
        }

        private void ClearallText()
        {
            txtName.Text = "";
            txtCode.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
        private void LockAllText(bool p)
        {
            txtName.Properties.ReadOnly = p;
            txtCode.Properties.ReadOnly = p;
            txtPhone.Properties.ReadOnly = p;
            txtAddress.Properties.ReadOnly = p;
            btnApply.Enabled = !p;
        }
        private void nbiEdit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colIID) == null)
                return;
            _EditID = gridView1.GetFocusedRowCellValue(colIID).ToString();
            txtCode.Text = gridView1.GetFocusedRowCellValue(colCode).ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue(colName).ToString();
            txtPhone.Text = gridView1.GetFocusedRowCellValue(colPhone).ToString();
            txtAddress.Text = gridView1.GetFocusedRowCellValue(colAddress).ToString();
            _isUpdate = true;
            _isNew = false;
            btnApply.Enabled = true;
        }

        private void nbiDelete_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colIID) == null)
                return;
            _DeleteID = gridView1.GetFocusedRowCellValue(colIID).ToString();
            if (MessageBox.Show("Do you want to delete this Employee ?", "User Employee Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            dsEmployee.Employee.Rows.Find(_DeleteID).Delete();
            try
            {
                DataHelper.UpdateData(dsEmployee.Employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This user contains enough transactions... this can't be delete", "unable to delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void nbiRefresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MakeRefresh();
        }

        private void MakeRefresh()
        {
            ClearallText();
            InitializedDataset();
        }

        private void nbiClose_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            if (_isUpdate)
            {
                if (MessageBox.Show("Do you want to update Employee information", "Employee Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                DataRow dr = dsEmployee.Employee.Rows.Find(_EditID);
                dr["Code"] = txtCode.Text.ToUpper();
                dr["Name"] = txtName.Text;
                dr["Phone"] = txtPhone.Text;
                dr["Address"] = txtAddress.Text;
                DataHelper.UpdateData(dsEmployee.Employee);
                btnApply.Enabled = false;
                LockAllText(true);
            }
            else if (_isNew)
            {
                DataRow dr = dsEmployee.Employee.NewRow();
                dr["IID"] = Guid.NewGuid();
                dr["Code"] = txtCode.Text.ToUpper();
                dr["Name"] = txtName.Text;
                dr["Phone"] = txtPhone.Text;
                dr["Address"] = txtAddress.Text;
                dsEmployee.Employee.Rows.Add(dr);
                DataHelper.UpdateData(dsEmployee.Employee);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockAllText(true);
            MainErrorProvider.SetError(txtName, null);
            MainErrorProvider.SetError(txtAddress, null);
            gridView1.Focus();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colIID) != null)
                FillRow();
        }

        private void FillRow()
        {
            txtCode.Text = gridView1.GetFocusedRowCellValue(colCode).ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue(colName).ToString();
            txtPhone.Text = gridView1.GetFocusedRowCellValue(colPhone).ToString();
            txtAddress.Text = gridView1.GetFocusedRowCellValue(colAddress).ToString();
        }

    }
}
