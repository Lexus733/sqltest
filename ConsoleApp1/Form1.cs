﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        Program pr = new Program();
        InventoryDAL dl = new InventoryDAL();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableDataGridView.DataSource = dl.GetAllYableAsDataTable("Crew");
            dataGridView1.DataSource = dl.GetAllYableAsDataTable("Race");
        }

    }
}
