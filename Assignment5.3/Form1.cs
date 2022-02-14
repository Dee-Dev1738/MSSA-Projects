using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;


namespace Assignment5._3
{
    public partial class Form1 : Form
    {
        Car cars =new Car();
        public string filepath;
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        SoapFormatter soapFormatter = new SoapFormatter();
        DataContractJsonSerializer jsonSerializer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            
            cars.Cname=txtCname.Text;
            cars.Cmake=txtbCmake.Text;
            cars.Cyear = Int32.Parse(txtbCyear.Text);
            string filepath = @"C:\Files\cardata.txt";

            FileStream fileStream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //BinaryFormatter binaryFormatter = new BinaryFormatter(); //how you want to format it
            binaryFormatter.Serialize(fileStream, cars);//(where,what)
            fileStream.Close();
            MessageBox.Show("Data has been serilized");

        }

        private void btnBDs_Click(object sender, EventArgs e)
        {
            //Binary Deserilaztion

            string filepath = @"C:\Files\cardata.txt";
            FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            Car cars = (Car)binaryFormatter.Deserialize(stream);
            stream.Close();
            MessageBox.Show($"The Dekerialized Data is {cars.Cname}, {cars.Cmake}, {cars.Cyear}");
            
        }

        private void textCname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXMLS_Click(object sender, EventArgs e)
        {
            cars.Cname = txtCname.Text;
            cars.Cmake = txtbCmake.Text;
            cars.Cyear = Int32.Parse(txtbCyear.Text);
            FileStream fileStreamxml = new FileStream(@"C:\Files\carxml.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(fileStreamxml, cars);
            fileStreamxml.Close();
            MessageBox.Show("Your data is serialized...Again!!");
        }

        private void btnXMLDs_Click(object sender, EventArgs e)
        {
            FileStream fileStreamxmlnew = new FileStream(@"C:\Files\carxml.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Car cars = (Car)soapFormatter.Deserialize(fileStreamxmlnew);

            MessageBox.Show($"{ cars.Cname}, { cars.Cmake}, { cars.Cyear}");

            fileStreamxmlnew.Close();
        }

        private void btnJSONs_Click(object sender, EventArgs e)
        {
            cars.Cname = txtCname.Text;
            cars.Cmake = txtbCmake.Text;
            cars.Cyear = Int32.Parse(txtbCyear.Text);
            FileStream fileStream = new FileStream(@"C:\Files\carsjson.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(cars.GetType());
            jsonSerializer.WriteObject(fileStream, cars);// this when it serilaizies it
            fileStream.Close();
            MessageBox.Show("Yo Data has been serialized...FOR THE THIRD TIME!!");
        }

        private void btnJOSNDs_Click(object sender, EventArgs e)
        {
            FileStream fileStreamnew = new FileStream(@"C:\Files\carsjson.txt", FileMode.OpenOrCreate, FileAccess.Read);// Deserialized
            
            //Car cars = jsonSerializer.ReadObject(fileStreamnew) as Car;

            fileStreamnew.Close();
            MessageBox.Show($"This is your Deserialized data { cars.Cname}, { cars.Cmake}, { cars.Cyear}");
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
