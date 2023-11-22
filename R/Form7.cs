using System;
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
    public partial class Form7 : Form
    {
        DataTable dbdataset = new DataTable();
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public Form7()
        {
            alamat = "server=localhost; database=readvoyage; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("update tbl_member set FirstName = '{0}', LastName = '{1}', DateofBirth = '{2}', Username = '{3}', Password = '{4}' where Id_member ='{5}'", FirstName.Text, LastName.Text, DateofBirth.Text, Username.Text, Password.Text, Id_member.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Update data berhasil");
                    Form7_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Update data gagal");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
