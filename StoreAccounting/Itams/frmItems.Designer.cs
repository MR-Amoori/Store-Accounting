namespace StoreAccounting.Itams
{
    partial class frmItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.MaskedTextBox();
            this.txtIdViewIdtem = new System.Windows.Forms.NumericUpDown();
            this.txtNumberItem = new System.Windows.Forms.NumericUpDown();
            this.txtAmountFroshItem = new System.Windows.Forms.NumericUpDown();
            this.txtAmountKharidItem = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rangeValidator2 = new ValidationComponents.RangeValidator(this.components);
            this.rangeValidator3 = new ValidationComponents.RangeValidator(this.components);
            this.rangeValidator4 = new ValidationComponents.RangeValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdViewIdtem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountFroshItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountKharidItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کالا:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "کد کالا:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "دسته بندی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "تعداد:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "قیمت خرید:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "قیمت فروش:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "توضیحات:";
            // 
            // txtNameItem
            // 
            this.txtNameItem.Location = new System.Drawing.Point(200, 7);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(135, 22);
            this.txtNameItem.TabIndex = 1;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(12, 119);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(323, 138);
            this.txtCaption.TabIndex = 1;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(200, 45);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(135, 22);
            this.txtCategory.TabIndex = 2;
            // 
            // txtIdViewIdtem
            // 
            this.txtIdViewIdtem.Location = new System.Drawing.Point(4, 7);
            this.txtIdViewIdtem.Name = "txtIdViewIdtem";
            this.txtIdViewIdtem.Size = new System.Drawing.Size(120, 22);
            this.txtIdViewIdtem.TabIndex = 3;
            // 
            // txtNumberItem
            // 
            this.txtNumberItem.Location = new System.Drawing.Point(4, 45);
            this.txtNumberItem.Name = "txtNumberItem";
            this.txtNumberItem.Size = new System.Drawing.Size(120, 22);
            this.txtNumberItem.TabIndex = 3;
            // 
            // txtAmountFroshItem
            // 
            this.txtAmountFroshItem.Location = new System.Drawing.Point(4, 79);
            this.txtAmountFroshItem.Name = "txtAmountFroshItem";
            this.txtAmountFroshItem.Size = new System.Drawing.Size(120, 22);
            this.txtAmountFroshItem.TabIndex = 3;
            // 
            // txtAmountKharidItem
            // 
            this.txtAmountKharidItem.Location = new System.Drawing.Point(200, 79);
            this.txtAmountKharidItem.Name = "txtAmountKharidItem";
            this.txtAmountKharidItem.Size = new System.Drawing.Size(135, 22);
            this.txtAmountKharidItem.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(260, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtNameItem;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام کالا را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtIdViewIdtem;
            this.rangeValidator1.ErrorMessage = "لطفا کد کالا را وارد کنید";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "99999999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtCategory;
            this.requiredFieldValidator2.ErrorMessage = "لطفا دسته بندی کالا را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // rangeValidator2
            // 
            this.rangeValidator2.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator2.ControlToValidate = this.txtNameItem;
            this.rangeValidator2.ErrorMessage = "لطفا تعداد کالا را وارد کنید";
            this.rangeValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator2.Icon")));
            this.rangeValidator2.MaximumValue = "99999999999";
            this.rangeValidator2.MinimumValue = "1";
            this.rangeValidator2.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // rangeValidator3
            // 
            this.rangeValidator3.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator3.ControlToValidate = this.txtAmountKharidItem;
            this.rangeValidator3.ErrorMessage = "لطفا قیمت خرید کالا را وارد کنید";
            this.rangeValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator3.Icon")));
            this.rangeValidator3.MaximumValue = "99999999999";
            this.rangeValidator3.MinimumValue = "1";
            this.rangeValidator3.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // rangeValidator4
            // 
            this.rangeValidator4.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator4.ControlToValidate = this.txtNameItem;
            this.rangeValidator4.ErrorMessage = "لطفا قیمت فروش کالا را وارد کنید";
            this.rangeValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator4.Icon")));
            this.rangeValidator4.MaximumValue = "99999999999";
            this.rangeValidator4.MinimumValue = "1";
            this.rangeValidator4.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 304);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAmountKharidItem);
            this.Controls.Add(this.txtAmountFroshItem);
            this.Controls.Add(this.txtNumberItem);
            this.Controls.Add(this.txtIdViewIdtem);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.txtNameItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن کالا";
            ((System.ComponentModel.ISupportInitialize)(this.txtIdViewIdtem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountFroshItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountKharidItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.MaskedTextBox txtCategory;
        private System.Windows.Forms.NumericUpDown txtIdViewIdtem;
        private System.Windows.Forms.NumericUpDown txtNumberItem;
        private System.Windows.Forms.NumericUpDown txtAmountFroshItem;
        private System.Windows.Forms.NumericUpDown txtAmountKharidItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RangeValidator rangeValidator2;
        private ValidationComponents.RangeValidator rangeValidator3;
        private ValidationComponents.RangeValidator rangeValidator4;
    }
}