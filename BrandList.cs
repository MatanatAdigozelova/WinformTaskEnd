﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTask
{
    public partial class BrandList : Form
    {
        public BrandList()
        {
            InitializeComponent();
        }

        private void BrandList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=ElectronicShop;Integrated Security=True");
            con.Open();
            string sqlselect = "select * from Brands";
        }
    }
}
