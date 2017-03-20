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
    public partial class Aula13Ex1Page1 : ContentPage
    {
        public Aula13Ex1Page1()
        {
            InitializeComponent();
        }

        int contador = 1;
        private void btnClicar_Clicked(object sender, EventArgs e)
        {
            this.btnClicar.Text = string.Format("{0} Cliques!", contador++);
        }
    }
}
