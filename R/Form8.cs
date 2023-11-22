using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && (password.Text == "12345" ))
            {
                Form5 form5 = new Form5();
                form5.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("anda salah memasukkan username atau password");
            }
        }
    }
}
