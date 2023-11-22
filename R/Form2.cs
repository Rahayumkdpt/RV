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
    public partial class Form2 : Form
    {
        DataTable dbdataset = new DataTable();
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form2()
        {
            alamat = "server=localhost; database=readvoyage; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Id_member.Clear();
            FirstName.Clear();
            LastName.Clear();
            username.Clear();
            password.Clear();
            confirm.Clear();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 == null)
            {
                form1 = new Form1();
                form1.Show();
            }
            else
            {
                form1.BringToFront();
            }

        }

        private void createA_Click(object sender, EventArgs e)
        {
            try
            {

                query = string.Format("insert into tbl_member(Id_member,FirstName,LastName,DateofBirth,Username, Password) values ('{0}', '{1}', '{2}', '{3}','{4}','{5}')", Id_member.Text, FirstName.Text, LastName.Text, DateofBirth.Text, username.Text, password.Text);
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Create account berhasil");
                    Form2_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Create account gagal");
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
