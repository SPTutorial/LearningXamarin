using LearningXamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommunityToolkitPage : ContentPage
    {
        public CommunityToolkitPage()
        {
            InitializeComponent();
        }

        private void NavigateCameraViewPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CameraViewPage());
        }
    }
}