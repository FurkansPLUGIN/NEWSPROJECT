using NewsProject.carouselInTabbed;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsProject
{
    public partial class App : Application
    {
        public App()
        {
            //CarouselPage cs = new CarouselPage();
            //cs.Children.Add(new Page1());
            //cs.Children.Add(new Page2());
            //cs.Children.Add(new Page3());

            //TabbedPage tb = new TabbedPage();
            //tb.Children.Add(cs);
            //tb.Title = "ONE";
            //tb.Children.Add(new Page1());
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
