﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HouseHuntingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            House house1 = new House();

        }

        private void connectToDB_Click(object sender, EventArgs e)
        {
            // Connection properties
            string connectionString;
            SqlConnection cnn;

            // Connect to Database
            connectionString = @"Data Source=DESKTOP-T7PKUAC\SQLEXPRESS;Initial Catalog=HouseHuntingDB;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
            cnn.Close();
        }
    }
}
