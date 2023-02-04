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

namespace WindowsFormsApp1
{
    public partial class ProductDetail : Form
    {
        public int productID = 0;
        string strDBConnectionString = "";
        string image_dir = @"image\";
        string image_name = "";
        bool is已修改圖檔 = false;
        public ProductDetail()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb2";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            if (productID == 0)
            {//新增模式
                groupBox新增商品.Visible = true;
                groupBox修改商品.Visible = false;
            }
            else
            {//維護模式 
                groupBox新增商品.Visible = false;
                groupBox修改商品.Visible = true;
            }
            顯示產品細項資訊();

        }

        private void btn選取商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型(*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into menu values(@NewName, @NewPrice, @NewState, @NewDate, @NewImageName);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intprice = 0;
                Int32.TryParse(txt商品價格.Text, out intprice);
                cmd.Parameters.AddWithValue("@NewPrice", intprice);
                cmd.Parameters.AddWithValue("@NewState", chk供應狀態.Checked);
                cmd.Parameters.AddWithValue("@NewDate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@NewImageName", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功,影響" + rows + "筆資料", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("所有欄位必填", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();
            chk供應狀態.Checked = false;
            pictureBox商品圖檔.Image = null;
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update menu set 餐點 = @NewName, 價格 = @NewPrice, 供應狀態 = @NewState where id = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intprice = 0;
                Int32.TryParse(txt商品價格.Text, out intprice);
                cmd.Parameters.AddWithValue("@NewPrice", intprice);
                cmd.Parameters.AddWithValue("@NewState", chk供應狀態.Checked);
                cmd.Parameters.AddWithValue("@SearchId", productID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功,影響" + rows + "筆資料", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("所有欄位必填", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn選取新增商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型(*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }
        void 顯示產品細項資訊()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from menu where id = @SearchId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", productID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lblID.Text = reader["id"].ToString();
                txt商品名稱.Text = reader["餐點"].ToString();
                txt商品價格.Text = reader["價格"].ToString();
                int 供應狀態 = Convert.ToInt32(reader["供應狀態"]);
                if (供應狀態 == 1)
                {
                    chk供應狀態.Checked = true;
                }
                else
                {
                    chk供應狀態.Checked = false;
                }
                image_name = reader["pimage"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
            }
            reader.Close();
            con.Close();

        }
    }
}
