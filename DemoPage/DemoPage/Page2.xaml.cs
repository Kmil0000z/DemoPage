using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            await Navigation.PushAsync(new Page3());
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            var resp = await DisplayAlert("Test", "Está seguro de realizar el test", "Si", "No");
            if(resp){
                await DisplayAlert("Inicio de Test", "Super Bienvenido", "Aceptar");
                var opcion = await DisplayActionSheet("Opciones", "Cancelar", null, "Opción 1", "Opción 2", "Opción 3");
                lbOpcion.Text = opcion.ToString();
            }else{
                await DisplayAlert("Test fallido", "En otra ocación será...", "Aceptar");
            }
        }
    }
}
