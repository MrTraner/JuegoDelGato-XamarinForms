using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuegoDelGato
{
    public partial class MainPage : ContentPage
    {
        private int turno = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCasilla_Clicked(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                ((Button)sender).Text = "X";
                turno = 1;
            }
            else
            {
                ((Button)sender).Text = "O";
                turno = 0;
            }
        }
    }
}
