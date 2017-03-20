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
    public partial class Aula11Page1 : ContentPage
    {
        public Aula11Page1()
        {
            InitializeComponent();
            this.slider.Value = 0.5;

            ////Aula 11 DataBinding pelo código
            //Label label9 = new Label
            //{
            //    Text = "Macoratti.net",
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    HorizontalOptions = LayoutOptions.Center
            //};

            //Slider slider9 = new Slider
            //{
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};

            ////Define o BindingContext: destino é o Label, origem é o Slider
            //label9.BindingContext = slider9;
            ////Vincula a propriedade: target é Text; source é Value
            //label9.SetBinding(Label.TextProperty, "Value", BindingMode.Default, null, "{0:F2}");
            ////Vincula a propriedade: target é Opacity; source é Value
            //label9.SetBinding(Label.OpacityProperty, "Value");

            //Content = new StackLayout
            //{
            //    Children = { label9, slider9 }
            //};
        }


        //Aula 10 Binding Feito agora pelo DataBinding
        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    this.label.Text = string.Format("Valor = {0:F2}", e.NewValue);
        //}
    }
}
