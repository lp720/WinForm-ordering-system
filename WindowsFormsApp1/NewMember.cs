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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    
    public partial class NewMember : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        List<int> SearchIDs = new List<int>();
        public NewMember()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void NewMember_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb2";//database名稱
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != "") && (txt密碼.Text != ""))
            {
                string mail = txtEmail.Text;
                bool email = Regex.IsMatch(mail, @"^\w+((-\w+)|(.\w+))*\@[A-Za-z0-9]+((.|-)[A-Za-z0-9]+).[A-Za-z]+$");

                if (email == true)
                {
                    List<string> members_mail = new List<string>();
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from members";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string Email = reader["email"].ToString();
                        members_mail.Add(Email);
                    }
                    reader.Close();
                    con.Close();

                    for (int i = 0; i < members_mail.Count; i++)
                    {
                        if (members_mail[i] == txtEmail.Text)
                        {
                            MessageBox.Show(string.Format("此Email已註冊"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEmail.Clear();
                            txt密碼.Clear();
                            break;
                        }
                    }
                    if (mail == txtEmail.Text && email == true)
                    {
                        if (txt密碼.Text == txt確認密碼.Text)
                        {
                            SqlConnection con1 = new SqlConnection(strDBConnectionString);
                            con1.Open();
                            string strSQL1 = "insert into members ([name], [tel], [address], [email], [birth], [password]) values (@NewName, @NewPhone, @NewAddress, @NewEmail, @NewBirthday, @password)";
                            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
                            cmd1.Parameters.AddWithValue("@NewName", txt姓名.Text);
                            cmd1.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                            cmd1.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                            cmd1.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                            cmd1.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                            cmd1.Parameters.AddWithValue("@password", txt密碼.Text);

                            int rows = cmd1.ExecuteNonQuery();
                            con1.Close();
                            MessageBox.Show(string.Format("成功加入會員!"), "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt姓名.Clear();
                            txt電話.Clear();
                            txt地址.Clear();
                            txtEmail.Clear();
                            txt密碼.Clear();
                            txt確認密碼.Clear();
                            Close();
                        }
                        else if (txt密碼.Text != txt確認密碼.Text)
                        {
                            MessageBox.Show(string.Format("密碼有誤"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt密碼.Clear();
                            txt確認密碼.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("格式錯誤請重新輸入"), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txt密碼.Clear();
                }
            }
            else 
            {
                MessageBox.Show(string.Format("必填欄位是否輸入?"), "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txt確認密碼_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
