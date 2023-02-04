using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";

        int price;
        int specialPrice;
        int quantity;
        int id;
        int 訂單編號;

        string mainCourseName;
        string sideDishName;
        string beverageName;
        string discountProductName;
        string Marqueest = "總價滿200輸入優惠碼'love99'享95折優惠，數量有限領完為止!";


        public Form2()
        {
            InitializeComponent();
            CenterToScreen();

        }
        public Form2(string[] total)
        {
            InitializeComponent();
            price = Convert.ToInt32(total[0]);
            lbl總價.Text = string.Format("NT$ {0}元", price);
            int eat = Convert.ToInt32(total[1]);
            if (eat == 1)
            {
                lbl用餐.Text = "內用";
            }
            else if(eat == 2)
            {
                lbl用餐.Text = "外帶";
            }
            lbl醬包.Text = string.Format("{0}", total[2]);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb2";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();
            lbl單價.Text = "NT$ 0元";
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資訊列表)
            {
                mainCourseName = (string)訂購品項[0];

                sideDishName = "+" + (string)訂購品項[1];
                if (sideDishName == "+不需要")
                {
                    sideDishName = "";
                }

                beverageName = "+" + (string)訂購品項[2];
                if (beverageName == "+不需要")
                {
                    beverageName = "";
                }

                discountProductName = "+" + (string)訂購品項[3];
                if (discountProductName == "+不需要")
                {
                    discountProductName = "";
                }

                quantity = (int)訂購品項[4];

                string str品項資訊 = string.Format("{0}{1}{2}{3} {4}份"
                                                 , mainCourseName, sideDishName, beverageName, discountProductName, quantity);
                
                listBox訂購品項.Items.Add(str品項資訊);
            }

            foreach (ArrayList user in GlobalVar.user)
            {
                id = (int)user[0];
                string name = user[1].ToString();
                string tel = user[2].ToString();

                lbl訂購人資訊.Text = string.Format("訂購人:{0} 電話:{1}", name, tel);
            }
        }

        private void btn移除_Click_1(object sender, EventArgs e)
        {
            if (listBox訂購品項.SelectedIndex > -1)
            {
                int selIndex = listBox訂購品項.SelectedIndex;
                GlobalVar.list訂購品項資訊列表.RemoveAt(selIndex);
                price -= Convert.ToInt32(GlobalVar.price[selIndex]);
                lbl總價.Text = string.Format("NT$ {0}元", price);
                GlobalVar.price.RemoveAt(selIndex);
                listBox訂購品項.Items.RemoveAt(selIndex);
            }
            else
            {
                MessageBox.Show("請選擇移除項目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn清除_Click_1(object sender, EventArgs e)
        {
            listBox訂購品項.Items.Clear();
            GlobalVar.list訂購品項資訊列表.Clear();
            GlobalVar.price.Clear();
            lbl總價.Text = "NT$ 0元";
            lbl單價.Text = "NT$ 0元";
            specialPrice = 0;
        }

        private void listBox訂購品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox訂購品項.SelectedIndex > -1)
            {
                int index = (listBox訂購品項.SelectedIndex);
                lbl單價.Text = "NT$ " + Convert.ToString(GlobalVar.price[index] + "元");
            }
            else
            {
                lbl單價.Text = "NT$ 0元";
            }
        }

        private void txtBox優惠代碼_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBox優惠代碼.Text == "love99" && price >= 200)
            {
                specialPrice = Convert.ToInt32(Convert.ToDouble(price * 0.95));
                lbl總價.Text = string.Format("NT$ {0}元", specialPrice);
            }
        }

        private void btn確認訂單_Click(object sender, EventArgs e)
        {
            if (GlobalVar.list訂購品項資訊列表.Count > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into 訂單資料 values (@memberID, getdate(), @totalprice, @specialPrice);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@memberID", id);
                cmd.Parameters.AddWithValue("@totalprice", price);
                cmd.Parameters.AddWithValue("@specialPrice", specialPrice);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("訂單成立", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                編號();
                訂單細項();
                listBox訂購品項.Items.Clear();
                GlobalVar.list訂購品項資訊列表.Clear();
                GlobalVar.price.Clear();
                lbl總價.Text = "NT$ 0元";
                lbl單價.Text = "NT$ 0元";
                txtBox優惠代碼.Text = "";
                specialPrice = 0;
                Close();
            }
            else 
            {
                MessageBox.Show("訂單內沒有商品", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void 編號() 
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 1 訂單編號 from 訂單資料 order by 訂單編號 desc;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                訂單編號 = ((int)reader["訂單編號"]);
            }
            reader.Close();
            con.Close();
        }
        void 訂單細項()
        {
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資訊列表)
            {
                mainCourseName = (string)訂購品項[0];
                sideDishName = (string)訂購品項[1];
                beverageName = (string)訂購品項[2];
                discountProductName = (string)訂購品項[3];
                quantity = (int)訂購品項[4];
                price = (int)訂購品項[5];

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into 訂單細項 values (@orderID, @product, @sidedishes, @drinks, @onemore, @quantity, @price);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderID", 訂單編號);
                cmd.Parameters.AddWithValue("@product", mainCourseName);
                cmd.Parameters.AddWithValue("@sidedishes", sideDishName);
                cmd.Parameters.AddWithValue("@drinks", beverageName);
                cmd.Parameters.AddWithValue("@onemore", discountProductName);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);

                cmd.ExecuteReader();
                con.Close();
            }
        }

        private void timer訊息_Tick(object sender, EventArgs e)
        {
            string newst = Marqueest.Substring(0, 1); 
            Marqueest = Marqueest.Substring(1, Marqueest.Length - 1) + newst;
            
            lbl訊息.Text = Marqueest; 
        }

    }
}
