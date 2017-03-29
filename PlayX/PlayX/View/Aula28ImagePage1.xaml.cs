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
    public partial class Aula28ImagePage1 : ContentPage
    {
        public Aula28ImagePage1()
        {
            InitializeComponent();

            //var image = new Image();
            //image.Aspect = Aspect.AspectFill;
            //image.Source = "http://www.macoratti.net/imagens/animais/cao1.jpg";
            //Content = image;


            //var image = new Image();
            //image.Aspect = Aspect.AspectFill;
            //image.Source = new UriImageSource
            //{
            //    Uri = new Uri("http://www.macoratti.net/imagens/animais/cao2.jpg"),
            //    CachingEnabled = false,
            //    CacheValidity=new System.TimeSpan(1,0,0,0)
            //};
            //Content = image;


            //var image = new Image();
            //image.Aspect = Aspect.AspectFit;
            //image.Source = ImageSource.FromUri(new Uri("http://www.macoratti.net/imagens/animais/cao2.jpg"));
            //Content = image;
        }
    }
}
