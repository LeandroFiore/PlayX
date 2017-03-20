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
    public partial class Aula15StackLayoutPage1 : ContentPage
    {
        public Aula15StackLayoutPage1()
        {
            InitializeComponent();

            ////exemplo 1
            //var layout = new StackLayout
            //{
            //    BackgroundColor = Color.Yellow,
            //    Spacing = 20,
            //    Padding = new Thickness(0, 20, 0, 0),
            //    Orientation = StackOrientation.Vertical
            //};

            //layout.Children.Add(new Label { Text = "Label 1", BackgroundColor = Color.Aqua });
            //layout.Children.Add(new Button { Text = "Button 1", BackgroundColor = Color.Aqua });

            //this.Content = layout;


            //exemplo 2
            StackLayout stackLayout = new StackLayout
            {
                BackgroundColor = Color.Yellow,
                Spacing = 20,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        Text="Xamarin Forms",
                        BackgroundColor=Color.Silver,
                        HorizontalOptions=  LayoutOptions.Start
                    },
                    new Label
                    {
                        Text="Macoratti.net",
                        BackgroundColor=Color.Silver,
                        HorizontalOptions=  LayoutOptions.Center
                    },
                    new StackLayout
                    {
                        BackgroundColor=Color.Silver,
                        Spacing = 10,
                        Padding = new Thickness(30),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,
                        Children =
                        {
                            new Label
                            {
                                Text="Label 1",
                                BackgroundColor=Color.Silver,
                            },
                        }
                    }
                },

            };

            Content = stackLayout;

        }
    }
}
