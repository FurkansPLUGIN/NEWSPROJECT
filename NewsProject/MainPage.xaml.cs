using NewsProject.carouselInTabbed;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewsProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int giden;
        async void pageBaglanti()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                await Navigation.PushModalAsync(new Page3());
                MessagingCenter.Send<MainPage, int>(this, "deger", giden);
            }
            else
            {
                await DisplayAlert("Warning", "Please open the internet", "Ok");
            }

        }
        private void cnn_Clicked(object sender, EventArgs e)
        {
            giden = 0;
            pageBaglanti();
        }

        private void bbc_Clicked(object sender, EventArgs e)
        {
            giden = 1;
            pageBaglanti();
        }

        private void wp_Clicked(object sender, EventArgs e)
        {
            giden = 2;
            pageBaglanti();
        }

        private void wsj_Clicked(object sender, EventArgs e)
        {
            giden = 3;
            pageBaglanti();
        }

        private void nyt_Clicked(object sender, EventArgs e)
        {
            giden = 4;
            pageBaglanti();
        }

        private void bloom_Clicked(object sender, EventArgs e)
        {
            giden = 5;
            pageBaglanti();
        }

        private void tg_Clicked(object sender, EventArgs e)
        {
            giden = 6;
            pageBaglanti();
        }

        private void nbc_Clicked(object sender, EventArgs e)
        {
            giden = 7;
            pageBaglanti();
        }
    }
}
