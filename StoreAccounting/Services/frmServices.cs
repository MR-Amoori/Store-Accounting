using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;

namespace StoreAccounting.Services
{
    public partial class frmServices : Form
    {
        public int frmId = 0;
        public frmServices()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmServices_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                SoftService_TB service = new SoftService_TB()
                {
                    SoftServiceName = txtServiceName.Text,
                    SoftServiceAmount = (int)txtServiceAmount.Value,
                    SoftServiceCaption = txtServiceCaptino.Text
                };
                if (frmId == 0)
                {
                    db.GenericRepositorySoftService.Insert(service);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
