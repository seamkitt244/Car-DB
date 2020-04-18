using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CarInventory
{
    public partial class Form1 : Form
    {

        List<Car> carsList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            loadDB();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveDB();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(yearInput.Text);
            string year, make, colour, mileage;
            year = idInput.Text;
            make = makeInput.Text;
            colour = colourInput.Text;
            mileage = mileageInput.Text;

            Car cars = new Car(id, year, make, colour, mileage);
            carsList.Add(cars);

            carsList = carsList.OrderBy(car=>car.id).ToList();

            //for (int i = 0; i < carsList.Count; i++)
            //{
            //    outputLabel.Text += carsList[i].year + " " + carsList[i].make + " " + carsList[i].colour + " " + carsList[i].mileage + "\n";
            //}
            outputLabel.Text = "new car added successfully";
            ClearLabels();
        }
        private void listButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            //if (idButton.Checked = true)
            //{carsList = carsList.OrderBy(car => car.id).ToList();}
            ////if (yearButton.Checked = true)
            ////{carsList = carsList.OrderBy(car => car.year).ToList();}
            ////if (makeButton.Checked = true)
            ////{carsList = carsList.OrderBy(car => car.make).ToList();}cant get this to work
            ////if (colourButton.Checked = true)
            ////{ carsList = carsList.OrderBy(car => car.colour).ToList(); }
            //if (mileageButton.Checked = true)
            //{carsList = carsList.OrderBy(car => car.mileage).ToList(); }


            foreach (Car car in carsList)
            {
                outputLabel.Text += car.id + ") " + car.year + " " + car.make +" " + car.colour + " " + car.mileage + "\n";
            }
            ClearLabels();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            int searchID = Convert.ToInt16(idInput.Text);

            int index = carsList.FindIndex(car => car.id == searchID);

            if (index >= 0)
            {
                carsList.RemoveAt(index);
                outputLabel.Text = "Car " + searchID + " removed";
            }
            else
            {
                outputLabel.Text = "Auto ID not found";
            }

            ClearLabels();
        }
        public void loadDB()
        {
            int newID;
            string newYear, newMake, newColour, newMileage;

            XmlReader reader = XmlReader.Create("Resources/carInfo.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newID = Convert.ToInt16(reader.ReadString());

                    reader.ReadToNextSibling("year");
                    newYear = reader.ReadString();

                    reader.ReadToNextSibling("make");
                    newMake = reader.ReadString();

                    reader.ReadToNextSibling("colour");
                    newColour = reader.ReadString();

                    reader.ReadToNextSibling("mileage");
                    newMileage = reader.ReadString();

                    Car car = new Car(newID, newYear, newMake, newColour, newMileage);
                    carsList.Add(car);
                }
            }

            reader.Close();
        }
        public void saveDB()
        {
            XmlWriter writer = XmlWriter.Create("Resources/carInfo.xml", null);

            writer.WriteStartElement("Cars");

            foreach (Car e in carsList)
            {
                writer.WriteStartElement("Car");

                writer.WriteElementString("id", Convert.ToString(e.id));
                writer.WriteElementString("year", e.year);
                writer.WriteElementString("make", e.make);
                writer.WriteElementString("colour", e.colour);
                writer.WriteElementString("mileage", e.mileage);

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }

        private void ClearLabels()
        {
            idInput.Text = "";
            makeInput.Text = "";
            yearInput.Text = "";
            colourInput.Text = "";
            mileageInput.Text = "";
            idButton.Checked = false;
            makeButton.Checked = false;
            yearButton.Checked = false;
            mileageButton.Checked = false;
            colourButton.Checked = false;

        }
    }
}
