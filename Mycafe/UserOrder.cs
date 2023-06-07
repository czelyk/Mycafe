using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Mycafe
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\root\Documents\Caferdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        void filterbycategory()
        {
            Con.Open();
            string query = "select * from ItemTbl where ItemCat = '" + categoryCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Item = new ItemsForm();
            Item.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int num = 0;
        int price, total;
        string item, cat;


        private void OrdersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
                MessageBox.Show("What is the Quantity of the item");
            else if (flag == 0)
                MessageBox.Show("Select the product to be ordered");
            else
            {
                num++;
                total = price * Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrdersGv.DataSource = table;
                flag = 0;
            }
            sum++;
            LabelAmnt.Text = sum + "TL";
        }
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;
        }
        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var currentRow = ItemsGV.Rows[rowIndex];
            var currentCellValue = ItemsGV.Rows[rowIndex].Cells[e.ColumnIndex].Value.ToString();
            flag = 1;
        }

        private void UserOrder_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void ItemsGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Name = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            //cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            //price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            //flag = 1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void categoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
