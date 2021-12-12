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
using Accounting.Utility.Convertor;

namespace StoreAccounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            sideNavItem1.Enabled = false;
            mnHome.Select();

            /*Timer*/
            {
                AnalogClock.Value = DateTime.Now;
                txtDateTime.Text = DateTime.Now.ToString("dddd") + "  " + DateTime.Now.ToShamsi().ToString();
                timer.Tick += new EventHandler(timer1_Tick);
                timer.Start();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            AnalogClock.Value = DateTime.Now;
        }

        private void linkStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mnAbout.Select();
        }

        private void mnCustomers_Click_1(object sender, EventArgs e)
        {
            BindGridCustomer();

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            Customer.AddOrEditCustomer frmAdd = new Customer.AddOrEditCustomer();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGridCustomer();
            }
        }

        void BindGridCustomer() //واکشی اطلاعات جدول اشخاص
        {
            dgvCustomers.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerReoisitorry.GetAllCustomers();
                db.Dispose();
            }
        }

        void BindGridItem() //واکشی اطلاعات جدول کالا ها
        {
            dgvItems.AutoGenerateColumns = false;
            using (UnitOfWork db=new UnitOfWork())
            {
                dgvItems.DataSource = db.GenericRepositoryItem.Get();
                db.Dispose();
            }
        }

        void DisposMnItem() //بهینه کردن جدول کالا ها
        {
            dgvItems.DataSource = null;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Customer.AddOrEditCustomer frmEdit = new Customer.AddOrEditCustomer();
            int id = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
            frmEdit.FrmId = id;
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                BindGridCustomer();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers.CurrentRow.Cells[0].Value;
            using (UnitOfWork db = new UnitOfWork())
            {
                var customer = db.CustomerReoisitorry.GetCustomerbyId(id);
                string Name = customer.Name + " " + customer.Family;
                if (RtlMessageBox.Show($"آیا از حذف {Name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.CustomerReoisitorry.DeleteCustomer(customer);
                    db.Save();
                    BindGridCustomer();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGridCustomer();
            txtFilterCustomer.Text = "";
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerReoisitorry.GetCustomerByFilter(txtFilterCustomer.Text);
            }
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            mnAbout.Select();
        }

        private void mnHome_Click(object sender, EventArgs e)
        {
            DisposMn(); // استفاده از متد برای بهینه کردن منابع سیستم
        }

        void DisposMn() // برای خالی کردن دیتا گرید ویو منوی اشخاص که منابع سیستم کمتر استفاده بشه
        {
            dgvCustomers.DataSource = null;
            dgvItems.DataSource = null;
        }

        private void mnReports_Click(object sender, EventArgs e)
        {
            DisposMn();
        }

        private void mnItems_Click(object sender, EventArgs e)
        {
            DisposMn();
            BindGridItem();
        }

        private void mnServicesSoft_Click(object sender, EventArgs e)
        {
            DisposMn();
        }

        private void sideNavItem3_Click(object sender, EventArgs e)
        {
            DisposMn();
        }

        private void mnNewAccounting_Click(object sender, EventArgs e)
        {
            DisposMn();
        }

        private void sideNavItem2_Click(object sender, EventArgs e)
        {
            DisposMn();
        }

        private void mnAbout_Click(object sender, EventArgs e)
        {
            DisposMn();
        }

        private void txtExperessSearch_Click(object sender, EventArgs e)
        {
            txtExperessSearch.Text = "";
        }

        private void btnSearchGSM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://emalls.ir/List.aspx?Search=" + txtExperessSearch.Text);
        }

        private void btnSerachMobile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mobile.ir/phones/search.aspx?terms=" + txtExperessSearch.Text + "&submit=");
        }

        private void btnTel_Click(object sender, EventArgs e)
        {
            string NumberPhone = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            System.Diagnostics.Process.Start("callto: 12345");
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            Itams.frmItems frmItem = new Itams.frmItems();
            if (frmItem.ShowDialog() == DialogResult.OK)
            {
                BindGridItem();
            }
        }

        private void btnRefreshItem_Click(object sender, EventArgs e)
        {
            BindGridItem();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            Itams.frmItems frmitem = new Itams.frmItems();
            frmitem.Id = (int)dgvItems.CurrentRow.Cells[0].Value;
            if (frmitem.ShowDialog()==DialogResult.OK)
            {
                BindGridItem();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.CurrentRow.Cells[0].Value;
            using (UnitOfWork db = new UnitOfWork())
            {
                var item = db.ItemRepository.GetItemById(id);
                string Name = item.ItemName;
                if (RtlMessageBox.Show($"آیا از حذف {Name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ItemRepository.DeleteItem(item.ItemId);
                    db.Save();
                    BindGridItem();
                }
            }
        }
    }
}
