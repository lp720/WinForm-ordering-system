using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections;
using System.Reflection;
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        List<int> listId = new List<int>();
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();

        int productID;
        int mainCourse;
        int sideDish;
        int beverage;
        int discountProduct;
        int price;
        int quantity;
        int totalPrice;
        int position;
        int shoppingBag = 0;
        int eat = 1;

        string mainCourseName;
        string sideDishName;
        string beverageName;
        string discountProductName;
        string sauceName;


        //下面是用來更改listView圖片間距,搭配(1)使用.
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private int LVM_SETICONSPACING = 0x1035;


        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SendMessage(this.listView商品展示.Handle, LVM_SETICONSPACING, 0, 0x10000 * 200 + 200);//(1)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";//user
            scsb.InitialCatalog = "mydb2";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();
            radio內用.Checked = true;

            btn會員系統.Visible = false;
            btn維護系統.Visible = false;

            menu();
            Sidedishes();
            Drinks();
            Photo();
            ShowPhoto();
            OneMore();
            Sauce();

        }
        //圖片
        public void Photo()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 100 * from menu";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"image\";
            string image_name = "";
            int i = 0;

            while (reader.Read())
            {
                listId.Add((int)reader["id"]);
                listPname.Add(reader["餐點"].ToString());
                listPrice.Add((int)reader["價格"]);
                image_name = reader["pimage"].ToString();
                imageList商品圖檔.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);

            reader.Close();
            con.Close();
        }

        void ShowPhoto()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;
            imageList商品圖檔.ImageSize = new Size(190, 175);
            listView商品展示.LargeImageList = imageList商品圖檔;
            listView商品展示.SmallImageList = imageList商品圖檔;

            for (int i = 0; i < imageList商品圖檔.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
                item.Text = Convert.ToString("$" + listPrice[i]);
                item.Tag = listId[i];
                listView商品展示.Items.Add(item);
            }
        }
        //菜單
        public void menu()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from menu";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strMsg = "";
                string id = reader["id"].ToString();
                string 主餐 = reader["餐點"].ToString();
                string 價格 = reader["價格"].ToString();

                strMsg += string.Format("{0}號餐 {1} ${2}元\n", id, 主餐, 價格);
            }
            reader.Close();
            con.Close();
        }
        //配餐
        public void Sidedishes()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from sidedishes";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strMsg = "";
                string id = reader["id"].ToString();
                string 配餐 = reader["餐點"].ToString();
                string 價格 = reader["價格"].ToString();

                strMsg += string.Format("{0}.{1} +${2}元\n", id, 配餐, 價格);
                cmbBox配餐.Items.Add(strMsg);
            }
            cmbBox配餐.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }
        //飲料
        public void Drinks()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from drinks";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strMsg = "";
                string id = reader["id"].ToString();
                string 飲品 = reader["餐點"].ToString();
                string 價格 = reader["價格"].ToString();

                strMsg += string.Format("{0}.{1} +${2}元\n", id, 飲品, 價格);
                cmbBox飲料.Items.Add(strMsg);
            }
            cmbBox飲料.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }
        //加價購
        public void OneMore()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from onemore";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strMsg = "";
                string id = reader["id"].ToString();
                string 加價購 = reader["餐點"].ToString();
                string 價格 = reader["價格"].ToString();

                strMsg += string.Format("{0}.{1} +${2}元\n", id, 加價購, 價格);
                cmbBox加價購.Items.Add(strMsg);
            }
            cmbBox加價購.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }
        //醬
        public void Sauce()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from sauce";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strMsg = "";
                string id = reader["id"].ToString();
                string 沾醬 = reader["餐點"].ToString();

                strMsg += string.Format("{0}\n", 沾醬);
                cmbBox醬包.Items.Add(strMsg);
            }
            reader.Close();
            con.Close();
        }
        //小計
        public void SubTotal()
        {
            price = (mainCourse + sideDish + beverage + discountProduct) * quantity;
            lbl小計.Text = string.Format("NT$ {0}元", price);
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            productID = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);
            if (productID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from menu where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", productID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    mainCourse = Convert.ToInt32(reader["價格"]);//選主餐
                    mainCourseName = reader["餐點"].ToString();
                }

                SubTotal();

                reader.Close();
                con.Close();
            }
        }
        private void txtbox數量_TextChanged(object sender, EventArgs e)
        {
            if (txtbox數量.Text != "")
            {
                try
                {
                    quantity = Convert.ToInt32(txtbox數量.Text);

                    if (quantity < 1)
                    {
                        MessageBox.Show("至少須購買一份", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbox數量.Text = "";
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox數量.Text = "";
                }
            }
            SubTotal();
        }
        private void cmbBox配餐_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox配餐.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from sidedishes where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", cmbBox配餐.SelectedIndex + 1);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sideDish = Convert.ToInt32(reader["價格"]);
                    sideDishName = reader["餐點"].ToString();

                }
                SubTotal();

                reader.Close();
                con.Close();
            }
        }
        private void cmbBox飲料_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox飲料.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from drinks where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", cmbBox飲料.SelectedIndex + 1);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    beverage = Convert.ToInt32(reader["價格"]);
                    beverageName = reader["餐點"].ToString();

                }
                SubTotal();

                reader.Close();
                con.Close();
            }
        }
        private void cmbBox加價購_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox加價購.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from onemore where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", cmbBox加價購.SelectedIndex + 1);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    discountProduct = Convert.ToInt32(reader["價格"]);
                    discountProductName = reader["餐點"].ToString();

                }
                SubTotal();

                reader.Close();
                con.Close();
            }
        }

        private void cmbBox醬包_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox醬包.SelectedIndex >= 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from sauce where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", cmbBox醬包.SelectedIndex + 1);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sauceName = reader["餐點"].ToString();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            if (lbl資訊.Text == "")
            {
                MessageBox.Show("請登入會員", "登入", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((txtbox數量.Text.Count() != 0) && (productID > 0))
                {
                    ArrayList 品項訂購資訊 = new ArrayList();
                    品項訂購資訊.Add(mainCourseName);
                    品項訂購資訊.Add(sideDishName);
                    品項訂購資訊.Add(beverageName);
                    品項訂購資訊.Add(discountProductName);
                    品項訂購資訊.Add(quantity);
                    品項訂購資訊.Add(price);


                    //Console.WriteLine(sideDishName);

                    GlobalVar.list訂購品項資訊列表.Add(品項訂購資訊);
                    GlobalVar.price.Add(price);

                    MessageBox.Show("已加入訂購單", "加入", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowPhoto();
                    Total();
                    productID = 0;
                    txtbox數量.Text = "";
                    lbl小計.Text = "NT$ 0元";
                }
                else
                {
                    MessageBox.Show("是否輸入數量或選取餐點?", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
        //總計
        public void Total()
        {
            if (shoppingBag > 0)
            {
                if (shoppingBag == 1)
                {
                    totalPrice += 2;
                    shoppingBag = 0;
                    lbl總計.Text = String.Format("NT$ {0}元", totalPrice);

                }
                else if (shoppingBag == 2)
                {
                    totalPrice -= 2;
                    shoppingBag = 0;
                    lbl總計.Text = String.Format("NT$ {0}元", totalPrice);

                }
            }
            else
            {
                totalPrice += price;
                lbl總計.Text = String.Format("NT$ {0}元", totalPrice);
            }

        }

        private void btn維護系統_Click(object sender, EventArgs e)
        {
            Products myproducts = new Products();
            myproducts.ShowDialog();
        }

        private void btn會員系統_Click(object sender, EventArgs e)
        {
            Member mymember = new Member();
            mymember.ShowDialog();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            Login myLogin = new Login();
            myLogin.ShowDialog();
            foreach (ArrayList user in GlobalVar.user)
            {
                int id = (int)user[0];
                string name = (string)user[1];
                string tel = user[2].ToString();
                position = (int)user[3];
                lbl資訊.Text = string.Format("{0}", name);
            }
            if (position == 1)
            {
                btn會員系統.Visible = true;
                btn維護系統.Visible = true;
            }
            else if (position == 2)
            {
                btn會員系統.Visible = true;
                btn維護系統.Visible = false;
            }
            else
            {
                btn會員系統.Visible = false;
                btn維護系統.Visible = false;
            }
        }

        private void chkBox購物袋_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox購物袋.Checked == true)
            {
                shoppingBag = 1;
            }
            else
            {
                shoppingBag = 2;
            }
            Total();
        }
        private void btn結帳_Click(object sender, EventArgs e)
        {
            if (totalPrice > 2)
            {
                if (radio外帶.Checked == true)
                {
                    eat = 2;
                }
                string[] total = { Convert.ToString(totalPrice), Convert.ToString(eat), Convert.ToString(sauceName)};
                lbl總計.Text = "NT$ 0元";
                Form2 myForm2 = new Form2(total);
                myForm2.ShowDialog();
                GlobalVar.list訂購品項資訊列表.Clear();
                GlobalVar.price.Clear();
                chkBox購物袋.Checked = false;
                shoppingBag = 0;
                totalPrice = 0;
                price = 0;
                eat = 1;
                cmbBox飲料.SelectedIndex = 0;
                cmbBox配餐.SelectedIndex = 0;
                cmbBox加價購.SelectedIndex = 0;
                cmbBox醬包.Text = "";

            }
            else
            {
                MessageBox.Show("請加入訂單", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn支援_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.mcdonalds.com/tw/zh-tw/contact-us.html");
        }
    }
}


