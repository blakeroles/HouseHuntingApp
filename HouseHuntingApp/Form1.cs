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
        
        SqlConnection con = new SqlConnection(SQLQueryClass.connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HouseClassDataContext dc = new HouseClassDataContext(con);

            IQueryable<House> houseQuery = SQLQueryClass.updateTable(dc);
            dataGridViewHouses.DataSource = houseQuery;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

           
        }

    }
}
