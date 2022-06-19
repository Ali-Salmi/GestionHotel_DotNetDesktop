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
    public partial class SejourForm : Form
    {
        DB db = new DB();
        public int Id_Chambre;
        public int Id_Client;
        public SejourForm()
        {
            InitializeComponent();
        }

        private void SejourForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            
            if(btnConfirmer.Text == "Confirmer")
            {
                Reservation reservation = new Reservation(Id_Chambre,Id_Client, dateTimePicker1.Value);
                db.AddReservation(reservation);
                MessageBox.Show("Réservation Ajoutée");
            }
        }
    }
}
