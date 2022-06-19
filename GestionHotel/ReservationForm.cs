using GestionHotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UCAPP.Data;

namespace GestionHotel
{
    public partial class ReservationForm : Form
    {
        DB db = new DB();
        public int id_Chambre { get; set; }
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            if(btnReserver.Text == "Reserver")
            {
                Client client = new Client(NomTextBox.Text.Trim()
                    , PrenomTextBox.Text.Trim() ,
                    AdresseTextBox.Text.Trim() ,
                    VilleTextBox.Text.Trim() , 
                    CodePostTextBox.Text.Trim() ,
                    PaysTextBox.Text.Trim(), 
                    TelephoneTextBox.Text.Trim(),
                    EmailTextBox.Text.Trim());

                db.AddClient(client);
                SejourForm sejourForm = new SejourForm();
                sejourForm.Id_Client = client.Id_Client;
                sejourForm.Id_Chambre = id_Chambre;
                this.Visible = false;
                sejourForm.Visible = true;
            }
        }
    }
}
