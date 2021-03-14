using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsProject.carouselInTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            if (CrossConnectivity.Current.IsConnected)
            {
                MessagingCenter.Subscribe<MainPage, int>(this, "deger", (sender, value) =>
                {
                    if (value == 0)
                    {
                        link.Source = "https://www.nytimes.com/";

                    }
                    if (value == 1)
                    {
                        link.Source = "https://www.bbc.com/news";

                    }
                    if (value == 2)
                    {
                        link.Source = "https://www.washingtonpost.com/";

                    }

                    if (value == 3)
                    {
                        link.Source = "https://www.wsj.com/";

                    }
                    if (value == 4)
                    {
                        link.Source = "https://edition.cnn.com/";

                    }

                    if (value == 5)
                    {
                        link.Source = "https://www.bloomberg.com/middleeast";

                    }
                    if (value == 6)
                    {
                        link.Source = "https://www.theguardian.com/international";

                    }
                    if (value == 7)
                    {
                        link.Source = "https://www.nbcnews.com/";

                    }
                    MessagingCenter.Unsubscribe<MainPage, string>(this, "deger");
                });
            }
            else
            {
                DisplayAlert("Warning", "Please open the internet", "Ok");
            }

        //https://www.nytimes.com/ 
        //https://www.bbc.com/news
        //https://www.washingtonpost.com/
        //https://www.wsj.com/
        //https://edition.cnn.com/
        //https://www.bloomberg.com/middleeast
        //https://www.theguardian.com/international
        //https://www.nbcnews.com/
        }
    }
}