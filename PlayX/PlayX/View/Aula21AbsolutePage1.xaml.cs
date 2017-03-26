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
    public partial class Aula21AbsolutePage1 : ContentPage
    {
        public Aula21AbsolutePage1()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();

            var box1 = new BoxView { Color = Color.Purple };
            var box2 = new BoxView { Color = Color.Yellow };

            //Todos valores proporcionais
            layout.Children.Add(box1, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);

            //X e Y proporcional e os demais absolutos
            layout.Children.Add(box2, new Rectangle(0.5, 0.1, 100, 100), AbsoluteLayoutFlags.PositionProportional);


            var button1 = new Button
            {
                Text = "Macoratti.net",
                BackgroundColor = Color.Lime,
                TextColor = Color.Black,
            };
            AbsoluteLayout.SetLayoutBounds(button1, new Rectangle(0, 1, 1, 40));
            AbsoluteLayout.SetLayoutFlags(button1, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            //X , Y e Width proporcional Height absoluto
            layout.Children.Add(button1);

            Content = layout;
        }
    }
}
