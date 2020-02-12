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
            List<String> emptyItems = new List<String>();

            if (String.IsNullOrEmpty(textBoxHouseID.Text))
            {
                emptyItems.Add("House ID");
            }

            if (comboBoxType.SelectedItem == null)
            {
                emptyItems.Add("Type");
            }

            if (String.IsNullOrEmpty(textBoxPrice.Text))
            {
                emptyItems.Add("Price");
            }

            if (String.IsNullOrEmpty(textBoxLocation.Text))
            {
                emptyItems.Add("Location");
            }

            if (String.IsNullOrEmpty(textBoxPostcode.Text))
            {
                emptyItems.Add("Postcode");
            }

            if (comboBoxBedrooms.SelectedItem == null)
            {
                emptyItems.Add("Bedrooms");
            }

            if (comboBoxBathrooms.SelectedItem == null)
            {
                emptyItems.Add("Bathrooms");
            }

            if (comboBoxCarspaces.SelectedItem == null)
            {
                emptyItems.Add("Carspaces");
            }

            if (String.IsNullOrEmpty(textBoxLatitude.Text))
            {
                emptyItems.Add("Latitude");
            }

            if (String.IsNullOrEmpty(textBoxLongitude.Text))
            {
                emptyItems.Add("Longitude");
            }

            if (comboBoxPriceRating.SelectedItem == null)
            {
                emptyItems.Add("Price Rating");
            }

            if (comboBoxHouseRating.SelectedItem == null)
            {
                emptyItems.Add("House Rating");
            }

            if (comboBoxSafetyRating.SelectedItem == null)
            {
                emptyItems.Add("Safety Rating");
            }

            if (comboBoxTransportRating.SelectedItem == null)
            {
                emptyItems.Add("Transport Rating");
            }

            if (comboBoxLocationRating.SelectedItem == null)
            {
                emptyItems.Add("Location Rating");
            }

            if (comboBoxPotentialRating.SelectedItem == null)
            {
                emptyItems.Add("Potential Rating");
            }

            if (String.IsNullOrEmpty(textBoxTotalRating.Text))
            {
                emptyItems.Add("Total Rating");
            }

            if (String.IsNullOrEmpty(textBoxDistanceFromWorkTegan.Text))
            {
                emptyItems.Add("Distance From Work Tegan");
            }
            Console.WriteLine(emptyItems.Count().ToString());
            if (emptyItems.Count() == 0)
            {
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
            else
            {
                String errorString = "";
                foreach (String s in emptyItems)
                {
                    errorString = errorString + ", " + s;
                }

                MessageBox.Show("The following items must not be empty:" + errorString);

                emptyItems.Clear();
            }





        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
