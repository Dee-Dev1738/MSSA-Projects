using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDatabaseProject
{
    public partial class Cardlib : Form
    {
        CardRepository repository;
        Bitmap bitmap;
        public Cardlib()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);
            btnSubupdate.Visible = false;
        }
        public void Refresh() // Refresh the grid
        {
            gridMonsters.DataSource = null;
            gridMonsters.DataSource = repository.GetMonsterCards();
        }

        private void Cardlib_Load(object sender, EventArgs e)
        {
            repository = new CardRepository();
            gridMonsters.DataSource = repository.GetMonsterCards(); // Load the data on the grid
            
        }

        private void btnspellspage_Click(object sender, EventArgs e) // Transistion to Spell card page
        {
            this.Hide();
            SpellLibrary F2 = new SpellLibrary();
            F2.Show();
            
        }

        private void btnMonsterPage_Click(object sender, EventArgs e)// Just to Refresh the page
        {
            Refresh();
            MessageBox.Show("Your Deck has been Refreshed.");

        }

        private void btnVeiwAllCards_Click(object sender, EventArgs e)
        {
            //Transition to View All 
            this.Hide();
            ViewAllMon V2 = new ViewAllMon();
            V2.Show();
        }
        private void Clear()
        {
            txtbCMID.Clear();
            txtbCNM.Clear();
            txtbATK.Clear();
            txtbDEF.Clear();
            txtbPrice.Clear();
            txtbPrice.Clear();
        }


        private void btnaddcd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Your New Card!!");
            txtbCMID.Clear();
            txtbCNM.Clear();
            txtbATK.Clear();
            txtbDEF.Clear();
            txtbPrice.Clear();
            txtEdition.Clear();
            btnaddcd.Visible = false;
            btnMonsterPage.Visible = false;
            btnspellspage.Visible = false;
            btnVeiwAllCards.Visible = false;
            lblwelcome.Visible = false;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbCMID.Text) && !string.IsNullOrWhiteSpace(txtbCNM.Text) && !string.IsNullOrWhiteSpace(txtbATK.Text)&& !string.IsNullOrWhiteSpace(txtbDEF.Text)&& !string.IsNullOrWhiteSpace(txtbPrice.Text) && !string.IsNullOrWhiteSpace(txtEdition.Text))
            {
                try
                {
                    var newcard = new MonsterCard();
                    newcard.Id_Code = txtbCMID.Text;
                    newcard.Name = txtbCNM.Text;
                    newcard.Attack = txtbATK.Text;
                    newcard.Defences = txtbDEF.Text;
                    newcard.Price = Decimal.Parse(txtbPrice.Text);
                    repository.AddCard(newcard);
                    MessageBox.Show("Your New card was added to your Deck");
                    Refresh();
                }
                catch
                {
                    MessageBox.Show("One of the fields is not falid.");
                }
            }
            else
            MessageBox.Show("Please Fill all Fields!");
            

            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this Aplication?";
            string title = "Exiting Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //cancelled
            }
        }

        private void printMenuItem_Click(object sender, EventArgs e)
        {
            int height = gridMonsters.Height;
            gridMonsters.Height = gridMonsters.RowCount * gridMonsters.RowTemplate.Height;
            
            //create bitmap size
            bitmap = new Bitmap(gridMonsters.Width, height);
            gridMonsters.DrawToBitmap(bitmap, new Rectangle(0, 0, this.gridMonsters.Width, this.gridMonsters.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            
            // Display Grid to regular size
            gridMonsters.Height = height;
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //print grid image
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnupdateCD_Click(object sender, EventArgs e)
        {
            //Edit card
            var card = repository.FindMonster(gridMonsters.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Please select card to update!");
            txtbCMID.Text = card.Id_Code;
            txtbCNM.Text = card.Name;
            txtbATK.Text = card.Attack;
            txtbDEF.Text = card.Defences;
            txtEdition.Text = card.Edition.ToString();
            txtbPrice.Text=card.Price.ToString();

            btnaddcd.Visible = false;
            btnSubupdate.Visible = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delet Card
            var card = gridMonsters.CurrentRow.Cells[0].Value.ToString();
            var cardtodel = repository.FindMonster(card);
            repository.RemoveCard(cardtodel);
            Refresh();
            MessageBox.Show("Card has been deleted");
           
        }
     
        private void btnSubupdate_Click(object sender, EventArgs e)
        {
            var id =txtbCMID.Text;
            var newcard=repository.FindMonster(id);
            newcard.Id_Code = txtbCMID.Text;
            newcard.Name = txtbCNM.Text;
            newcard.Attack=txtbATK.Text;
            newcard.Defences=txtbDEF.Text;
            newcard.Price = Decimal.Parse(txtbPrice.Text);
            repository.updateCard(id, newcard);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCM_MouseHover(object sender, EventArgs e)
        {

        }
        private void chckbx_Click(object sender, EventArgs e)
        {
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
