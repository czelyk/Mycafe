namespace Mycafe
{
    partial class ItemsForm
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
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            ItemsGV = new DataGridView();
            label6 = new Label();
            button5 = new Button();
            button2 = new Button();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            CatCb = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            PriceCb = new TextBox();
            ItemNameTb = new TextBox();
            ItemNumTb = new TextBox();
            button4 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(899, 22);
            label7.Name = "label7";
            label7.Size = new Size(34, 38);
            label7.TabIndex = 14;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 505);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PriceCb);
            panel1.Controls.Add(ItemNameTb);
            panel1.Controls.Add(ItemNumTb);
            panel1.Location = new Point(102, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 476);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // ItemsGV
            // 
            ItemsGV.BackgroundColor = SystemColors.Control;
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsGV.Location = new Point(432, 127);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.RowHeadersWidth = 51;
            ItemsGV.RowTemplate.Height = 29;
            ItemsGV.Size = new Size(300, 216);
            ItemsGV.TabIndex = 18;
            ItemsGV.CellContentClick += ItemsGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Goldenrod;
            label6.Location = new Point(506, 68);
            label6.Name = "label6";
            label6.Size = new Size(124, 38);
            label6.TabIndex = 17;
            label6.Text = "Item List";
            label6.Click += label6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(185, 269);
            button5.Name = "button5";
            button5.Size = new Size(71, 44);
            button5.TabIndex = 16;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(109, 269);
            button2.Name = "button2";
            button2.Size = new Size(70, 44);
            button2.TabIndex = 15;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Goldenrod;
            label5.Location = new Point(43, 217);
            label5.Name = "label5";
            label5.Size = new Size(102, 26);
            label5.TabIndex = 14;
            label5.Text = "Item Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(43, 140);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 13;
            label2.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(284, 13);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 2;
            label1.Text = "Manage Items";
            label1.Click += label1_Click;
            // 
            // CatCb
            // 
            CatCb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Water", "Dessert" });
            CatCb.Location = new Point(189, 177);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(133, 33);
            CatCb.TabIndex = 12;
            CatCb.Text = "Categories";
            CatCb.SelectedIndexChanged += CatCb_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(43, 94);
            label3.Name = "label3";
            label3.Size = new Size(128, 26);
            label3.TabIndex = 9;
            label3.Text = "Item Number";
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(43, 269);
            button1.Name = "button1";
            button1.Size = new Size(60, 44);
            button1.TabIndex = 7;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PriceCb
            // 
            PriceCb.Location = new Point(189, 216);
            PriceCb.Name = "PriceCb";
            PriceCb.Size = new Size(133, 27);
            PriceCb.TabIndex = 6;
            // 
            // ItemNameTb
            // 
            ItemNameTb.Location = new Point(189, 139);
            ItemNameTb.Name = "ItemNameTb";
            ItemNameTb.Size = new Size(133, 27);
            ItemNameTb.TabIndex = 5;
            // 
            // ItemNumTb
            // 
            ItemNumTb.Location = new Point(189, 96);
            ItemNumTb.Name = "ItemNumTb";
            ItemNumTb.Size = new Size(133, 27);
            ItemNumTb.TabIndex = 4;
            ItemNumTb.TextChanged += ItemNumTb_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Goldenrod;
            button4.Location = new Point(12, 176);
            button4.Name = "button4";
            button4.Size = new Size(84, 35);
            button4.TabIndex = 16;
            button4.Text = "User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Goldenrod;
            button3.Location = new Point(12, 117);
            button3.Name = "button3";
            button3.Size = new Size(84, 36);
            button3.TabIndex = 15;
            button3.Text = "Orders";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(945, 611);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemsForm";
            Text = "ItemsForm";
            Load += ItemsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Button button1;
        private TextBox PriceCb;
        private TextBox ItemNameTb;
        private TextBox ItemNumTb;
        private Label label1;
        private Button button4;
        private Button button3;
        private Label label6;
        private Button button5;
        private Button button2;
        private Label label5;
        private Label label2;
        private ComboBox CatCb;
        private DataGridView ItemsGV;
    }
}