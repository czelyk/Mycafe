namespace Mycafe
{
    partial class UsersForm
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
            button4 = new Button();
            button3 = new Button();
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            UsersGV = new DataGridView();
            label6 = new Label();
            button5 = new Button();
            button2 = new Button();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            UpassTb = new TextBox();
            uphoneTb = new TextBox();
            unameTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Goldenrod;
            button4.Location = new Point(13, 138);
            button4.Name = "button4";
            button4.Size = new Size(84, 35);
            button4.TabIndex = 21;
            button4.Text = "Item";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Goldenrod;
            button3.Location = new Point(13, 84);
            button3.Name = "button3";
            button3.Size = new Size(84, 36);
            button3.TabIndex = 20;
            button3.Text = "Orders";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(899, 9);
            label7.Name = "label7";
            label7.Size = new Size(34, 38);
            label7.TabIndex = 19;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 504);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 18;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(UsersGV);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(UpassTb);
            panel1.Controls.Add(uphoneTb);
            panel1.Controls.Add(unameTb);
            panel1.Location = new Point(103, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 476);
            panel1.TabIndex = 17;
            // 
            // UsersGV
            // 
            UsersGV.BackgroundColor = Color.White;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(428, 122);
            UsersGV.Name = "UsersGV";
            UsersGV.RowHeadersWidth = 51;
            UsersGV.RowTemplate.Height = 29;
            UsersGV.Size = new Size(300, 242);
            UsersGV.TabIndex = 18;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Goldenrod;
            label6.Location = new Point(506, 68);
            label6.Name = "label6";
            label6.Size = new Size(128, 38);
            label6.TabIndex = 17;
            label6.Text = "User List";
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(185, 320);
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
            button2.Location = new Point(109, 320);
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
            label5.Location = new Point(43, 236);
            label5.Name = "label5";
            label5.Size = new Size(100, 26);
            label5.TabIndex = 14;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(43, 197);
            label2.Name = "label2";
            label2.Size = new Size(69, 26);
            label2.TabIndex = 13;
            label2.Text = "Phone";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Unicode MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(284, 13);
            label1.Name = "label1";
            label1.Size = new Size(201, 38);
            label1.TabIndex = 2;
            label1.Text = "Manage Users";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(43, 151);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 9;
            label3.Text = "User Name";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(43, 320);
            button1.Name = "button1";
            button1.Size = new Size(60, 44);
            button1.TabIndex = 7;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UpassTb
            // 
            UpassTb.Location = new Point(189, 238);
            UpassTb.Name = "UpassTb";
            UpassTb.Size = new Size(133, 27);
            UpassTb.TabIndex = 6;
            UpassTb.TextChanged += textBox3_TextChanged;
            // 
            // uphoneTb
            // 
            uphoneTb.Location = new Point(189, 196);
            uphoneTb.Name = "uphoneTb";
            uphoneTb.Size = new Size(133, 27);
            uphoneTb.TabIndex = 5;
            uphoneTb.TextChanged += textBox2_TextChanged;
            // 
            // unameTb
            // 
            unameTb.Location = new Point(189, 153);
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(133, 27);
            unameTb.TabIndex = 4;
            // 
            // UsersForm
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
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersF";
            Load += UsersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Label label7;
        private Label label4;
        private Panel panel1;
        private Label label6;
        private Button button5;
        private Button button2;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
        private TextBox UpassTb;
        private TextBox uphoneTb;
        private TextBox unameTb;
        private DataGridView UsersGV;
    }
}