using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            BrandList brandlist= new BrandList();
            brandlist.Show();
            this.Hide();
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {

        }

        private void btnPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
