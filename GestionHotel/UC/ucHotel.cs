using GestionHotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UCAPP.Data;

namespace GestionHotel.UC
{
    public partial class ucHotel : UserControl
    {
        public int Hotel_ID { get; set; }
        public string Nom { get; set; }
        public Form1 Form1;
        List<Chambre> chambres = new List<Chambre>();
        DB dB = new DB();
        public ucHotel(Form1 form1)
        {
            InitializeComponent();
            Form1 = form1;
        }

        private void ucHotel_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            chambres.Clear();
            Form1.ChambrePanel.Controls.Clear();
            Form1.ChambreLabel.Text = Nom;
            chambres = dB.SelectChambres(Hotel_ID);
            int y= 10;
            foreach(Chambre chambre in chambres)
            {
                ucChambre ucchambre = new ucChambre();
                ucchambre.NumeroLabel.Text = "Chambre Numéro : " + chambre.Numero;
                ucchambre.TelephoneLabel.Text = "Telephone : " + chambre.Telephone;
                string category = dB.SelectCategory(chambre.Id_categorie).Description;
                ucchambre.CategoryLabel.Text = category;
                ucchambre.id_Chambre = chambre.Id_chambre;
                ucchambre.Location = new Point(0, y);
                y += ucchambre.Height + 10;
                Form1.ChambrePanel.Controls.Add(ucchambre);
            }
            
        }
    }
}
