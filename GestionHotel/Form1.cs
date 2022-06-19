using GestionHotel.Models;
using GestionHotel.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCAPP.Data;

namespace GestionHotel
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        List<Hotel> hotels = new List<Hotel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hotels.Clear();
            hotels = db.SelectHotels();
            int y = 135;
            foreach(Hotel hotel in hotels)
            {
                ucHotel uchotel = new ucHotel(this);
                uchotel.Hotel_ID = hotel.Id_hotel;
                uchotel.NomLabel.Text = hotel.Nom;
                uchotel.Nom = hotel.Nom;
                uchotel.AdresseLabel.Text = hotel.Adresse;
                uchotel.TelephoneLabel.Text = hotel.Telephone;
                uchotel.EtoileLabel.Text = hotel.Etoile.ToString() + " Etoiles";
                uchotel.Location = new Point(0, y);
                Hotelspanel.Controls.Add(uchotel);
                y += uchotel.Height + 10;

                
            }
        }
    }
}
