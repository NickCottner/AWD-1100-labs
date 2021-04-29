
namespace DataDesignerV2
{
    partial class frmOrderDetails
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
            System.Windows.Forms.Label lblOrderId;
            System.Windows.Forms.Label lblProductId;
            System.Windows.Forms.Label lblOdQuotedPrice;
            System.Windows.Forms.Label lblOdQuantityOrdered;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderDetails));
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salesOrdersDataSet = new DataDesignerV2.salesOrdersDataSet();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new DataDesignerV2.salesOrdersDataSetTableAdapters.OrderDetailsTableAdapter();
            this.tableAdapterManager = new DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager();
            this.orderDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orderDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblOrderIdNumber = new System.Windows.Forms.Label();
            this.lblProductIDNumber = new System.Windows.Forms.Label();
            this.orderDetailQuotedPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderDetailQuantityOrderedTextBox = new System.Windows.Forms.TextBox();
            this.fillByOrderIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.orderIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.orderIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByOrderIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            lblOrderId = new System.Windows.Forms.Label();
            lblProductId = new System.Windows.Forms.Label();
            lblOdQuotedPrice = new System.Windows.Forms.Label();
            lblOdQuantityOrdered = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).BeginInit();
            this.orderDetailsBindingNavigator.SuspendLayout();
            this.fillByOrderIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOrderId.Location = new System.Drawing.Point(332, 188);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new System.Drawing.Size(83, 20);
            lblOrderId.TabIndex = 19;
            lblOrderId.Text = "Order ID:";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProductId.Location = new System.Drawing.Point(315, 244);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new System.Drawing.Size(100, 20);
            lblProductId.TabIndex = 20;
            lblProductId.Text = "Product ID:";
            // 
            // lblOdQuotedPrice
            // 
            lblOdQuotedPrice.AutoSize = true;
            lblOdQuotedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOdQuotedPrice.Location = new System.Drawing.Point(195, 293);
            lblOdQuotedPrice.Name = "lblOdQuotedPrice";
            lblOdQuotedPrice.Size = new System.Drawing.Size(220, 20);
            lblOdQuotedPrice.TabIndex = 21;
            lblOdQuotedPrice.Text = "Order Detail Quoted Price:";
            // 
            // lblOdQuantityOrdered
            // 
            lblOdQuantityOrdered.AutoSize = true;
            lblOdQuantityOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOdQuantityOrdered.Location = new System.Drawing.Point(162, 344);
            lblOdQuantityOrdered.Name = "lblOdQuantityOrdered";
            lblOdQuantityOrdered.Size = new System.Drawing.Size(253, 20);
            lblOdQuantityOrdered.TabIndex = 22;
            lblOdQuantityOrdered.Text = "Order Detail Quantity Ordered:";
            // 
            // btnVendors
            // 
            this.btnVendors.BackColor = System.Drawing.Color.Blue;
            this.btnVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.ForeColor = System.Drawing.Color.White;
            this.btnVendors.Location = new System.Drawing.Point(1029, 503);
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
            this.btnProductVendors.Location = new System.Drawing.Point(888, 503);
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
            this.btnProducts.Location = new System.Drawing.Point(748, 503);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 84);
            this.btnProducts.TabIndex = 15;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.Blue;
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.Location = new System.Drawing.Point(611, 503);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(120, 84);
            this.buttonOrders.TabIndex = 14;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Blue;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(468, 503);
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
            this.btnEmployees.Location = new System.Drawing.Point(322, 503);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 84);
            this.btnEmployees.TabIndex = 12;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Blue;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(175, 503);
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
            this.btnCategories.Location = new System.Drawing.Point(33, 503);
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
            this.label1.Location = new System.Drawing.Point(416, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order Details Table";
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "salesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = this.orderDetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataDesignerV2.salesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // orderDetailsBindingNavigator
            // 
            this.orderDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderDetailsBindingNavigator.BindingSource = this.orderDetailsBindingSource;
            this.orderDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.orderDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderDetailsBindingNavigatorSaveItem});
            this.orderDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderDetailsBindingNavigator.Name = "orderDetailsBindingNavigator";
            this.orderDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderDetailsBindingNavigator.Size = new System.Drawing.Size(1191, 33);
            this.orderDetailsBindingNavigator.TabIndex = 19;
            this.orderDetailsBindingNavigator.Text = "bindingNavigator1";
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
            // orderDetailsBindingNavigatorSaveItem
            // 
            this.orderDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderDetailsBindingNavigatorSaveItem.Image")));
            this.orderDetailsBindingNavigatorSaveItem.Name = "orderDetailsBindingNavigatorSaveItem";
            this.orderDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.orderDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.orderDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderDetailsBindingNavigatorSaveItem_Click);
            // 
            // lblOrderIdNumber
            // 
            this.lblOrderIdNumber.BackColor = System.Drawing.Color.Yellow;
            this.lblOrderIdNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderID", true));
            this.lblOrderIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIdNumber.Location = new System.Drawing.Point(448, 188);
            this.lblOrderIdNumber.Name = "lblOrderIdNumber";
            this.lblOrderIdNumber.Size = new System.Drawing.Size(224, 23);
            this.lblOrderIdNumber.TabIndex = 20;
            this.lblOrderIdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductIDNumber
            // 
            this.lblProductIDNumber.BackColor = System.Drawing.Color.Yellow;
            this.lblProductIDNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "ProductID", true));
            this.lblProductIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDNumber.Location = new System.Drawing.Point(448, 241);
            this.lblProductIDNumber.Name = "lblProductIDNumber";
            this.lblProductIDNumber.Size = new System.Drawing.Size(224, 23);
            this.lblProductIDNumber.TabIndex = 21;
            this.lblProductIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderDetailQuotedPriceTextBox
            // 
            this.orderDetailQuotedPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderDetailQuotedPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.orderDetailQuotedPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailQuotedPriceTextBox.Location = new System.Drawing.Point(452, 290);
            this.orderDetailQuotedPriceTextBox.Name = "orderDetailQuotedPriceTextBox";
            this.orderDetailQuotedPriceTextBox.Size = new System.Drawing.Size(220, 26);
            this.orderDetailQuotedPriceTextBox.TabIndex = 22;
            this.orderDetailQuotedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderDetailQuantityOrderedTextBox
            // 
            this.orderDetailQuantityOrderedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderDetailQuantityOrdered", true));
            this.orderDetailQuantityOrderedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailQuantityOrderedTextBox.Location = new System.Drawing.Point(452, 341);
            this.orderDetailQuantityOrderedTextBox.Name = "orderDetailQuantityOrderedTextBox";
            this.orderDetailQuantityOrderedTextBox.Size = new System.Drawing.Size(220, 26);
            this.orderDetailQuantityOrderedTextBox.TabIndex = 23;
            this.orderDetailQuantityOrderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByOrderIDToolStrip
            // 
            this.fillByOrderIDToolStrip.BackColor = System.Drawing.Color.Blue;
            this.fillByOrderIDToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByOrderIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderIDToolStripLabel,
            this.orderIDToolStripTextBox,
            this.fillByOrderIDToolStripButton});
            this.fillByOrderIDToolStrip.Location = new System.Drawing.Point(0, 33);
            this.fillByOrderIDToolStrip.Name = "fillByOrderIDToolStrip";
            this.fillByOrderIDToolStrip.Size = new System.Drawing.Size(1191, 34);
            this.fillByOrderIDToolStrip.TabIndex = 24;
            this.fillByOrderIDToolStrip.Text = "fillByOrderIDToolStrip";
            // 
            // orderIDToolStripLabel
            // 
            this.orderIDToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.orderIDToolStripLabel.Name = "orderIDToolStripLabel";
            this.orderIDToolStripLabel.Size = new System.Drawing.Size(85, 29);
            this.orderIDToolStripLabel.Text = "OrderID:";
            // 
            // orderIDToolStripTextBox
            // 
            this.orderIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderIDToolStripTextBox.Name = "orderIDToolStripTextBox";
            this.orderIDToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByOrderIDToolStripButton
            // 
            this.fillByOrderIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByOrderIDToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByOrderIDToolStripButton.ForeColor = System.Drawing.Color.White;
            this.fillByOrderIDToolStripButton.Name = "fillByOrderIDToolStripButton";
            this.fillByOrderIDToolStripButton.Size = new System.Drawing.Size(130, 29);
            this.fillByOrderIDToolStripButton.Text = "FillByOrderID";
            this.fillByOrderIDToolStripButton.Click += new System.EventHandler(this.fillByOrderIDToolStripButton_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1191, 661);
            this.Controls.Add(this.fillByOrderIDToolStrip);
            this.Controls.Add(lblOdQuantityOrdered);
            this.Controls.Add(this.orderDetailQuantityOrderedTextBox);
            this.Controls.Add(lblOdQuotedPrice);
            this.Controls.Add(this.orderDetailQuotedPriceTextBox);
            this.Controls.Add(lblProductId);
            this.Controls.Add(this.lblProductIDNumber);
            this.Controls.Add(lblOrderId);
            this.Controls.Add(this.lblOrderIdNumber);
            this.Controls.Add(this.orderDetailsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCategories);
            this.Name = "frmOrderDetails";
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).EndInit();
            this.orderDetailsBindingNavigator.ResumeLayout(false);
            this.orderDetailsBindingNavigator.PerformLayout();
            this.fillByOrderIDToolStrip.ResumeLayout(false);
            this.fillByOrderIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnProductVendors;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Label label1;
        private salesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private salesOrdersDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private salesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orderDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label lblOrderIdNumber;
        private System.Windows.Forms.Label lblProductIDNumber;
        private System.Windows.Forms.TextBox orderDetailQuotedPriceTextBox;
        private System.Windows.Forms.TextBox orderDetailQuantityOrderedTextBox;
        private System.Windows.Forms.ToolStrip fillByOrderIDToolStrip;
        private System.Windows.Forms.ToolStripLabel orderIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox orderIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByOrderIDToolStripButton;
    }
}