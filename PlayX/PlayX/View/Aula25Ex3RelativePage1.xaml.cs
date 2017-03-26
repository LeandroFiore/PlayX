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
    public partial class Aula25Ex3RelativePage1 : ContentPage
    {
        public Aula25Ex3RelativePage1()
        {
            InitializeComponent();

            var layout = new RelativeLayout();
            layout.BackgroundColor = Color.Yellow;

            var label = new Label { BackgroundColor = Color.White, TextColor = Color.Black, FontSize = 30, Text = "X" };

            layout.Children.Add(label,
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Width / 2) - (label.Width / 2);
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Height / 2) - (label.Height / 2);
                })
            );

            Content = layout;

            //var layout = new RelativeLayout();
            //layout.BackgroundColor = Color.Yellow;
            //var label = new Label
            //{
            //    Text = "X",
            //    BackgroundColor = Color.White,
            //    TextColor = Color.Black,
            //    FontSize = 30
            //};

            //layout.Children.Add(label,
            //        Constraint.RelativeToParent((parent) =>
            //        {
            //            return (parent.Width / 2) - (label.Width / 2);
            //        }),
            //        Constraint.RelativeToParent((parent) =>
            //        {
            //            return (parent.Height / 2) - (label.Height / 2);
            //        })
            //);

            //Content = layout;

        }
    }
}
