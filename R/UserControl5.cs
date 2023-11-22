using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace R
{
    public partial class UserControl5 : UserControl
    {
        DataTable dbdataset = new DataTable();
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public UserControl5()
        {
            alamat = "server=localhost; database=readvoyage; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from tbl_member");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[0].HeaderText = "Id_member";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "FirstName";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "LastName";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "DateofBirth";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Username";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Password";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_member where Id_member ='{0}'", Id_member.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        username.Text = kolom["username"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                    UserControl5_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from tbl_member where Id_member ='{0}'", Id_member.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                UserControl5_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Id_member.Clear();
            username.Clear();
        }
    }
}
