
namespace DataDesignerV2
{
    partial class frmEmployees
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label employeeFirstNameLabel;
            System.Windows.Forms.Label employeeLastNameLabel;
            System.Windows.Forms.Label employeeStreetAddressLabel;
            System.Windows.Forms.Label employeeCityLabel;
            System.Windows.Forms.Label employeePhoneNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrdersDataSet = new DataDesignerV2.salesOrdersDataSet();
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
            this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeIDLabel1 = new System.Windows.Forms.Label();
            this.employeeFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeStreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.employeeCityTextBox = new System.Windows.Forms.TextBox();
            this.employeeZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.employeeAreaCodeTextBox = new System.Windows.Forms.TextBox();
            this.employeePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeesTableAdapter = new DataDesignerV2.salesOrdersDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new DataDesignerV2.salesOrdersDataSetTableAdapters.StatesTableAdapter();
            this.employeeStateComboBox = new System.Windows.Forms.ComboBox();
            this.fillByEmployeeIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.employeeIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.employeeIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEmployeeIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            employeeIDLabel = new System.Windows.Forms.Label();
            employeeFirstNameLabel = new System.Windows.Forms.Label();
            employeeLastNameLabel = new System.Windows.Forms.Label();
            employeeStreetAddressLabel = new System.Windows.Forms.Label();
            employeeCityLabel = new System.Windows.Forms.Label();
            employeePhoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.fillByEmployeeIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(336, 134);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(116, 20);
            employeeIDLabel.TabIndex = 19;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeFirstNameLabel
            // 
            employeeFirstNameLabel.AutoSize = true;
            employeeFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeFirstNameLabel.Location = new System.Drawing.Point(268, 179);
            employeeFirstNameLabel.Name = "employeeFirstNameLabel";
            employeeFirstNameLabel.Size = new System.Drawing.Size(184, 20);
            employeeFirstNameLabel.TabIndex = 20;
            employeeFirstNameLabel.Text = "Employee First Name:";
            // 
            // employeeLastNameLabel
            // 
            employeeLastNameLabel.AutoSize = true;
            employeeLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeLastNameLabel.Location = new System.Drawing.Point(269, 226);
            employeeLastNameLabel.Name = "employeeLastNameLabel";
            employeeLastNameLabel.Size = new System.Drawing.Size(183, 20);
            employeeLastNameLabel.TabIndex = 21;
            employeeLastNameLabel.Text = "Employee Last Name:";
            // 
            // employeeStreetAddressLabel
            // 
            employeeStreetAddressLabel.AutoSize = true;
            employeeStreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeStreetAddressLabel.Location = new System.Drawing.Point(234, 274);
            employeeStreetAddressLabel.Name = "employeeStreetAddressLabel";
            employeeStreetAddressLabel.Size = new System.Drawing.Size(218, 20);
            employeeStreetAddressLabel.TabIndex = 22;
            employeeStreetAddressLabel.Text = "Employee Street Address:";
            // 
            // employeeCityLabel
            // 
            employeeCityLabel.AutoSize = true;
            employeeCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeCityLabel.Location = new System.Drawing.Point(246, 326);
            employeeCityLabel.Name = "employeeCityLabel";
            employeeCityLabel.Size = new System.Drawing.Size(206, 20);
            employeeCityLabel.TabIndex = 23;
            employeeCityLabel.Text = "Employee City/State/Zip:";
            // 
            // employeePhoneNumberLabel
            // 
            employeePhoneNumberLabel.AutoSize = true;
            employeePhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeePhoneNumberLabel.Location = new System.Drawing.Point(237, 375);
            employeePhoneNumberLabel.Name = "employeePhoneNumberLabel";
            employeePhoneNumberLabel.Size = new System.Drawing.Size(215, 20);
            employeePhoneNumberLabel.TabIndex = 27;
            employeePhoneNumberLabel.Text = "Employee Phone Number:";
            // 
            // btnVendors
            // 
            this.btnVendors.BackColor = System.Drawing.Color.Blue;
            this.btnVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.ForeColor = System.Drawing.Color.White;
            this.btnVendors.Location = new System.Drawing.Point(1028, 483);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(120, 84);
            this.btnVendors.TabIndex = 17;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = false;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnProductVendors
            // 
            this.btnProductVendors.BackColor = System.Drawing.Color.Blue;
            this.btnProductVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductVendors.ForeColor = System.Drawing.Color.White;
            this.btnProductVendors.Location = new System.Drawing.Point(891, 483);
            this.btnProductVendors.Name = "btnProductVendors";
            this.btnProductVendors.Size = new System.Drawing.Size(120, 84);
            this.btnProductVendors.TabIndex = 16;
            this.btnProductVendors.Text = "Product Vendors";
            this.btnProductVendors.UseVisualStyleBackColor = false;
            this.btnProductVendors.Click += new System.EventHandler(this.btnProductVendors_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Blue;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(743, 483);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 84);
            this.btnProducts.TabIndex = 15;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.Color.Blue;
            this.btnOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnOrderDetails.Location = new System.Drawing.Point(603, 483);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(120, 84);
            this.btnOrderDetails.TabIndex = 14;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Blue;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(465, 483);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(120, 84);
            this.btnOrders.TabIndex = 13;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Blue;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(321, 483);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 84);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Blue;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(176, 483);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(120, 84);
            this.btnCustomers.TabIndex = 11;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Blue;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(32, 483);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(120, 84);
            this.btnCategories.TabIndex = 10;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employees Table";
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeesBindingNavigatorSaveItem});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(1188, 33);
            this.employeesBindingNavigator.TabIndex = 19;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
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
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "salesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // employeesBindingNavigatorSaveItem
            // 
            this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
            this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
            this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.employeesBindingNavigatorSaveItem.Text = "Save Data";
            this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
            // 
            // employeeIDLabel1
            // 
            this.employeeIDLabel1.BackColor = System.Drawing.Color.Magenta;
            this.employeeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeID", true));
            this.employeeIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel1.Location = new System.Drawing.Point(481, 131);
            this.employeeIDLabel1.Name = "employeeIDLabel1";
            this.employeeIDLabel1.Size = new System.Drawing.Size(394, 23);
            this.employeeIDLabel1.TabIndex = 20;
            this.employeeIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeFirstNameTextBox
            // 
            this.employeeFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeFirstName", true));
            this.employeeFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeFirstNameTextBox.Location = new System.Drawing.Point(485, 173);
            this.employeeFirstNameTextBox.Name = "employeeFirstNameTextBox";
            this.employeeFirstNameTextBox.Size = new System.Drawing.Size(390, 26);
            this.employeeFirstNameTextBox.TabIndex = 21;
            // 
            // employeeLastNameTextBox
            // 
            this.employeeLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeLastName", true));
            this.employeeLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLastNameTextBox.Location = new System.Drawing.Point(485, 220);
            this.employeeLastNameTextBox.Name = "employeeLastNameTextBox";
            this.employeeLastNameTextBox.Size = new System.Drawing.Size(390, 26);
            this.employeeLastNameTextBox.TabIndex = 22;
            // 
            // employeeStreetAddressTextBox
            // 
            this.employeeStreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeStreetAddress", true));
            this.employeeStreetAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeStreetAddressTextBox.Location = new System.Drawing.Point(485, 268);
            this.employeeStreetAddressTextBox.Name = "employeeStreetAddressTextBox";
            this.employeeStreetAddressTextBox.Size = new System.Drawing.Size(390, 26);
            this.employeeStreetAddressTextBox.TabIndex = 23;
            // 
            // employeeCityTextBox
            // 
            this.employeeCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeCity", true));
            this.employeeCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCityTextBox.Location = new System.Drawing.Point(485, 316);
            this.employeeCityTextBox.Name = "employeeCityTextBox";
            this.employeeCityTextBox.Size = new System.Drawing.Size(169, 26);
            this.employeeCityTextBox.TabIndex = 24;
            // 
            // employeeZipCodeTextBox
            // 
            this.employeeZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeZipCode", true));
            this.employeeZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeZipCodeTextBox.Location = new System.Drawing.Point(766, 318);
            this.employeeZipCodeTextBox.Name = "employeeZipCodeTextBox";
            this.employeeZipCodeTextBox.Size = new System.Drawing.Size(109, 26);
            this.employeeZipCodeTextBox.TabIndex = 26;
            // 
            // employeeAreaCodeTextBox
            // 
            this.employeeAreaCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeAreaCode", true));
            this.employeeAreaCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeAreaCodeTextBox.Location = new System.Drawing.Point(485, 369);
            this.employeeAreaCodeTextBox.Name = "employeeAreaCodeTextBox";
            this.employeeAreaCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.employeeAreaCodeTextBox.TabIndex = 27;
            // 
            // employeePhoneNumberTextBox
            // 
            this.employeePhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeePhoneNumber", true));
            this.employeePhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePhoneNumberTextBox.Location = new System.Drawing.Point(591, 369);
            this.employeePhoneNumberTextBox.Name = "employeePhoneNumberTextBox";
            this.employeePhoneNumberTextBox.Size = new System.Drawing.Size(284, 26);
            this.employeePhoneNumberTextBox.TabIndex = 28;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeStateComboBox
            // 
            this.employeeStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeState", true));
            this.employeeStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "EmployeeState", true));
            this.employeeStateComboBox.DataSource = this.statesBindingSource;
            this.employeeStateComboBox.DisplayMember = "StateAbbrev";
            this.employeeStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeStateComboBox.FormattingEnabled = true;
            this.employeeStateComboBox.Location = new System.Drawing.Point(667, 316);
            this.employeeStateComboBox.Name = "employeeStateComboBox";
            this.employeeStateComboBox.Size = new System.Drawing.Size(93, 28);
            this.employeeStateComboBox.TabIndex = 29;
            this.employeeStateComboBox.ValueMember = "StateAbbrev";
            // 
            // fillByEmployeeIDToolStrip
            // 
            this.fillByEmployeeIDToolStrip.BackColor = System.Drawing.Color.Blue;
            this.fillByEmployeeIDToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByEmployeeIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeIDToolStripLabel,
            this.employeeIDToolStripTextBox,
            this.fillByEmployeeIDToolStripButton});
            this.fillByEmployeeIDToolStrip.Location = new System.Drawing.Point(0, 33);
            this.fillByEmployeeIDToolStrip.Name = "fillByEmployeeIDToolStrip";
            this.fillByEmployeeIDToolStrip.Size = new System.Drawing.Size(1188, 34);
            this.fillByEmployeeIDToolStrip.TabIndex = 30;
            this.fillByEmployeeIDToolStrip.Text = "fillByEmployeeIDToolStrip";
            // 
            // employeeIDToolStripLabel
            // 
            this.employeeIDToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIDToolStripLabel.Name = "employeeIDToolStripLabel";
            this.employeeIDToolStripLabel.Size = new System.Drawing.Size(119, 29);
            this.employeeIDToolStripLabel.Text = "EmployeeID:";
            // 
            // employeeIDToolStripTextBox
            // 
            this.employeeIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.employeeIDToolStripTextBox.Name = "employeeIDToolStripTextBox";
            this.employeeIDToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByEmployeeIDToolStripButton
            // 
            this.fillByEmployeeIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEmployeeIDToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByEmployeeIDToolStripButton.ForeColor = System.Drawing.Color.White;
            this.fillByEmployeeIDToolStripButton.Name = "fillByEmployeeIDToolStripButton";
            this.fillByEmployeeIDToolStripButton.Size = new System.Drawing.Size(164, 29);
            this.fillByEmployeeIDToolStripButton.Text = "FillByEmployeeID";
            this.fillByEmployeeIDToolStripButton.Click += new System.EventHandler(this.fillByEmployeeIDToolStripButton_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1188, 661);
            this.Controls.Add(this.fillByEmployeeIDToolStrip);
            this.Controls.Add(this.employeeStateComboBox);
            this.Controls.Add(employeePhoneNumberLabel);
            this.Controls.Add(this.employeePhoneNumberTextBox);
            this.Controls.Add(this.employeeAreaCodeTextBox);
            this.Controls.Add(this.employeeZipCodeTextBox);
            this.Controls.Add(employeeCityLabel);
            this.Controls.Add(this.employeeCityTextBox);
            this.Controls.Add(employeeStreetAddressLabel);
            this.Controls.Add(this.employeeStreetAddressTextBox);
            this.Controls.Add(employeeLastNameLabel);
            this.Controls.Add(this.employeeLastNameTextBox);
            this.Controls.Add(employeeFirstNameLabel);
            this.Controls.Add(this.employeeFirstNameTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDLabel1);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCategories);
            this.Name = "frmEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.fillByEmployeeIDToolStrip.ResumeLayout(false);
            this.fillByEmployeeIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnProductVendors;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Label label1;
        private salesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private salesOrdersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private salesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label employeeIDLabel1;
        private System.Windows.Forms.TextBox employeeFirstNameTextBox;
        private System.Windows.Forms.TextBox employeeLastNameTextBox;
        private System.Windows.Forms.TextBox employeeStreetAddressTextBox;
        private System.Windows.Forms.TextBox employeeCityTextBox;
        private System.Windows.Forms.TextBox employeeZipCodeTextBox;
        private System.Windows.Forms.TextBox employeeAreaCodeTextBox;
        private System.Windows.Forms.TextBox employeePhoneNumberTextBox;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private salesOrdersDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.ComboBox employeeStateComboBox;
        private System.Windows.Forms.ToolStrip fillByEmployeeIDToolStrip;
        private System.Windows.Forms.ToolStripLabel employeeIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox employeeIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEmployeeIDToolStripButton;
    }
}