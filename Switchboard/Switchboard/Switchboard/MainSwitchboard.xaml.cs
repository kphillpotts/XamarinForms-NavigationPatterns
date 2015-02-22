using Switchboard.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Switchboard
{
    public partial class MainSwitchboard : ContentPage
    {
        public MainSwitchboard()
        {
            InitializeComponent();
        }

        public async void CameraButtonTapped (object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CameraPage());
        }

        public async void TagButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TagPage());
        }

        public async void ShoppingButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }

        public async void TwitterButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TwitterPage());
        }

    }
}
