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
    public partial class Aula27Ex1ScrollViewPage1 : ContentPage
    {
        public Aula27Ex1ScrollViewPage1()
        {
            InitializeComponent();

            var stacklayout = new StackLayout { Spacing = 20 };

            for (int i = 1; i < 26; i++)
            {
                stacklayout.Children.Add(new Button { Text = string.Format("Button {0}", i), BackgroundColor = Color.Yellow });
            }

            var scrollview = new ScrollView { Content = stacklayout };

            this.Content = scrollview;
        }
    }
}
