using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Page4());
        }
    }
}
