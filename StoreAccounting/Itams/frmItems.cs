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
using Accounting.ViewModels.Category;
using Accounting.DataLayer.Context;
using Accounting.DataLayer;

namespace StoreAccounting.Itams
{
    public partial class frmItems : Form
    {
        public int Id = 0;
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //  if (BaseValidator.IsFormValid(this.components))
            // {
            using (UnitOfWork db = new UnitOfWork())
            {
                Item_TB item = new Item_TB()
                {
                    ItemIdView = (int)txtIdViewIdtem.Value,
                    ItemName = txtNameItem.Text,
                    ItemNumber = (int)txtNumberItem.Value,
                    ItemAmountKharid = (int)txtAmountKharidItem.Value,
                    ItemAmountrosh = (int)txtAmountFroshItem.Value,
                    ItemCaption = txtCaption.Text
                };

                if (Id == 0)
                {
                    db.GenericRepositoryItem.Insert(item);
                }

                else
                {
                    item.ItemId = Id;
                    db.GenericRepositoryItem.Update(item);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }
            ///  }
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {

            }
            else
            {
                this.Text = "ویرایش کالا";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var SelectItem = db.ItemRepository.GetItemById(Id);
                    txtNameItem.Text = SelectItem.ItemName;
                    txtNumberItem.Value = SelectItem.ItemNumber;
                    txtIdViewIdtem.Value = SelectItem.ItemIdView;
                    txtCaption.Text = SelectItem.ItemCaption;
                    txtAmountKharidItem.Value = SelectItem.ItemAmountKharid;
                    txtAmountFroshItem.Value = SelectItem.ItemAmountrosh;
                }

            }
        }
    }
}
