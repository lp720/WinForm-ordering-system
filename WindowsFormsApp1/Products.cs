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
    public partial class Products : Form
    {
        string strDBConnectionString = "";
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();
        List<int> listState = new List<int>();
        public Products()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb2";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();
            讀取資料庫();
            showListView圖片模式();
        }
        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 100 * from menu";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"image\";//圖檔路徑(做成全域變數)
            string image_name = "";//圖檔名稱
            int i = 0;

            while (reader.Read())
            {
                listId.Add((int)reader["id"]);
                listPname.Add(reader["餐點"].ToString());
                listPrice.Add((int)reader["價格"]);
                listState.Add(Convert.ToInt32(reader["供應狀態"]));
                image_name = reader["pimage"].ToString();
                imageListPhoto.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }

        private void btn圖片_Click(object sender, EventArgs e)
        {
            showListView圖片模式();
        }

        void showListView圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;
            imageListPhoto.ImageSize = new Size(190, 175);
            listView商品展示.LargeImageList = imageListPhoto;
            listView商品展示.SmallImageList = imageListPhoto;

            for (int i = 0; i < imageListPhoto.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
                item.Text = Convert.ToString("$" + listPrice[i]);
                item.Tag = listId[i];
                listView商品展示.Items.Add(item);
            }
        }
        private void btn列表_Click(object sender, EventArgs e)
        {
            showListView列表模式();
        }
        void showListView列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("id", 100);
            listView商品展示.Columns.Add("商品", 200);
            listView商品展示.Columns.Add("商品價格", 80);
            listView商品展示.Columns.Add("供應狀態", 80);
            listView商品展示.FullRowSelect = true;
            listView商品展示.GridLines = true;

            for (int i = 0; i < listId.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listId[i].ToString();//第一欄
                item.SubItems.Add(listPname[i]);//第二欄(從第二欄位後用的是SubItems.Add())
                item.SubItems.Add(listPrice[i].ToString());//第三欄
                if (listState[i] == 1)
                {
                    item.SubItems.Add("Yes");
                }
                else if (listState[i] == 0)
                {
                    item.SubItems.Add("No");
                }
                //item.Tag = listId[i];

                listView商品展示.Items.Add(item);
            }
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            ProductDetail myProductDetail = new ProductDetail();
            myProductDetail.ShowDialog();
        }

        private void btn重新_Click(object sender, EventArgs e)
        {
            listId.Clear();
            listPname.Clear();
            listPrice.Clear();
            listState.Clear();
            imageListPhoto.Images.Clear();
            讀取資料庫();
            if (listView商品展示.View == View.Details)
            {
                showListView列表模式();
            }
            else
            {
                showListView圖片模式();
            }
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            ProductDetail myProductDetail = new ProductDetail();
            myProductDetail.productID = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);
            myProductDetail.ShowDialog();
        }
    }

}
