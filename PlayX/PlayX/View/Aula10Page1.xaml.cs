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
    public partial class Aula10Page1 : ContentPage
    {
        public Aula10Page1()
        {
            InitializeComponent();

            //Content = new Label
            //{
            //    Text = "Xamarin Forms CSharp",
            //    VerticalOptions = LayoutOptions.Center,
            //    HorizontalOptions = LayoutOptions.Center,
            //};

            this.slider.Value = 0.5;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.label.Text = string.Format("Valor = {0:F2}", e.NewValue);
        }
    }
}
