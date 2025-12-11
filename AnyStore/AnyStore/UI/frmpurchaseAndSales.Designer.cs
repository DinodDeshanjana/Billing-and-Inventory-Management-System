namespace AnyStore.UI
{
    partial class frmpurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpurchaseAndSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlDeaCust = new System.Windows.Forms.Panel();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDeaCustTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.pnlDatagridview = new System.Windows.Forms.Panel();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.lbldgvTitle = new System.Windows.Forms.Label();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReturnAmmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmmount = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblReturnAmmount = new System.Windows.Forms.Label();
            this.lblPaidAmmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCalculationtitel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlDeaCust.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDatagridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.pnlCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 61);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1406, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.White;
            this.lblTop.Location = new System.Drawing.Point(538, 11);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(321, 38);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "PURCHASE AND SALES";
            // 
            // pnlDeaCust
            // 
            this.pnlDeaCust.Controls.Add(this.dtpBillDate);
            this.pnlDeaCust.Controls.Add(this.txtAddress);
            this.pnlDeaCust.Controls.Add(this.txtContact);
            this.pnlDeaCust.Controls.Add(this.txtEmail);
            this.pnlDeaCust.Controls.Add(this.txtName);
            this.pnlDeaCust.Controls.Add(this.txtSearch);
            this.pnlDeaCust.Controls.Add(this.lblBillDate);
            this.pnlDeaCust.Controls.Add(this.lblAddress);
            this.pnlDeaCust.Controls.Add(this.lblContact);
            this.pnlDeaCust.Controls.Add(this.lblEmail);
            this.pnlDeaCust.Controls.Add(this.lblName);
            this.pnlDeaCust.Controls.Add(this.lblSearch);
            this.pnlDeaCust.Controls.Add(this.lblDeaCustTitle);
            this.pnlDeaCust.Location = new System.Drawing.Point(12, 67);
            this.pnlDeaCust.Name = "pnlDeaCust";
            this.pnlDeaCust.Size = new System.Drawing.Size(1426, 166);
            this.pnlDeaCust.TabIndex = 3;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(1116, 74);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(297, 30);
            this.dtpBillDate.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(857, 45);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 93);
            this.txtAddress.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(491, 108);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(265, 30);
            this.txtContact.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(491, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(90, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 30);
            this.txtName.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(90, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 30);
            this.txtSearch.TabIndex = 7;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(1112, 48);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(77, 23);
            this.lblBillDate.TabIndex = 6;
            this.lblBillDate.Text = "Bill Date:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(781, 48);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(407, 111);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(70, 23);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(407, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(23, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 23);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblDeaCustTitle
            // 
            this.lblDeaCustTitle.AutoSize = true;
            this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCustTitle.Location = new System.Drawing.Point(23, 11);
            this.lblDeaCustTitle.Name = "lblDeaCustTitle";
            this.lblDeaCustTitle.Size = new System.Drawing.Size(244, 23);
            this.lblDeaCustTitle.TabIndex = 0;
            this.lblDeaCustTitle.Text = "Dealer and Customer  Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.txtInventory);
            this.panel2.Controls.Add(this.txtNameProduct);
            this.panel2.Controls.Add(this.txtSearchProduct);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblRate);
            this.panel2.Controls.Add(this.lblInventory);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.lblProductSearch);
            this.panel2.Controls.Add(this.lblTitel);
            this.panel2.Location = new System.Drawing.Point(12, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 165);
            this.panel2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1293, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1306, 49);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(107, 30);
            this.txtQty.TabIndex = 10;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(1141, 49);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(112, 30);
            this.txtRate.TabIndex = 9;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(823, 49);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(255, 30);
            this.txtInventory.TabIndex = 8;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.Location = new System.Drawing.Point(425, 51);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(303, 30);
            this.txtNameProduct.TabIndex = 7;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(88, 51);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(269, 30);
            this.txtSearchProduct.TabIndex = 6;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(1259, 52);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(41, 23);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Qty.";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(1090, 52);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(45, 23);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Rate";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(734, 54);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(85, 23);
            this.lblInventory.TabIndex = 3;
            this.lblInventory.Text = "Inventory";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(363, 52);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(56, 23);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Name";
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.Location = new System.Drawing.Point(23, 54);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(61, 23);
            this.lblProductSearch.TabIndex = 1;
            this.lblProductSearch.Text = "Search";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(23, 11);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(133, 23);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Product Details";
            // 
            // pnlDatagridview
            // 
            this.pnlDatagridview.Controls.Add(this.dgvAddedProducts);
            this.pnlDatagridview.Controls.Add(this.lbldgvTitle);
            this.pnlDatagridview.Location = new System.Drawing.Point(12, 441);
            this.pnlDatagridview.Name = "pnlDatagridview";
            this.pnlDatagridview.Size = new System.Drawing.Size(1020, 381);
            this.pnlDatagridview.TabIndex = 5;
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(27, 46);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.RowTemplate.Height = 24;
            this.dgvAddedProducts.Size = new System.Drawing.Size(977, 322);
            this.dgvAddedProducts.TabIndex = 1;
            // 
            // lbldgvTitle
            // 
            this.lbldgvTitle.AutoSize = true;
            this.lbldgvTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldgvTitle.Location = new System.Drawing.Point(23, 16);
            this.lbldgvTitle.Name = "lbldgvTitle";
            this.lbldgvTitle.Size = new System.Drawing.Size(139, 23);
            this.lbldgvTitle.TabIndex = 0;
            this.lbldgvTitle.Text = "Added Products";
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.Controls.Add(this.btnSave);
            this.pnlCalculation.Controls.Add(this.txtReturnAmmount);
            this.pnlCalculation.Controls.Add(this.txtPaidAmmount);
            this.pnlCalculation.Controls.Add(this.txtGrandTotal);
            this.pnlCalculation.Controls.Add(this.txtVat);
            this.pnlCalculation.Controls.Add(this.txtDiscount);
            this.pnlCalculation.Controls.Add(this.txtSubTotal);
            this.pnlCalculation.Controls.Add(this.lblReturnAmmount);
            this.pnlCalculation.Controls.Add(this.lblPaidAmmount);
            this.pnlCalculation.Controls.Add(this.lblGrandTotal);
            this.pnlCalculation.Controls.Add(this.lblVat);
            this.pnlCalculation.Controls.Add(this.lblDiscount);
            this.pnlCalculation.Controls.Add(this.lblTotal);
            this.pnlCalculation.Controls.Add(this.lblCalculationtitel);
            this.pnlCalculation.Location = new System.Drawing.Point(1038, 441);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(400, 381);
            this.pnlCalculation.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(267, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 49);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtReturnAmmount
            // 
            this.txtReturnAmmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAmmount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtReturnAmmount.Location = new System.Drawing.Point(174, 274);
            this.txtReturnAmmount.Name = "txtReturnAmmount";
            this.txtReturnAmmount.ReadOnly = true;
            this.txtReturnAmmount.Size = new System.Drawing.Size(208, 30);
            this.txtReturnAmmount.TabIndex = 12;
            // 
            // txtPaidAmmount
            // 
            this.txtPaidAmmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmmount.Location = new System.Drawing.Point(173, 227);
            this.txtPaidAmmount.Name = "txtPaidAmmount";
            this.txtPaidAmmount.Size = new System.Drawing.Size(208, 30);
            this.txtPaidAmmount.TabIndex = 11;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(174, 184);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(208, 30);
            this.txtGrandTotal.TabIndex = 10;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(173, 145);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(208, 30);
            this.txtVat.TabIndex = 9;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(174, 102);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(209, 30);
            this.txtDiscount.TabIndex = 8;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(174, 59);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(209, 30);
            this.txtSubTotal.TabIndex = 7;
            // 
            // lblReturnAmmount
            // 
            this.lblReturnAmmount.AutoSize = true;
            this.lblReturnAmmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmmount.Location = new System.Drawing.Point(13, 277);
            this.lblReturnAmmount.Name = "lblReturnAmmount";
            this.lblReturnAmmount.Size = new System.Drawing.Size(144, 23);
            this.lblReturnAmmount.TabIndex = 6;
            this.lblReturnAmmount.Text = "Return Ammount";
            // 
            // lblPaidAmmount
            // 
            this.lblPaidAmmount.AutoSize = true;
            this.lblPaidAmmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmmount.Location = new System.Drawing.Point(13, 234);
            this.lblPaidAmmount.Name = "lblPaidAmmount";
            this.lblPaidAmmount.Size = new System.Drawing.Size(125, 23);
            this.lblPaidAmmount.TabIndex = 5;
            this.lblPaidAmmount.Text = "Paid Ammount";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(13, 191);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(98, 23);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(13, 148);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(39, 23);
            this.lblVat.TabIndex = 3;
            this.lblVat.Text = "VAT";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(13, 105);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(108, 23);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(13, 62);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 23);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Sub Total";
            // 
            // lblCalculationtitel
            // 
            this.lblCalculationtitel.AutoSize = true;
            this.lblCalculationtitel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculationtitel.Location = new System.Drawing.Point(13, 16);
            this.lblCalculationtitel.Name = "lblCalculationtitel";
            this.lblCalculationtitel.Size = new System.Drawing.Size(157, 23);
            this.lblCalculationtitel.TabIndex = 0;
            this.lblCalculationtitel.Text = "Calculation details";
            // 
            // frmpurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1450, 834);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.pnlDatagridview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDeaCust);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmpurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase and Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlDeaCust.ResumeLayout(false);
            this.pnlDeaCust.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDatagridview.ResumeLayout(false);
            this.pnlDatagridview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlDeaCust;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDeaCustTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Panel pnlDatagridview;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.Label lbldgvTitle;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.TextBox txtReturnAmmount;
        private System.Windows.Forms.TextBox txtPaidAmmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblReturnAmmount;
        private System.Windows.Forms.Label lblPaidAmmount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCalculationtitel;
        private System.Windows.Forms.Button btnSave;
    }
}