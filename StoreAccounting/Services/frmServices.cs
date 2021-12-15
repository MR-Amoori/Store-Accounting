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
        public int ServiceId;
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
            if (frmId==1)
            {
                this.Text = "ویرایش خدمات نرم افزاری";
                using (UnitOfWork db=new UnitOfWork())
                {
                    var select = db.GenericRepositorySoftService.GetById(ServiceId);
                    txtServiceName.Text = select.SoftServiceName;
                    txtServiceAmount.Value = (int)select.SoftServiceAmount;
                    txtServiceCaptino.Text = select.SoftServiceCaption;
                }
            }
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
                if (frmId ==1)
                {
                    service.SoftServiceId = ServiceId;
                    db.GenericRepositorySoftService.Update(service);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
