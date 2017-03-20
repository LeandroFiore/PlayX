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
    public partial class Aula12Page1 : ContentPage
    {
        public Aula12Page1()
        {
            InitializeComponent();

            ////Padding 20 unidades (topo) em todas as plataformas
            //this.Padding = new Thickness(0, 20, 0, 0);

            ////Padding 20 unidades (topo) no IOS especifico de plataforma
            //if (Device.OS == TargetPlatform.iOS)
            //    this.Padding = new Thickness(0, 20, 0, 0);

            ////outra opção
            //this.Padding = Device.OnPlatform<Thickness>(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(0),
            //    WinPhone: new Thickness(0)
            //    );

            ////outra opção de OnPlatform
            //Device.OnPlatform(
            //    iOS: () =>
            //    {
            //        Padding = new Thickness(0, 20, 0, 0);
            //    },
            //    Android: () =>
            //    {
            //        Padding = new Thickness(0, 0, 0, 0);
            //    },
            //    WinPhone: () =>
            //    {
            //        Padding = new Thickness(0, 0, 0, 0);
            //    }
            //    );

            //Exemplo Device.Idiom
            switch (Device.Idiom)
            {
                case TargetIdiom.Phone:
                    this.lblIdiom.Text += " Phone";
                    break;
                case TargetIdiom.Tablet:
                    this.lblIdiom.Text += " Tablet";
                    break;
                case TargetIdiom.Desktop:
                    this.lblIdiom.Text += " Desktop";
                    break;
                case TargetIdiom.Unsupported:
                    this.lblIdiom.Text += " Desconhecido";
                    break;
            }
        }
    }
}
