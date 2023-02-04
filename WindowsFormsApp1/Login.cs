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
using System.Diagnostics;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString = "";
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb2";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if ((txtemail.Text != "") && (txtpassword.Text != ""))
            {
                string stremail = txtemail.Text;
                string strpassword = txtpassword.Text;

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select [id], [name], [tel] from members where email = @Email and password = @Password";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Email", stremail);
                cmd.Parameters.AddWithValue("@Password", strpassword);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["name"];
                    string tel = (string)reader["tel"];
                    int position = 0;


                    ArrayList user = new ArrayList();
                    user.Add(id);
                    user.Add(name);
                    user.Add(tel);
                    user.Add(position);
                    GlobalVar.user.Add(user);

                    Close();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Text = "";
                    txtpassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("請輸入帳號、密碼", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Text = "";
                txtpassword.Text = "";
            }
        }

        private void btn職員_Click(object sender, EventArgs e)
        {
            if ((txtemail.Text != "") && (txtpassword.Text != ""))
            {
                string stremail = txtemail.Text;
                string strpassword = txtpassword.Text;

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select [id], [name], [tel], [職位] from staffs where email = @Email and password = @Password";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Email", stremail);
                cmd.Parameters.AddWithValue("@Password", strpassword);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["name"];
                    string tel = "不顯示";
                    int position = (int)reader["職位"];

                    ArrayList user = new ArrayList();
                    user.Add(id);
                    user.Add(name);
                    user.Add(tel);
                    user.Add(position);

                    GlobalVar.user.Add(user);

                    Close();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Text = "";
                    txtpassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("請輸入帳號、密碼", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Text = "";
                txtpassword.Text = "";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewMember mymember = new NewMember();
            mymember.ShowDialog();
            Close();
        }
    }
}

