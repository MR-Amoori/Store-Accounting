using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer;

namespace StoreAccounting.Customer
{
    public partial class AddOrEditCustomer : Form
    {
        public int FrmId = 0;
        public AddOrEditCustomer()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Customer_TB customer = new Customer_TB
                    {
                        Name = txtName.Text,
                        Family = txtFamily.Text,
                        Email = txtEmail.Text,
                        NumberPhone = txtNumberPhone.Text,
                        Address = txtAddress.Text,
                        Reference = 0
                    };

                    if (FrmId == 0)
                    {                       
                        db.CustomerReoisitorry.InsertCustomer(customer);
                        db.Save();
                    }
                    else
                    {
                        customer.CustomerId = FrmId;
                        db.CustomerReoisitorry.UpdateCustomer(customer);
                        db.Save();
                    }
                    
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void AddOrEditCustomer_Load(object sender, EventArgs e)
        {

            if (FrmId != 0)
            {
                this.Text = "ویرایش شخص";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var customer = db.CustomerReoisitorry.GetCustomerbyId(FrmId);
                    txtName.Text = customer.Name;
                    txtFamily.Text = customer.Family;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    txtNumberPhone.Text = customer.NumberPhone;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
