using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ModDemo4
{
    public partial class Form1 : Form
    {
        ArrayList anmlist;
        //CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anmlist = new ArrayList();
            anmlist.Add(new Anime() { Eid = 1, FirstName = "Goku", LastName="Son", Dept=Department.A});
            anmlist.Add(new Anime() { Eid = 2, FirstName = "Naruto", LastName = "Uzumaki", Dept = Department.B });
            anmlist.Add(new Anime() { Eid = 3, FirstName = "Meliodas", LastName = "Wraith", Dept = Department.C });
            anmlist.Add(new Anime() { Eid = 4, FirstName = "Yugi", LastName = "Mutuo", Dept = Department.A });
            anmlist.Add(new Anime() { Eid = 5, FirstName = "Light", LastName = "Yagami", Dept = Department.D});
            anmGrid.DataSource= anmlist;
            comboBox1.DataSource = Enum.GetValues(typeof(Department));
            comboBox2.DataSource = Enum.GetValues(typeof(Months));

            grpAnm.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpAnm.Visible = true;
            if (txbID.Text != String.Empty && txtbFN.Text != String.Empty && txtbLN.Text != String.Empty)
            {
                Anime newAnm = new Anime();
                newAnm.Eid = Int32.Parse(txbID.Text);
                newAnm.FirstName = txtbFN.Text;
                newAnm.LastName = txtbLN.Text;
                newAnm.Dept = (Department)comboBox1.SelectedIndex;
                anmlist.Add(newAnm);

            }
            RefreshData();
        }
        private void RefreshData()
        {
            txbID.Clear();
            txtbFN.Clear();
            txtbLN.Clear();
            anmGrid.DataSource = null;
            anmGrid.DataSource = anmlist;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            anmlist.RemoveAt(anmGrid.CurrentRow.Index);
            RefreshData();
        }

        private void anmGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
