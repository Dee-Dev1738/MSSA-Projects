using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarAssignment
{
    public partial class Form1 : Form
    {
        CarRepository repository;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Clear()
        {
            txtbVIN.Clear();
            txtbMake.Clear();
            txtbModel.Clear();
            txtbPrice.Clear();
            txtbYear.Clear();
        }


        private void grdCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repository = new CarRepository();
            grdCar.DataSource = repository.GetCars();
            btnSubmit.Visible = false;
            grpboxCarD.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            txtbVIN.Clear();
            txtbMake.Clear();
            txtbModel.Clear();
            txtbYear.Clear();
            txtbPrice.Clear();
            btnSubmit.Visible = true;
            btnDelete.Visible=false;
            grpboxCarD.Visible = true;
            btnSubUpdate.Visible = false;
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbVIN.Text) && !string.IsNullOrWhiteSpace(txtbMake.Text) && !string.IsNullOrWhiteSpace(txtbModel.Text) && !string.IsNullOrWhiteSpace(txtbPrice.Text) && !string.IsNullOrWhiteSpace(txtbYear.Text))
            {
                
                var newcar = new Car();
                newcar.VIN = txtbVIN.Text;
                newcar.Make=txtbMake.Text;
                newcar.Model=txtbModel.Text;
                newcar.Year = Convert.ToInt32(txtbYear.Text);
                newcar.Price = Convert.ToInt32(txtbPrice.Text);
                repository.AddCar(newcar);
            }
            
            Clear();


        }
        private void btnSubUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            var vin = txtbVIN.Text;
            var newcar = repository.Findcar(vin);
            //var newcar = new Car();
            newcar.VIN = txtbVIN.Text;
            newcar.Make = txtbMake.Text;
            newcar.Model = txtbModel.Text;
            newcar.Year = Convert.ToInt32(txtbYear.Text);
            newcar.Price = Decimal.Parse(txtbPrice.Text);
            MessageBox.Show("Your Vehical has been modified!");
            repository.UpdateCar(vin,newcar);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var car = grdCar.CurrentRow.Cells[0].Value.ToString();
            var cartodel = repository.Findcar(car);
            repository.DeleteCar(cartodel);
            
            MessageBox.Show("Car has been Deleted from Entry!");
            Refresh();
        }
        public void Refresh()
        {
            grdCar.DataSource = null;
            grdCar.DataSource = repository.GetCars();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grdCar.DataSource = null;
            grdCar.DataSource = repository.GetCars();

            btnDelete.Visible = true;
            MessageBox.Show("Data has Been Refreshed!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var car = repository.Findcar(grdCar.CurrentRow.Cells[0].Value.ToString());
            txtbVIN.Text=car.VIN;
            txtbMake.Text=car.Make;
            txtbModel.Text=car.Model;
            txtbYear.Text = car.Year.ToString();
            txtbPrice.Text = car.Price.ToString();



            
            grpboxCarD.Visible = true;
            btnAdd.Visible = false;
            btnDelete.Visible=false;
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this Aplication?";
            string title = "Leaving";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }
            else
            {
               //cancelled
            }

            
        }
    }
}
