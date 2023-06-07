namespace Mycafe
{
    partial class UserOrder
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
            panel1 = new Panel();
            button5 = new Button();
            OrdersGv = new DataGridView();
            Num = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            UnitOPr = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ItemsGV = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            LabelAmnt = new Label();
            button1 = new Button();
            QtyTb = new TextBox();
            SellerName = new TextBox();
            OrderNum = new TextBox();
            categoryCb = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(OrdersGv);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LabelAmnt);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(SellerName);
            panel1.Controls.Add(OrderNum);
            panel1.Controls.Add(categoryCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(124, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 462);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(208, 106);
            button5.Name = "button5";
            button5.Size = new Size(75, 29);
            button5.TabIndex = 13;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // OrdersGv
            // 
            OrdersGv.AccessibleRole = AccessibleRole.None;
            OrdersGv.AllowUserToOrderColumns = true;
            OrdersGv.BackgroundColor = SystemColors.Control;
            OrdersGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGv.Columns.AddRange(new DataGridViewColumn[] { Num, Item, Category, UnitOPr, UnitPrice, Total });
            OrdersGv.Location = new Point(331, 272);
            OrdersGv.Name = "OrdersGv";
            OrdersGv.RowHeadersWidth = 51;
            OrdersGv.RowTemplate.Height = 29;
            OrdersGv.Size = new Size(375, 141);
            OrdersGv.TabIndex = 12;
            OrdersGv.CellContentClick += OrdersGv_CellContentClick;
            // 
            // Num
            // 
            Num.HeaderText = "Number";
            Num.MinimumWidth = 6;
            Num.Name = "Num";
            Num.Width = 125;
            // 
            // Item
            // 
            Item.HeaderText = "ItemName";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // UnitOPr
            // 
            UnitOPr.HeaderText = "Column2";
            UnitOPr.MinimumWidth = 6;
            UnitOPr.Name = "UnitOPr";
            UnitOPr.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // ItemsGV
            // 
            ItemsGV.BackgroundColor = SystemColors.Control;
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsGV.Location = new Point(331, 55);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.RowHeadersWidth = 51;
            ItemsGV.RowTemplate.Height = 29;
            ItemsGV.Size = new Size(383, 140);
            ItemsGV.TabIndex = 11;
            ItemsGV.CellContentClick += ItemsGV_CellContentClick;
            ItemsGV.RowEnter += ItemsGV_RowEnter;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(449, 430);
            button2.Name = "button2";
            button2.Size = new Size(129, 29);
            button2.TabIndex = 10;
            button2.Text = "Place The Order";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Unicode MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(459, 238);
            label3.Name = "label3";
            label3.Size = new Size(129, 31);
            label3.TabIndex = 9;
            label3.Text = "Your Order";
            // 
            // LabelAmnt
            // 
            LabelAmnt.AutoSize = true;
            LabelAmnt.BackColor = Color.White;
            LabelAmnt.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAmnt.ForeColor = Color.Goldenrod;
            LabelAmnt.Location = new Point(612, 431);
            LabelAmnt.Name = "LabelAmnt";
            LabelAmnt.Size = new Size(139, 26);
            LabelAmnt.TabIndex = 8;
            LabelAmnt.Text = "Order Amount";
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(386, 206);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 7;
            button1.Text = "Add To Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(549, 208);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(133, 27);
            QtyTb.TabIndex = 6;
            QtyTb.Text = "Quantity";
            // 
            // SellerName
            // 
            SellerName.Enabled = false;
            SellerName.Location = new Point(33, 174);
            SellerName.Name = "SellerName";
            SellerName.Size = new Size(133, 27);
            SellerName.TabIndex = 5;
            SellerName.Text = "Guest";
            // 
            // OrderNum
            // 
            OrderNum.Location = new Point(33, 141);
            OrderNum.Name = "OrderNum";
            OrderNum.Size = new Size(133, 27);
            OrderNum.TabIndex = 4;
            OrderNum.Text = "Order Number";
            // 
            // categoryCb
            // 
            categoryCb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            categoryCb.FormattingEnabled = true;
            categoryCb.Items.AddRange(new object[] { "Water", "Dessert" });
            categoryCb.Location = new Point(33, 102);
            categoryCb.Name = "categoryCb";
            categoryCb.Size = new Size(160, 33);
            categoryCb.TabIndex = 3;
            categoryCb.Text = "Categories";
            categoryCb.SelectedIndexChanged += categoryCb_SelectedIndexChanged;
            categoryCb.SelectionChangeCommitted += comboBox_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(449, 14);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 2;
            label1.Text = "Place Order";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Goldenrod;
            button3.Location = new Point(21, 94);
            button3.Name = "button3";
            button3.Size = new Size(84, 36);
            button3.TabIndex = 13;
            button3.Text = "Items";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Goldenrod;
            button4.Location = new Point(21, 136);
            button4.Name = "button4";
            button4.Size = new Size(84, 35);
            button4.TabIndex = 14;
            button4.Text = "User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(898, 10);
            label7.Name = "label7";
            label7.Size = new Size(34, 38);
            label7.TabIndex = 15;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(30, 492);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 16;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // UserOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(945, 611);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrder";
            Text = "UserOrder";
            Load += UserOrder_Load;
            Click += UserOrder_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label3;
        private Label LabelAmnt;
        private Button button1;
        private TextBox QtyTb;
        private TextBox SellerName;
        private TextBox OrderNum;
        private ComboBox categoryCb;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label4;
        private DataGridView OrdersGv;
        private DataGridView ItemsGV;
        private DataGridViewTextBoxColumn Num;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn UnitOPr;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
        private Button button5;
    }
}