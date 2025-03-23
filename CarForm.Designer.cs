namespace CarStoreGUIApp
{
    partial class CarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbCreatCar = new GroupBox();
            txtPrice = new TextBox();
            txtMiles = new TextBox();
            label6 = new Label();
            txtYear = new TextBox();
            txtColor = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCreate = new Button();
            gbStoreInventory = new GroupBox();
            listStoreInventory = new ListBox();
            groupBox3 = new GroupBox();
            listShoppingCart = new ListBox();
            btnAddToCart = new Button();
            btnCheckout = new Button();
            lblTotal7 = new Label();
            lblTotal = new Label();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            gbCreatCar.SuspendLayout();
            gbStoreInventory.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gbCreatCar
            // 
            gbCreatCar.Controls.Add(txtPrice);
            gbCreatCar.Controls.Add(txtMiles);
            gbCreatCar.Controls.Add(label6);
            gbCreatCar.Controls.Add(txtYear);
            gbCreatCar.Controls.Add(txtColor);
            gbCreatCar.Controls.Add(txtModel);
            gbCreatCar.Controls.Add(txtMake);
            gbCreatCar.Controls.Add(label4);
            gbCreatCar.Controls.Add(label5);
            gbCreatCar.Controls.Add(label3);
            gbCreatCar.Controls.Add(label2);
            gbCreatCar.Controls.Add(label1);
            gbCreatCar.Location = new Point(61, 53);
            gbCreatCar.Name = "gbCreatCar";
            gbCreatCar.Size = new Size(307, 387);
            gbCreatCar.TabIndex = 0;
            gbCreatCar.TabStop = false;
            gbCreatCar.Text = "Create Car";
            gbCreatCar.Enter += groupBox1_Enter;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(71, 283);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 15;
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(71, 229);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(150, 31);
            txtMiles.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 289);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 13;
            label6.Text = "Price";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(71, 175);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 8;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(71, 131);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(150, 31);
            txtColor.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(71, 84);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 31);
            txtModel.TabIndex = 6;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(71, 41);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(150, 31);
            txtMake.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 178);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 4;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 232);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 5;
            label5.Text = "Miles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 3;
            label3.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "Make";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(142, 446);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create Car";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // gbStoreInventory
            // 
            gbStoreInventory.Controls.Add(listStoreInventory);
            gbStoreInventory.Location = new Point(388, 65);
            gbStoreInventory.Name = "gbStoreInventory";
            gbStoreInventory.Size = new Size(300, 365);
            gbStoreInventory.TabIndex = 6;
            gbStoreInventory.TabStop = false;
            gbStoreInventory.Text = "Store Inventory";
            // 
            // listStoreInventory
            // 
            listStoreInventory.FormattingEnabled = true;
            listStoreInventory.ItemHeight = 25;
            listStoreInventory.Location = new Point(6, 30);
            listStoreInventory.Name = "listStoreInventory";
            listStoreInventory.Size = new Size(288, 304);
            listStoreInventory.TabIndex = 13;
            listStoreInventory.SelectedIndexChanged += listStoreInventory_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listShoppingCart);
            groupBox3.Location = new Point(850, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 350);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "In Cart";
            // 
            // listShoppingCart
            // 
            listShoppingCart.FormattingEnabled = true;
            listShoppingCart.ItemHeight = 25;
            listShoppingCart.Location = new Point(6, 29);
            listShoppingCart.Name = "listShoppingCart";
            listShoppingCart.Size = new Size(294, 304);
            listShoppingCart.TabIndex = 14;
            listShoppingCart.SelectedIndexChanged += listShoppingCart_SelectedIndexChanged;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(694, 198);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(124, 58);
            btnAddToCart.TabIndex = 11;
            btnAddToCart.Text = "Add To Cart ->";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(936, 406);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(112, 34);
            btnCheckout.TabIndex = 12;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotal7
            // 
            lblTotal7.AutoSize = true;
            lblTotal7.Location = new Point(961, 480);
            lblTotal7.Name = "lblTotal7";
            lblTotal7.Size = new Size(53, 25);
            lblTotal7.TabIndex = 13;
            lblTotal7.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1020, 480);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "label8";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1066, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(421, 436);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(577, 434);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 531);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(lblTotal);
            Controls.Add(lblTotal7);
            Controls.Add(btnCheckout);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox3);
            Controls.Add(btnCreate);
            Controls.Add(gbStoreInventory);
            Controls.Add(gbCreatCar);
            Name = "CarForm";
            Text = "Car Store";
            gbCreatCar.ResumeLayout(false);
            gbCreatCar.PerformLayout();
            gbStoreInventory.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCreatCar;
        private Button btnCreate;
        private TextBox txtYear;
        private TextBox txtColor;
        private TextBox txtModel;
        private TextBox txtMake;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private GroupBox gbStoreInventory;
        private GroupBox groupBox3;
        private ListBox listStoreInventory;
        private ListBox listShoppingCart;
        private Button btnAddToCart;
        private Button btnCheckout;
        private Label label6;
        private TextBox txtPrice;
        private TextBox txtMiles;
        private Label lblTotal7;
        private Label lblTotal;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
