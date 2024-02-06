using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppExercicioGeo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async Task MapaAberto()
        {
            var pais = await Geocoding.GetLocationsAsync(txtPais.Text);
            var estado = await Geocoding.GetLocationsAsync(txtUF.Text);
            var local = await Geocoding.GetLocationsAsync(txtLocal.Text);
            var cidade = await Geocoding.GetLocationsAsync(txtCidade.Text);

            var Cpais = pais?.FirstOrDefault();
            if (Cpais != null)
            {
                
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
