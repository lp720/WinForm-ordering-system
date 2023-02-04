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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Member : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        List<int> SearchIDs = new List<int>();
        public Member()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb2";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            cbox欄位搜尋.Items.Add("name");
            cbox欄位搜尋.Items.Add("tel");
            cbox欄位搜尋.Items.Add("address");
            cbox欄位搜尋.Items.Add("email");
            cbox欄位搜尋.SelectedIndex = 0;
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)//ok
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from members where name like @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["name"].ToString();
                    txt電話.Text = reader["tel"].ToString();
                    txt地址.Text = reader["address"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["birth"]);
                }
                else
                {
                    MessageBox.Show("查無此人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblID.Text = "";
                    txt姓名.Clear();
                    txt電話.Clear();
                    txt地址.Clear();
                    txtEmail.Clear();
                    dtp生日.Value = DateTime.Now;
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)//ok
        {
            清空欄位();
        }

        private void btn修改資料_Click(object sender, EventArgs e)//ok
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update members set name = @NewName, tel = @NewPhone," +
                "address = @NewAddress, email= @NewEmail, birth = @NewBirthday where id =@SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@SearchId", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("異動成功, {0}個資料列受到影響", rows), "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)//ok
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from members where ID = @DeleteId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteId", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();

                MessageBox.Show(string.Format("刪除成功, {0}個資料列受到影響", rows), "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox搜尋結果.SelectedIndex >= 0)
            {
                int intSelectedID = SearchIDs[listBox搜尋結果.SelectedIndex];

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from members where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["name"].ToString();
                    txt電話.Text = reader["tel"].ToString();
                    txt地址.Text = reader["address"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["birth"]);
                }
                else
                {
                    MessageBox.Show("查無此人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblID.Text = "";
                    txt姓名.Clear();
                    txt電話.Clear();
                    txt地址.Clear();
                    txtEmail.Clear();
                    dtp生日.Value = DateTime.Now;
                }

                reader.Close();
                con.Close();
            }
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtEmail.Clear();
            dtp生日.Value = DateTime.Now;
            
        }

        private void btn搜尋_Click(object sender, EventArgs e)//ok
        {
            listBox搜尋結果.Items.Clear();
            SearchIDs.Clear();
            string str欄位名稱 = cbox欄位搜尋.SelectedItem.ToString();
            
            if (txtBox關鍵字搜尋.Text != "" && str欄位名稱 != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from members where " + str欄位名稱 + " like @SearchKeyword and birth <= @BirthEnd and birth >= @BirthStart ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", "%" + txtBox關鍵字搜尋.Text + "%");
                cmd.Parameters.AddWithValue("@BirthStart", dtp生日起始時間.Value);
                cmd.Parameters.AddWithValue("@BirthEnd", dtp生日結束時間.Value);
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    listBox搜尋結果.Items.Add(string.Format("{0} {1} {2}", reader["id"], reader["name"], reader["tel"]));
                    SearchIDs.Add((int)reader["id"]);
                    i += 1;
                }
                if (i == 0)
                {
                    MessageBox.Show("查無此人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入查詢關鍵字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            
        }

        private void btn新增資料_Click_1(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert members ([name], [tel], [address], [email], [birth], [password]) values (@NewName, @NewPhone, @NewAddress, @NewEmail, @NewBirthday, @password)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@password", "123");

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("新增成功, {0}個資料列受到影響", rows), "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
