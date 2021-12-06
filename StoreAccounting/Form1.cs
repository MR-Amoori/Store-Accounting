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
                txtDateTime.Text = DateTime.Now.ToString("ddd  yyyy/MM/dd");
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

        void BindGridCustomer()
        {
            dgvCustomers.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerReoisitorry.GetAllCustomers();
                db.Dispose();
            }
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
                if (RtlMessageBox.Show($"آیا از حذف {Name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
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
            txtFilter.Text = "";
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerReoisitorry.GetCustomerByFilter(txtFilter.Text);
            }
        }
    }
}
