using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseHuntingApp
{
    public partial class Form2 : Form
    {

        SqlConnection con = new SqlConnection(SQLQueryClass.connectionString);

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCalcTotalRating_Click(object sender, EventArgs e)
        {
            int priceWeight = 10;
            int houseWeight = 10;
            int safteyWeight = 30;
            int transportWeight = 20;
            int locationWeight = 20;
            int potentialWeight = 10;

            double price = priceWeight * (Int32.Parse(comboBoxPriceRating.SelectedItem.ToString()) / 5.0);
            double house = houseWeight * (Int32.Parse(comboBoxHouseRating.SelectedItem.ToString()) / 5.0);
            double safety = safteyWeight * (Int32.Parse(comboBoxSafetyRating.SelectedItem.ToString()) / 5.0);
            double transport = transportWeight * (Int32.Parse(comboBoxTransportRating.SelectedItem.ToString()) / 5.0);
            double location = locationWeight * (Int32.Parse(comboBoxLocationRating.SelectedItem.ToString()) / 5.0);
            double potential = potentialWeight * (Int32.Parse(comboBoxPotentialRating.SelectedItem.ToString()) / 5.0);

            textBoxTotalRating.Text = (price + house + safety + transport + location + potential).ToString();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            HouseClassDataContext dc = new HouseClassDataContext(con);
            House newHouse = new House();

            newHouse.HouseID = Int32.Parse(textBoxHouseID.Text);
            newHouse.Type = comboBoxType.SelectedItem.ToString();
            newHouse.Price = float.Parse(textBoxPrice.Text);
            newHouse.Location = textBoxLocation.Text;
            newHouse.Postcode = Int32.Parse(textBoxPostcode.Text);
            newHouse.Bedrooms = Int32.Parse(comboBoxBedrooms.SelectedItem.ToString());
            newHouse.Bathrooms = Int32.Parse(comboBoxBathrooms.SelectedItem.ToString());
            newHouse.Carspaces = Int32.Parse(comboBoxCarspaces.SelectedItem.ToString());
            newHouse.Latitude = float.Parse(textBoxLatitude.Text);
            newHouse.Longitude = float.Parse(textBoxLongitude.Text);
            newHouse.priceRating = Int32.Parse(comboBoxPriceRating.SelectedItem.ToString());
            newHouse.houseRating = Int32.Parse(comboBoxHouseRating.SelectedItem.ToString());
            newHouse.safetyRating = Int32.Parse(comboBoxSafetyRating.SelectedItem.ToString());
            newHouse.transportRating = Int32.Parse(comboBoxTransportRating.SelectedItem.ToString());
            newHouse.locationRating = Int32.Parse(comboBoxLocationRating.SelectedItem.ToString());
            newHouse.potentialRating = Int32.Parse(comboBoxPotentialRating.SelectedItem.ToString());
            newHouse.totalRating = float.Parse(textBoxTotalRating.Text);
            newHouse.distanceFromTeganWork = float.Parse(textBoxDistanceFromWorkTegan.Text);

            dc.Houses.InsertOnSubmit(newHouse);
            dc.SubmitChanges();

            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
