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
    public partial class Aula29ActivityIndicatorPage1 : ContentPage
    {
        public Aula29ActivityIndicatorPage1()
        {
            InitializeComponent();

            image.Source = new UriImageSource
            {
                Uri = new Uri("http://www.macoratti.net/imagens/animais/tigre.jpg"),
                CachingEnabled = false
            };

            ////Binding por código
            //var indicator = new ActivityIndicator { Color = Color.Black };
            //indicator.SetBinding(ActivityIndicator.IsRunningProperty, "IsLoading");
            //indicator.BindingContext = image;
        }
    }
}
