using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTBFSimulator
{
    public partial class frmMTBF : Form
    {
        public int intPressClosings, intPredictiveCount, intMTBF;

        private void frmMTBF_Load(object sender, EventArgs e)
        {
            lblNumberClosed.Visible = false;
            lblPredictiveMaintCount.Visible = false;
            lblWarning.Visible = false;
            lblProdResumed.Visible = false;
            txtPressClosed.Visible = false;
        }

        private void chkPredictiveMaintSet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPredictiveMaintSet.Checked)
            {
                intMTBF = (int)cboMTBF.SelectedItem;
                intPredictiveCount = intMTBF - 2;
                lblPredictiveMaintCount.Text = intPredictiveCount.ToString();
                lblPredictiveMaintCount.Visible = true;
                lblNumberClosed.Text = "0";
                chkResumeProd.Checked = false;

                
            }
            else
            {
                intPredictiveCount = 0;
                lblPredictiveMaintCount.Visible = false;
            }
        }

        private void cboMTBF_SelectedIndexChanged(object sender, EventArgs e)
        {
            intMTBF = (int)cboMTBF.SelectedItem;
            chkPrevMaintenance.Checked = false;
            chkPredictiveMaintSet.Checked = false;
            lblProdResumed.Visible = false;

        }

        private void chkResumeProd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResumeProd.Checked)
            {
                chkClosePress.Enabled = true;
                lblWarning.Visible = false;
                intPressClosings = 0;
                lblNumberClosed.Text = intPressClosings.ToString();
                chkClosePress.Checked = false;
                chkPrevMaintenance.Checked = false;
                chkPredictiveMaintSet.Checked = false;
            }
        }

        public frmMTBF()
        {
            InitializeComponent();
        }

        private void chkClosePress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClosePress.Checked)
            {
                lblProdResumed.Visible = false;
                txtPressClosed.Visible = true;
                txtPressOpen.Visible = false;
                intPressClosings = ++intPressClosings;
                lblNumberClosed.Text = intPressClosings.ToString();
                lblNumberClosed.Visible = true;
            }
            else
            {
                txtPressClosed.Visible = false;
                txtPressOpen.Visible = true;
            }
            if (chkPredictiveMaintSet.Checked)
            {
                if (intPressClosings == intPredictiveCount)
                {
                    lblWarning.Text = "Press Stopped for Preventive Maintenance";
                    lblWarning.Visible = true;
                    chkPrevMaintenance.Checked = true;
                    txtPressOpen.Visible = true;
                    txtPressClosed.Visible = false;
                    chkClosePress.Enabled = false;
                    return;
                }
                if (chkResumeProd.Checked)
                {
                    chkClosePress.Enabled = true;
                    lblWarning.Visible = false;
                    intPressClosings = 0;
                    lblProdResumed.Visible = true;
                    chkResumeProd.Checked = false;
                }
            }
            if (intPressClosings > intMTBF)
            {
                lblWarning.Text = "Press Breakdown - Production Downtime";
                lblWarning.Visible = true;
                chkClosePress.Enabled = false;
            }
            else
            {
                lblWarning.Visible = false;
                chkClosePress.Enabled = true;
            }
        }
    }
}
