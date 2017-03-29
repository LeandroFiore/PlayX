using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayX.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aula30EmbeddedImagesPage1 : ContentPage
    {
        public Aula30EmbeddedImagesPage1()
        {
            InitializeComponent();

            //image.Source = ImageSource.FromResource("PlayX.Images.logo.jpg");
        }
    }
}
