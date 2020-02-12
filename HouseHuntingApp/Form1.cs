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
using System.Data.Linq;

namespace HouseHuntingApp
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Data Source = DESKTOP-T7PKUAC\SQLEXPRESS; Initial Catalog = HouseHuntingDB; Integrated Security = True";
        SqlConnection con = new SqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HouseClassDataContext dc = new HouseClassDataContext(con);

            updateTable(dc);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

            HouseClassDataContext dc = new HouseClassDataContext(con);
            House newHouse = new House();

            

        }

        private void updateTable(HouseClassDataContext dc)
        {
            var SelectQuery =
                from h in dc.GetTable<House>()
                select h;

            dataGridViewHouses.DataSource = SelectQuery;
            
        }
    }
}
