using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearningXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void XamarinEssentials(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XamarinEssentialsPage());
        }
        private void XamarinCommunityToolkits(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CommunityToolkitPage());
        }
    }
}
