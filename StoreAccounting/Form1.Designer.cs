namespace StoreAccounting
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            DevComponents.DotNetBar.Controls.ClockStyleData clockStyleData1 = new DevComponents.DotNetBar.Controls.ClockStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData1 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData2 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData3 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData1 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData4 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData5 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData2 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData6 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData3 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData7 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData8 = new DevComponents.DotNetBar.Controls.ColorData();
            this.sideNav1 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel4 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel3 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.dgvCustomers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.sideNavPanel2 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.txtDateTime = new System.Windows.Forms.Label();
            this.AnalogClock = new DevComponents.DotNetBar.Controls.AnalogClockControl();
            this.sideNavPanel6 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel8 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel7 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel9 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel5 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavItem1 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.mnHome = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.mnReports = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.mnCustomers = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.mnItems = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.mnServicesSoft = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem3 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.mnNewAccounting = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem2 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.mnAbout = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sideNav1.SuspendLayout();
            this.sideNavPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.sideNavPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideNav1
            // 
            this.sideNav1.Controls.Add(this.sideNavPanel3);
            this.sideNav1.Controls.Add(this.sideNavPanel4);
            this.sideNav1.Controls.Add(this.sideNavPanel2);
            this.sideNav1.Controls.Add(this.sideNavPanel1);
            this.sideNav1.Controls.Add(this.sideNavPanel6);
            this.sideNav1.Controls.Add(this.sideNavPanel8);
            this.sideNav1.Controls.Add(this.sideNavPanel7);
            this.sideNav1.Controls.Add(this.sideNavPanel9);
            this.sideNav1.Controls.Add(this.sideNavPanel5);
            this.sideNav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNav1.EnableClose = false;
            this.sideNav1.EnableMaximize = false;
            this.sideNav1.EnableSplitter = false;
            this.sideNav1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideNav1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideNavItem1,
            this.separator1,
            this.mnHome,
            this.mnReports,
            this.mnCustomers,
            this.mnItems,
            this.mnServicesSoft,
            this.sideNavItem3,
            this.mnNewAccounting,
            this.sideNavItem2,
            this.mnAbout});
            this.sideNav1.Location = new System.Drawing.Point(0, 0);
            this.sideNav1.Name = "sideNav1";
            this.sideNav1.Padding = new System.Windows.Forms.Padding(1);
            this.sideNav1.Size = new System.Drawing.Size(895, 561);
            this.sideNav1.TabIndex = 0;
            this.sideNav1.Text = "درباره ما";
            // 
            // sideNavPanel4
            // 
            this.sideNavPanel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel4.Location = new System.Drawing.Point(137, 31);
            this.sideNavPanel4.Name = "sideNavPanel4";
            this.sideNavPanel4.Size = new System.Drawing.Size(757, 529);
            this.sideNavPanel4.TabIndex = 18;
            this.sideNavPanel4.Visible = false;
            // 
            // sideNavPanel3
            // 
            this.sideNavPanel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel3.Controls.Add(this.dgvCustomers);
            this.sideNavPanel3.Controls.Add(this.toolStrip1);
            this.sideNavPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel3.Location = new System.Drawing.Point(137, 31);
            this.sideNavPanel3.Name = "sideNavPanel3";
            this.sideNavPanel3.Size = new System.Drawing.Size(757, 529);
            this.sideNavPanel3.TabIndex = 14;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Namee,
            this.Family,
            this.NumberPhone,
            this.Email,
            this.Address,
            this.Reference});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCustomers.Location = new System.Drawing.Point(0, 62);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCustomers.Size = new System.Drawing.Size(757, 467);
            this.dgvCustomers.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Namee
            // 
            this.Namee.DataPropertyName = "Name";
            this.Namee.HeaderText = "نام";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "نام خانوادگی";
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // NumberPhone
            // 
            this.NumberPhone.DataPropertyName = "NumberPhone";
            this.NumberPhone.HeaderText = "شماره تماس";
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            this.Reference.HeaderText = "مراجعه";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCustomer,
            this.toolStripSeparator1,
            this.btnEditCustomer,
            this.toolStripSeparator2,
            this.btnDeleteCustomer,
            this.toolStripSeparator3,
            this.btnRefresh,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(757, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Image = global::StoreAccounting.Properties.Resources._1371475930_filenew;
            this.btnNewCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(80, 59);
            this.btnNewCustomer.Text = "افزودن شخص";
            this.btnNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewCustomer.ToolTipText = "افزودن شخص جدید";
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Image = global::StoreAccounting.Properties.Resources._1371475973_document_edit;
            this.btnEditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(83, 59);
            this.btnEditCustomer.Text = "ویرایش شخص";
            this.btnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCustomer.ToolTipText = "ویرایش شخص";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Image = global::StoreAccounting.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(72, 59);
            this.btnDeleteCustomer.Text = "حذف شخص";
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 62);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::StoreAccounting.Properties.Resources._1371476342_Refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 59);
            this.btnRefresh.Text = "همگام سازی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.ToolTipText = "همگام سازی لیست";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 62);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 59);
            this.toolStripLabel1.Text = "جستجو: ";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Info;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 62);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // sideNavPanel2
            // 
            this.sideNavPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel2.Location = new System.Drawing.Point(137, 31);
            this.sideNavPanel2.Name = "sideNavPanel2";
            this.sideNavPanel2.Size = new System.Drawing.Size(757, 529);
            this.sideNavPanel2.TabIndex = 6;
            this.sideNavPanel2.Visible = false;
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel1.Controls.Add(this.txtDateTime);
            this.sideNavPanel1.Controls.Add(this.AnalogClock);
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(137, 31);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(757, 529);
            this.sideNavPanel1.TabIndex = 2;
            this.sideNavPanel1.Visible = false;
            // 
            // txtDateTime
            // 
            this.txtDateTime.AutoSize = true;
            this.txtDateTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtDateTime.Location = new System.Drawing.Point(293, 454);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(75, 30);
            this.txtDateTime.TabIndex = 2;
            this.txtDateTime.Text = "*تاریخ*";
            // 
            // AnalogClock
            // 
            this.AnalogClock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AnalogClock.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            colorData1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData1.BrushAngle = 90F;
            colorData1.BrushSBSScale = 1F;
            colorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            colorData1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.BezelColor = colorData1;
            colorData2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData2.BorderWidth = 0.01F;
            colorData2.BrushSBSScale = 1F;
            colorData2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            clockStyleData1.CapColor = colorData2;
            clockStyleData1.CapSize = 0.1F;
            colorData3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData3.BrushAngle = 90F;
            colorData3.BrushSBSScale = 1F;
            colorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            colorData3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            clockStyleData1.FaceColor = colorData3;
            clockStyleData1.GlassAngle = 0;
            colorData4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData4.BorderWidth = 0.01F;
            colorData4.BrushAngle = 90F;
            colorData4.BrushSBSScale = 1F;
            colorData4.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            clockHandStyleData1.HandColor = colorData4;
            clockHandStyleData1.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3;
            clockHandStyleData1.Length = 0.45F;
            clockHandStyleData1.Width = 0.175F;
            clockStyleData1.HourHandStyle = clockHandStyleData1;
            colorData5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData5.BorderWidth = 0.01F;
            colorData5.BrushSBSScale = 1F;
            colorData5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.LargeTickColor = colorData5;
            clockStyleData1.LargeTickWidth = 0.01F;
            colorData6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData6.BorderWidth = 0.01F;
            colorData6.BrushAngle = 90F;
            colorData6.BrushSBSScale = 1F;
            colorData6.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            clockHandStyleData2.HandColor = colorData6;
            clockHandStyleData2.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3;
            clockHandStyleData2.Length = 0.75F;
            clockHandStyleData2.Width = 0.175F;
            clockStyleData1.MinuteHandStyle = clockHandStyleData2;
            clockStyleData1.NumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.NumberFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            clockHandStyleData3.DrawOverCap = true;
            colorData7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData7.BorderWidth = 0.01F;
            colorData7.BrushSBSScale = 1F;
            colorData7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData7.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockHandStyleData3.HandColor = colorData7;
            clockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style4;
            clockHandStyleData3.Length = 0.9F;
            clockHandStyleData3.Width = 0.01F;
            clockStyleData1.SecondHandStyle = clockHandStyleData3;
            colorData8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData8.BorderWidth = 0.01F;
            colorData8.BrushSBSScale = 1F;
            colorData8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.SmallTickColor = colorData8;
            clockStyleData1.SmallTickLength = 0.01F;
            clockStyleData1.SmallTickWidth = 0.01F;
            clockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            this.AnalogClock.ClockStyleData = clockStyleData1;
            this.AnalogClock.Location = new System.Drawing.Point(191, 77);
            this.AnalogClock.Name = "AnalogClock";
            this.AnalogClock.Size = new System.Drawing.Size(363, 363);
            this.AnalogClock.TabIndex = 1;
            this.AnalogClock.Text = "ساعت";
            this.AnalogClock.TimeZone = "Iran Standard Time";
            this.AnalogClock.Value = new System.DateTime(2021, 12, 5, 3, 30, 55, 814);
            // 
            // sideNavPanel6
            // 
            this.sideNavPanel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel6.Location = new System.Drawing.Point(137, 31);
            this.sideNavPanel6.Name = "sideNavPanel6";
            this.sideNavPanel6.Size = new System.Drawing.Size(757, 529);
            this.sideNavPanel6.TabIndex = 26;
            this.sideNavPanel6.Visible = false;
            // 
            // sideNavPanel8
            // 
            this.sideNavPanel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel8.Location = new System.Drawing.Point(1, 1);
            this.sideNavPanel8.Name = "sideNavPanel8";
            this.sideNavPanel8.Size = new System.Drawing.Size(732, 559);
            this.sideNavPanel8.TabIndex = 34;
            this.sideNavPanel8.Visible = false;
            // 
            // sideNavPanel7
            // 
            this.sideNavPanel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel7.Location = new System.Drawing.Point(1, 1);
            this.sideNavPanel7.Name = "sideNavPanel7";
            this.sideNavPanel7.Size = new System.Drawing.Size(732, 559);
            this.sideNavPanel7.TabIndex = 30;
            this.sideNavPanel7.Visible = false;
            // 
            // sideNavPanel9
            // 
            this.sideNavPanel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel9.Location = new System.Drawing.Point(1, 1);
            this.sideNavPanel9.Name = "sideNavPanel9";
            this.sideNavPanel9.Size = new System.Drawing.Size(732, 559);
            this.sideNavPanel9.TabIndex = 38;
            this.sideNavPanel9.Visible = false;
            // 
            // sideNavPanel5
            // 
            this.sideNavPanel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sideNavPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel5.Location = new System.Drawing.Point(1, 1);
            this.sideNavPanel5.Name = "sideNavPanel5";
            this.sideNavPanel5.Size = new System.Drawing.Size(732, 559);
            this.sideNavPanel5.TabIndex = 22;
            this.sideNavPanel5.Visible = false;
            // 
            // sideNavItem1
            // 
            this.sideNavItem1.IsSystemMenu = true;
            this.sideNavItem1.Name = "sideNavItem1";
            this.sideNavItem1.Symbol = "";
            this.sideNavItem1.Text = "منو";
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // mnHome
            // 
            this.mnHome.Name = "mnHome";
            this.mnHome.Panel = this.sideNavPanel1;
            this.mnHome.Symbol = "";
            this.mnHome.Text = "خانه";
            this.mnHome.Title = "داشبورد";
            // 
            // mnReports
            // 
            this.mnReports.Name = "mnReports";
            this.mnReports.Panel = this.sideNavPanel2;
            this.mnReports.Symbol = "59621";
            this.mnReports.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.mnReports.Text = "گزارشات";
            this.mnReports.Title = "گزارشات فروش";
            // 
            // mnCustomers
            // 
            this.mnCustomers.Checked = true;
            this.mnCustomers.Name = "mnCustomers";
            this.mnCustomers.Panel = this.sideNavPanel3;
            this.mnCustomers.Symbol = "";
            this.mnCustomers.Text = "اشخاص";
            this.mnCustomers.Title = "مدیریت مشتریان";
            this.mnCustomers.Click += new System.EventHandler(this.mnCustomers_Click_1);
            // 
            // mnItems
            // 
            this.mnItems.Name = "mnItems";
            this.mnItems.Panel = this.sideNavPanel4;
            this.mnItems.Symbol = "";
            this.mnItems.Text = "کالا ها";
            this.mnItems.Title = "مدیریت اجناس";
            // 
            // mnServicesSoft
            // 
            this.mnServicesSoft.Name = "mnServicesSoft";
            this.mnServicesSoft.Panel = this.sideNavPanel5;
            this.mnServicesSoft.Symbol = "58149";
            this.mnServicesSoft.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.mnServicesSoft.Text = "خدمات نرم افزاری";
            this.mnServicesSoft.Title = "لیست خدمات نرم افزاری";
            // 
            // sideNavItem3
            // 
            this.sideNavItem3.Name = "sideNavItem3";
            this.sideNavItem3.Panel = this.sideNavPanel9;
            this.sideNavItem3.Symbol = "59497";
            this.sideNavItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem3.Text = "خدمات سخت افزاری";
            this.sideNavItem3.Title = "لیست خدمات سخت افزاری";
            // 
            // mnNewAccounting
            // 
            this.mnNewAccounting.Name = "mnNewAccounting";
            this.mnNewAccounting.Panel = this.sideNavPanel6;
            this.mnNewAccounting.Symbol = "";
            this.mnNewAccounting.Text = "تراکنش جدید";
            this.mnNewAccounting.Title = "فروش جدید";
            // 
            // sideNavItem2
            // 
            this.sideNavItem2.Name = "sideNavItem2";
            this.sideNavItem2.Panel = this.sideNavPanel7;
            this.sideNavItem2.Symbol = "59576";
            this.sideNavItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem2.Text = "تنظیمات";
            this.sideNavItem2.Title = "تنظیمات نرم افزار";
            // 
            // mnAbout
            // 
            this.mnAbout.Name = "mnAbout";
            this.mnAbout.Panel = this.sideNavPanel8;
            this.mnAbout.Symbol = "59558";
            this.mnAbout.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.mnAbout.Text = "درباره ما";
            this.mnAbout.Title = "اطلاعات برنامه نویس و فروشگاه";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 561);
            this.Controls.Add(this.sideNav1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "فروشگاه موبایل کاورلند";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideNav1.ResumeLayout(false);
            this.sideNav1.PerformLayout();
            this.sideNavPanel3.ResumeLayout(false);
            this.sideNavPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sideNavPanel1.ResumeLayout(false);
            this.sideNavPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem1;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavItem mnHome;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel2;
        private DevComponents.DotNetBar.Controls.SideNavItem mnReports;
        private DevComponents.DotNetBar.Controls.SideNav sideNav1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel8;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel7;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel9;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel5;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel6;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel4;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel3;
        private DevComponents.DotNetBar.Controls.SideNavItem mnCustomers;
        private DevComponents.DotNetBar.Controls.SideNavItem mnItems;
        private DevComponents.DotNetBar.Controls.SideNavItem mnServicesSoft;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem3;
        private DevComponents.DotNetBar.Controls.SideNavItem mnNewAccounting;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem2;
        private DevComponents.DotNetBar.Controls.SideNavItem mnAbout;
        private DevComponents.DotNetBar.Controls.AnalogClockControl AnalogClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtDateTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewCustomer;
        private System.Windows.Forms.ToolStripButton btnEditCustomer;
        private System.Windows.Forms.ToolStripButton btnDeleteCustomer;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
    }
}

