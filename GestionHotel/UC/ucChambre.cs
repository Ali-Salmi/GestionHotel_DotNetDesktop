using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionHotel.UC
{
    public partial class ucChambre : UserControl
    {
        public int id_Chambre { get; set; }

        public ucChambre()
        {
            InitializeComponent();
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.id_Chambre = id_Chambre;
            reservationForm.Visible = true;
        }
    }
}
