
namespace DataDesignerV2
{
    partial class frmProductVendors
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label productVendorWholesalePriceLabel;
            System.Windows.Forms.Label productVendorDaysToDeliverLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductVendors));
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.productVendorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productVendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.productVendorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productIDLabel1 = new System.Windows.Forms.Label();
            this.vendorIDLabel1 = new System.Windows.Forms.Label();
            this.txtPVWholeSale = new System.Windows.Forms.TextBox();
            this.productVendorDaysToDeliverTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fillByProductIDAndVendorIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.productIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.vendorIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByProductIDAndVendorIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productVendorsTableAdapter = new DataDesignerV2.salesOrdersDataSetTableAdapters.ProductVendorsTableAdapter();
            this.tableAdapterManager = new DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager();
            productIDLabel = new System.Windows.Forms.Label();
            vendorIDLabel = new System.Windows.Forms.Label();
            productVendorWholesalePriceLabel = new System.Windows.Forms.Label();
            productVendorDaysToDeliverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productVendorsBindingNavigator)).BeginInit();
            this.productVendorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productVendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            this.fillByProductIDAndVendorIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIDLabel.Location = new System.Drawing.Point(372, 216);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(100, 20);
            productIDLabel.TabIndex = 18;
            productIDLabel.Text = "Product ID:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendorIDLabel.Location = new System.Drawing.Point(376, 269);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(96, 20);
            vendorIDLabel.TabIndex = 19;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // productVendorWholesalePriceLabel
            // 
            productVendorWholesalePriceLabel.AutoSize = true;
            productVendorWholesalePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productVendorWholesalePriceLabel.Location = new System.Drawing.Point(200, 327);
            productVendorWholesalePriceLabel.Name = "productVendorWholesalePriceLabel";
            productVendorWholesalePriceLabel.Size = new System.Drawing.Size(272, 20);
            productVendorWholesalePriceLabel.TabIndex = 20;
            productVendorWholesalePriceLabel.Text = "Product Vendor Wholesale Price:";
            // 
            // productVendorDaysToDeliverLabel
            // 
            productVendorDaysToDeliverLabel.AutoSize = true;
            productVendorDaysToDeliverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productVendorDaysToDeliverLabel.Location = new System.Drawing.Point(203, 377);
            productVendorDaysToDeliverLabel.Name = "productVendorDaysToDeliverLabel";
            productVendorDaysToDeliverLabel.Size = new System.Drawing.Size(269, 20);
            productVendorDaysToDeliverLabel.TabIndex = 21;
            productVendorDaysToDeliverLabel.Text = "Product Vendor Days To Deliver:";
            // 
            // btnVendors
            // 
            this.btnVendors.BackColor = System.Drawing.Color.Blue;
            this.btnVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.ForeColor = System.Drawing.Color.White;
            this.btnVendors.Location = new System.Drawing.Point(1024, 471);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(120, 84);
            this.btnVendors.TabIndex = 17;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = false;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Blue;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(877, 471);
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
            this.btnOrderDetails.Location = new System.Drawing.Point(731, 471);
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
            this.btnOrders.Location = new System.Drawing.Point(585, 471);
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
            this.btnHome.Location = new System.Drawing.Point(442, 471);
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
            this.btnEmployees.Location = new System.Drawing.Point(298, 471);
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
            this.btnCategories.Location = new System.Drawing.Point(153, 471);
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
            this.btnCustomers.Location = new System.Drawing.Point(10, 471);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(120, 84);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // productVendorsBindingNavigator
            // 
            this.productVendorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productVendorsBindingNavigator.BindingSource = this.productVendorsBindingSource;
            this.productVendorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productVendorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productVendorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productVendorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productVendorsBindingNavigatorSaveItem});
            this.productVendorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productVendorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productVendorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productVendorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productVendorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productVendorsBindingNavigator.Name = "productVendorsBindingNavigator";
            this.productVendorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productVendorsBindingNavigator.Size = new System.Drawing.Size(1183, 38);
            this.productVendorsBindingNavigator.TabIndex = 18;
            this.productVendorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // productVendorsBindingSource
            // 
            this.productVendorsBindingSource.DataMember = "ProductVendors";
            this.productVendorsBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "salesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // productVendorsBindingNavigatorSaveItem
            // 
            this.productVendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productVendorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productVendorsBindingNavigatorSaveItem.Image")));
            this.productVendorsBindingNavigatorSaveItem.Name = "productVendorsBindingNavigatorSaveItem";
            this.productVendorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.productVendorsBindingNavigatorSaveItem.Text = "Save Data";
            this.productVendorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productVendorsBindingNavigatorSaveItem_Click);
            // 
            // productIDLabel1
            // 
            this.productIDLabel1.BackColor = System.Drawing.Color.DimGray;
            this.productIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productVendorsBindingSource, "ProductID", true));
            this.productIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel1.ForeColor = System.Drawing.Color.White;
            this.productIDLabel1.Location = new System.Drawing.Point(513, 213);
            this.productIDLabel1.Name = "productIDLabel1";
            this.productIDLabel1.Size = new System.Drawing.Size(259, 23);
            this.productIDLabel1.TabIndex = 19;
            this.productIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorIDLabel1
            // 
            this.vendorIDLabel1.BackColor = System.Drawing.Color.DimGray;
            this.vendorIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productVendorsBindingSource, "VendorID", true));
            this.vendorIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorIDLabel1.ForeColor = System.Drawing.Color.White;
            this.vendorIDLabel1.Location = new System.Drawing.Point(513, 266);
            this.vendorIDLabel1.Name = "vendorIDLabel1";
            this.vendorIDLabel1.Size = new System.Drawing.Size(259, 23);
            this.vendorIDLabel1.TabIndex = 20;
            this.vendorIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPVWholeSale
            // 
            this.txtPVWholeSale.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productVendorsBindingSource, "ProductVendorWholesalePrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtPVWholeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPVWholeSale.Location = new System.Drawing.Point(517, 324);
            this.txtPVWholeSale.Name = "txtPVWholeSale";
            this.txtPVWholeSale.Size = new System.Drawing.Size(255, 26);
            this.txtPVWholeSale.TabIndex = 21;
            // 
            // productVendorDaysToDeliverTextBox
            // 
            this.productVendorDaysToDeliverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productVendorsBindingSource, "ProductVendorDaysToDeliver", true));
            this.productVendorDaysToDeliverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productVendorDaysToDeliverTextBox.Location = new System.Drawing.Point(517, 371);
            this.productVendorDaysToDeliverTextBox.Name = "productVendorDaysToDeliverTextBox";
            this.productVendorDaysToDeliverTextBox.Size = new System.Drawing.Size(255, 26);
            this.productVendorDaysToDeliverTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Vendors Table";
            // 
            // fillByProductIDAndVendorIDToolStrip
            // 
            this.fillByProductIDAndVendorIDToolStrip.BackColor = System.Drawing.Color.Blue;
            this.fillByProductIDAndVendorIDToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByProductIDAndVendorIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productIDToolStripLabel,
            this.productIDToolStripTextBox,
            this.vendorIDToolStripLabel,
            this.vendorIDToolStripTextBox,
            this.fillByProductIDAndVendorIDToolStripButton});
            this.fillByProductIDAndVendorIDToolStrip.Location = new System.Drawing.Point(0, 38);
            this.fillByProductIDAndVendorIDToolStrip.Name = "fillByProductIDAndVendorIDToolStrip";
            this.fillByProductIDAndVendorIDToolStrip.Size = new System.Drawing.Size(1183, 38);
            this.fillByProductIDAndVendorIDToolStrip.TabIndex = 24;
            this.fillByProductIDAndVendorIDToolStrip.Text = "fillByProductIDAndVendorIDToolStrip";
            // 
            // productIDToolStripLabel
            // 
            this.productIDToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.productIDToolStripLabel.Name = "productIDToolStripLabel";
            this.productIDToolStripLabel.Size = new System.Drawing.Size(103, 33);
            this.productIDToolStripLabel.Text = "ProductID:";
            // 
            // productIDToolStripTextBox
            // 
            this.productIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productIDToolStripTextBox.Name = "productIDToolStripTextBox";
            this.productIDToolStripTextBox.Size = new System.Drawing.Size(100, 38);
            // 
            // vendorIDToolStripLabel
            // 
            this.vendorIDToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vendorIDToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.vendorIDToolStripLabel.Name = "vendorIDToolStripLabel";
            this.vendorIDToolStripLabel.Size = new System.Drawing.Size(97, 33);
            this.vendorIDToolStripLabel.Text = "VendorID:";
            // 
            // vendorIDToolStripTextBox
            // 
            this.vendorIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vendorIDToolStripTextBox.Name = "vendorIDToolStripTextBox";
            this.vendorIDToolStripTextBox.Size = new System.Drawing.Size(100, 38);
            // 
            // fillByProductIDAndVendorIDToolStripButton
            // 
            this.fillByProductIDAndVendorIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByProductIDAndVendorIDToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fillByProductIDAndVendorIDToolStripButton.ForeColor = System.Drawing.Color.White;
            this.fillByProductIDAndVendorIDToolStripButton.Name = "fillByProductIDAndVendorIDToolStripButton";
            this.fillByProductIDAndVendorIDToolStripButton.Size = new System.Drawing.Size(263, 33);
            this.fillByProductIDAndVendorIDToolStripButton.Text = "FillByProductIDAndVendorID";
            this.fillByProductIDAndVendorIDToolStripButton.Click += new System.EventHandler(this.fillByProductIDAndVendorIDToolStripButton_Click);
            // 
            // productVendorsTableAdapter
            // 
            this.productVendorsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProductVendorsTableAdapter = this.productVendorsTableAdapter;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // frmProductVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1183, 655);
            this.Controls.Add(this.fillByProductIDAndVendorIDToolStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(productVendorDaysToDeliverLabel);
            this.Controls.Add(this.productVendorDaysToDeliverTextBox);
            this.Controls.Add(productVendorWholesalePriceLabel);
            this.Controls.Add(this.txtPVWholeSale);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDLabel1);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDLabel1);
            this.Controls.Add(this.productVendorsBindingNavigator);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnCustomers);
            this.Name = "frmProductVendors";
            this.Text = "Product Vendors";
            this.Load += new System.EventHandler(this.frmProductVendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productVendorsBindingNavigator)).EndInit();
            this.productVendorsBindingNavigator.ResumeLayout(false);
            this.productVendorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productVendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            this.fillByProductIDAndVendorIDToolStrip.ResumeLayout(false);
            this.fillByProductIDAndVendorIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCustomers;
        private salesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource productVendorsBindingSource;
        private salesOrdersDataSetTableAdapters.ProductVendorsTableAdapter productVendorsTableAdapter;
        private salesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productVendorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productVendorsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label productIDLabel1;
        private System.Windows.Forms.Label vendorIDLabel1;
        private System.Windows.Forms.TextBox txtPVWholeSale;
        private System.Windows.Forms.TextBox productVendorDaysToDeliverTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip fillByProductIDAndVendorIDToolStrip;
        private System.Windows.Forms.ToolStripLabel productIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productIDToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel vendorIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendorIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByProductIDAndVendorIDToolStripButton;
    }
}