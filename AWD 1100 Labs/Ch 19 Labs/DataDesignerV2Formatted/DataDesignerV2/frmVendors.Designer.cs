
namespace DataDesignerV2
{
    partial class frmVendors
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
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorStreetAddressLabel;
            System.Windows.Forms.Label vendorCityLabel;
            System.Windows.Forms.Label vendorPhoneNumberLabel;
            System.Windows.Forms.Label vendorFaxNumberLabel;
            System.Windows.Forms.Label vendorWebPageLabel;
            System.Windows.Forms.Label vendorEMailAddressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendors));
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.salesOrdersDataSet = new DataDesignerV2.salesOrdersDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new DataDesignerV2.salesOrdersDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager();
            this.statesTableAdapter = new DataDesignerV2.salesOrdersDataSetTableAdapters.StatesTableAdapter();
            this.vendorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vendorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vendorIDLabel1 = new System.Windows.Forms.Label();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorStreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.vendorCityTextBox = new System.Windows.Forms.TextBox();
            this.vendorZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.vendorFaxNumberTextBox = new System.Windows.Forms.TextBox();
            this.vendorWebPageTextBox = new System.Windows.Forms.TextBox();
            this.vendorEMailAddressTextBox = new System.Windows.Forms.TextBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.vendorStateComboBox = new System.Windows.Forms.ComboBox();
            this.fillByVendorIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.vendorIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByVendorIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            vendorIDLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorStreetAddressLabel = new System.Windows.Forms.Label();
            vendorCityLabel = new System.Windows.Forms.Label();
            vendorPhoneNumberLabel = new System.Windows.Forms.Label();
            vendorFaxNumberLabel = new System.Windows.Forms.Label();
            vendorWebPageLabel = new System.Windows.Forms.Label();
            vendorEMailAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).BeginInit();
            this.vendorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.fillByVendorIdToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorIDLabel.Location = new System.Drawing.Point(274, 168);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(96, 20);
            vendorIDLabel.TabIndex = 18;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorNameLabel.Location = new System.Drawing.Point(247, 217);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(123, 20);
            vendorNameLabel.TabIndex = 19;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorStreetAddressLabel
            // 
            vendorStreetAddressLabel.AutoSize = true;
            vendorStreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorStreetAddressLabel.Location = new System.Drawing.Point(172, 273);
            vendorStreetAddressLabel.Name = "vendorStreetAddressLabel";
            vendorStreetAddressLabel.Size = new System.Drawing.Size(198, 20);
            vendorStreetAddressLabel.TabIndex = 20;
            vendorStreetAddressLabel.Text = "Vendor Street Address:";
            // 
            // vendorCityLabel
            // 
            vendorCityLabel.AutoSize = true;
            vendorCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorCityLabel.Location = new System.Drawing.Point(162, 332);
            vendorCityLabel.Name = "vendorCityLabel";
            vendorCityLabel.Size = new System.Drawing.Size(206, 20);
            vendorCityLabel.TabIndex = 21;
            vendorCityLabel.Text = "Vendor City / State / Zip:";
            // 
            // vendorPhoneNumberLabel
            // 
            vendorPhoneNumberLabel.AutoSize = true;
            vendorPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorPhoneNumberLabel.Location = new System.Drawing.Point(149, 388);
            vendorPhoneNumberLabel.Name = "vendorPhoneNumberLabel";
            vendorPhoneNumberLabel.Size = new System.Drawing.Size(195, 20);
            vendorPhoneNumberLabel.TabIndex = 23;
            vendorPhoneNumberLabel.Text = "Vendor Phone Number:";
            // 
            // vendorFaxNumberLabel
            // 
            vendorFaxNumberLabel.AutoSize = true;
            vendorFaxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorFaxNumberLabel.Location = new System.Drawing.Point(590, 385);
            vendorFaxNumberLabel.Name = "vendorFaxNumberLabel";
            vendorFaxNumberLabel.Size = new System.Drawing.Size(173, 20);
            vendorFaxNumberLabel.TabIndex = 24;
            vendorFaxNumberLabel.Text = "Vendor Fax Number:";
            // 
            // vendorWebPageLabel
            // 
            vendorWebPageLabel.AutoSize = true;
            vendorWebPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorWebPageLabel.Location = new System.Drawing.Point(149, 437);
            vendorWebPageLabel.Name = "vendorWebPageLabel";
            vendorWebPageLabel.Size = new System.Drawing.Size(159, 20);
            vendorWebPageLabel.TabIndex = 25;
            vendorWebPageLabel.Text = "Vendor Web Page:";
            // 
            // vendorEMailAddressLabel
            // 
            vendorEMailAddressLabel.AutoSize = true;
            vendorEMailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorEMailAddressLabel.Location = new System.Drawing.Point(581, 440);
            vendorEMailAddressLabel.Name = "vendorEMailAddressLabel";
            vendorEMailAddressLabel.Size = new System.Drawing.Size(192, 20);
            vendorEMailAddressLabel.TabIndex = 26;
            vendorEMailAddressLabel.Text = "Vendor Email Address:";
            // 
            // btnProductVendors
            // 
            this.btnProductVendors.BackColor = System.Drawing.Color.Blue;
            this.btnProductVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductVendors.ForeColor = System.Drawing.Color.White;
            this.btnProductVendors.Location = new System.Drawing.Point(1024, 528);
            this.btnProductVendors.Name = "btnProductVendors";
            this.btnProductVendors.Size = new System.Drawing.Size(120, 84);
            this.btnProductVendors.TabIndex = 17;
            this.btnProductVendors.Text = "Product Vendors";
            this.btnProductVendors.UseVisualStyleBackColor = false;
            this.btnProductVendors.Click += new System.EventHandler(this.btnProductVendors_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Blue;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(877, 528);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 84);
            this.btnProducts.TabIndex = 16;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.Color.Blue;
            this.btnOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnOrderDetails.Location = new System.Drawing.Point(731, 528);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(120, 84);
            this.btnOrderDetails.TabIndex = 15;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Blue;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(585, 528);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(120, 84);
            this.btnOrders.TabIndex = 14;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Blue;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(442, 528);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 84);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Blue;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(298, 528);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 84);
            this.btnEmployees.TabIndex = 12;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Blue;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(153, 528);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(120, 84);
            this.btnCategories.TabIndex = 11;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Blue;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(10, 528);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(120, 84);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "salesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsBindingNavigator
            // 
            this.vendorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendorsBindingNavigator.BindingSource = this.vendorsBindingSource;
            this.vendorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.vendorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendorsBindingNavigatorSaveItem});
            this.vendorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendorsBindingNavigator.Name = "vendorsBindingNavigator";
            this.vendorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendorsBindingNavigator.Size = new System.Drawing.Size(1182, 33);
            this.vendorsBindingNavigator.TabIndex = 18;
            this.vendorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // vendorsBindingNavigatorSaveItem
            // 
            this.vendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendorsBindingNavigatorSaveItem.Image")));
            this.vendorsBindingNavigatorSaveItem.Name = "vendorsBindingNavigatorSaveItem";
            this.vendorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.vendorsBindingNavigatorSaveItem.Text = "Save Data";
            this.vendorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendorsBindingNavigatorSaveItem_Click);
            // 
            // vendorIDLabel1
            // 
            this.vendorIDLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.vendorIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorID", true));
            this.vendorIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorIDLabel1.Location = new System.Drawing.Point(401, 168);
            this.vendorIDLabel1.Name = "vendorIDLabel1";
            this.vendorIDLabel1.Size = new System.Drawing.Size(362, 23);
            this.vendorIDLabel1.TabIndex = 19;
            this.vendorIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorName", true));
            this.vendorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorNameTextBox.Location = new System.Drawing.Point(405, 214);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(358, 26);
            this.vendorNameTextBox.TabIndex = 20;
            this.vendorNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendorStreetAddressTextBox
            // 
            this.vendorStreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorStreetAddress", true));
            this.vendorStreetAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorStreetAddressTextBox.Location = new System.Drawing.Point(405, 267);
            this.vendorStreetAddressTextBox.Name = "vendorStreetAddressTextBox";
            this.vendorStreetAddressTextBox.Size = new System.Drawing.Size(358, 26);
            this.vendorStreetAddressTextBox.TabIndex = 21;
            this.vendorStreetAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendorCityTextBox
            // 
            this.vendorCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorCity", true));
            this.vendorCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorCityTextBox.Location = new System.Drawing.Point(405, 330);
            this.vendorCityTextBox.Name = "vendorCityTextBox";
            this.vendorCityTextBox.Size = new System.Drawing.Size(158, 26);
            this.vendorCityTextBox.TabIndex = 22;
            this.vendorCityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendorZipCodeTextBox
            // 
            this.vendorZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorZipCode", true));
            this.vendorZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorZipCodeTextBox.Location = new System.Drawing.Point(663, 332);
            this.vendorZipCodeTextBox.Name = "vendorZipCodeTextBox";
            this.vendorZipCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.vendorZipCodeTextBox.TabIndex = 23;
            this.vendorZipCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendorPhoneNumberTextBox
            // 
            this.vendorPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorPhoneNumber", true));
            this.vendorPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorPhoneNumberTextBox.Location = new System.Drawing.Point(389, 379);
            this.vendorPhoneNumberTextBox.Name = "vendorPhoneNumberTextBox";
            this.vendorPhoneNumberTextBox.Size = new System.Drawing.Size(173, 26);
            this.vendorPhoneNumberTextBox.TabIndex = 24;
            this.vendorPhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendorFaxNumberTextBox
            // 
            this.vendorFaxNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorFaxNumber", true));
            this.vendorFaxNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorFaxNumberTextBox.Location = new System.Drawing.Point(856, 379);
            this.vendorFaxNumberTextBox.Name = "vendorFaxNumberTextBox";
            this.vendorFaxNumberTextBox.Size = new System.Drawing.Size(173, 26);
            this.vendorFaxNumberTextBox.TabIndex = 25;
            this.vendorFaxNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendorWebPageTextBox
            // 
            this.vendorWebPageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorWebPage", true));
            this.vendorWebPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorWebPageTextBox.Location = new System.Drawing.Point(322, 434);
            this.vendorWebPageTextBox.Name = "vendorWebPageTextBox";
            this.vendorWebPageTextBox.Size = new System.Drawing.Size(241, 26);
            this.vendorWebPageTextBox.TabIndex = 26;
            this.vendorWebPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendorEMailAddressTextBox
            // 
            this.vendorEMailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorEMailAddress", true));
            this.vendorEMailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorEMailAddressTextBox.Location = new System.Drawing.Point(788, 437);
            this.vendorEMailAddressTextBox.Name = "vendorEMailAddressTextBox";
            this.vendorEMailAddressTextBox.Size = new System.Drawing.Size(241, 26);
            this.vendorEMailAddressTextBox.TabIndex = 27;
            this.vendorEMailAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Vendors Table";
            // 
            // vendorStateComboBox
            // 
            this.vendorStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorState", true));
            this.vendorStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "VendorState", true));
            this.vendorStateComboBox.DataSource = this.statesBindingSource;
            this.vendorStateComboBox.DisplayMember = "StateAbbrev";
            this.vendorStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorStateComboBox.FormattingEnabled = true;
            this.vendorStateComboBox.Location = new System.Drawing.Point(573, 330);
            this.vendorStateComboBox.Name = "vendorStateComboBox";
            this.vendorStateComboBox.Size = new System.Drawing.Size(84, 28);
            this.vendorStateComboBox.TabIndex = 30;
            this.vendorStateComboBox.ValueMember = "StateAbbrev";
            // 
            // fillByVendorIdToolStrip
            // 
            this.fillByVendorIdToolStrip.BackColor = System.Drawing.Color.Blue;
            this.fillByVendorIdToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByVendorIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorIDToolStripLabel,
            this.vendorIDToolStripTextBox,
            this.fillByVendorIdToolStripButton});
            this.fillByVendorIdToolStrip.Location = new System.Drawing.Point(0, 33);
            this.fillByVendorIdToolStrip.Name = "fillByVendorIdToolStrip";
            this.fillByVendorIdToolStrip.Size = new System.Drawing.Size(1182, 34);
            this.fillByVendorIdToolStrip.TabIndex = 31;
            this.fillByVendorIdToolStrip.Text = "fillByVendorIdToolStrip";
            // 
            // vendorIDToolStripLabel
            // 
            this.vendorIDToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vendorIDToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.vendorIDToolStripLabel.Name = "vendorIDToolStripLabel";
            this.vendorIDToolStripLabel.Size = new System.Drawing.Size(97, 29);
            this.vendorIDToolStripLabel.Text = "VendorID:";
            // 
            // vendorIDToolStripTextBox
            // 
            this.vendorIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vendorIDToolStripTextBox.Name = "vendorIDToolStripTextBox";
            this.vendorIDToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByVendorIdToolStripButton
            // 
            this.fillByVendorIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByVendorIdToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fillByVendorIdToolStripButton.ForeColor = System.Drawing.Color.White;
            this.fillByVendorIdToolStripButton.Name = "fillByVendorIdToolStripButton";
            this.fillByVendorIdToolStripButton.Size = new System.Drawing.Size(140, 29);
            this.fillByVendorIdToolStripButton.Text = "FillByVendorId";
            this.fillByVendorIdToolStripButton.Click += new System.EventHandler(this.fillByVendorIdToolStripButton_Click);
            // 
            // frmVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.fillByVendorIdToolStrip);
            this.Controls.Add(this.vendorStateComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(vendorEMailAddressLabel);
            this.Controls.Add(this.vendorEMailAddressTextBox);
            this.Controls.Add(vendorWebPageLabel);
            this.Controls.Add(this.vendorWebPageTextBox);
            this.Controls.Add(vendorFaxNumberLabel);
            this.Controls.Add(this.vendorFaxNumberTextBox);
            this.Controls.Add(vendorPhoneNumberLabel);
            this.Controls.Add(this.vendorPhoneNumberTextBox);
            this.Controls.Add(this.vendorZipCodeTextBox);
            this.Controls.Add(vendorCityLabel);
            this.Controls.Add(this.vendorCityTextBox);
            this.Controls.Add(vendorStreetAddressLabel);
            this.Controls.Add(this.vendorStreetAddressTextBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDLabel1);
            this.Controls.Add(this.vendorsBindingNavigator);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnCustomers);
            this.Name = "frmVendors";
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.frmVendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).EndInit();
            this.vendorsBindingNavigator.ResumeLayout(false);
            this.vendorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.fillByVendorIdToolStrip.ResumeLayout(false);
            this.fillByVendorIdToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductVendors;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCustomers;
        private salesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private salesOrdersDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private salesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vendorsBindingNavigatorSaveItem;
        private salesOrdersDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.Label vendorIDLabel1;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox vendorStreetAddressTextBox;
        private System.Windows.Forms.TextBox vendorCityTextBox;
        private System.Windows.Forms.TextBox vendorZipCodeTextBox;
        private System.Windows.Forms.TextBox vendorPhoneNumberTextBox;
        private System.Windows.Forms.TextBox vendorFaxNumberTextBox;
        private System.Windows.Forms.TextBox vendorWebPageTextBox;
        private System.Windows.Forms.TextBox vendorEMailAddressTextBox;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vendorStateComboBox;
        private System.Windows.Forms.ToolStrip fillByVendorIdToolStrip;
        private System.Windows.Forms.ToolStripLabel vendorIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendorIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByVendorIdToolStripButton;
    }
}