namespace StoreAccounting.Services
{
    partial class frmServices
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceCaptino = new System.Windows.Forms.TextBox();
            this.txtServiceAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "قیمت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "توضیح:";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(12, 6);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(155, 21);
            this.txtServiceName.TabIndex = 0;
            // 
            // txtServiceCaptino
            // 
            this.txtServiceCaptino.Location = new System.Drawing.Point(12, 72);
            this.txtServiceCaptino.Multiline = true;
            this.txtServiceCaptino.Name = "txtServiceCaptino";
            this.txtServiceCaptino.Size = new System.Drawing.Size(155, 75);
            this.txtServiceCaptino.TabIndex = 2;
            // 
            // txtServiceAmount
            // 
            this.txtServiceAmount.Location = new System.Drawing.Point(12, 38);
            this.txtServiceAmount.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtServiceAmount.Name = "txtServiceAmount";
            this.txtServiceAmount.Size = new System.Drawing.Size(155, 21);
            this.txtServiceAmount.TabIndex = 1;
            // 
            // btnSub
            // 
            this.btnSub.ForeColor = System.Drawing.Color.Green;
            this.btnSub.Location = new System.Drawing.Point(92, 153);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "ثبت";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(12, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(222, 183);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtServiceAmount);
            this.Controls.Add(this.txtServiceCaptino);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmServices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن خدمات";
            this.Load += new System.EventHandler(this.frmServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceCaptino;
        private System.Windows.Forms.NumericUpDown txtServiceAmount;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnCancel;
    }
}