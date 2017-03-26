using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PlayX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new PlayX.MainPage();

            MainPage = new PlayX.View.Aula22Ex3AbsolutePage1();
            //MainPage = new PlayX.View.Aula22Ex2AbsolutePage1();
            //MainPage = new PlayX.View.Aula22Ex1AbsolutePage1();
            //MainPage = new PlayX.View.Aula21AbsolutePage1();
            //MainPage = new PlayX.View.Aula20AbsolutePage1();
            //MainPage = new PlayX.View.Aula19Ex2GridPage1();
            //MainPage = new PlayX.View.Aula19Ex1GridPage1();
            //MainPage = new PlayX.View.Aula18GridPage1();
            //MainPage = new PlayX.View.Aula17GridPage1();
            //MainPage = new PlayX.View.Aula16Ex4StackPage1();
            //MainPage = new PlayX.View.Aula16Ex3StackPage1();
            //MainPage = new PlayX.View.Aula16Ex2StackPage1();
            //MainPage = new PlayX.View.Aula16Ex1StackPage1();

            //MainPage = new PlayX.View.Aula15StackLayoutPage1();
            //MainPage = new PlayX.View.Aula14StackLayoutPage1();
            //MainPage = new PlayX.View.Aula13Ex3Page1();
            //MainPage = new PlayX.View.Aula13Ex2Page1();
            //MainPage = new PlayX.View.Aula13Ex1Page1();
            //MainPage = new PlayX.View.Aula12Page1();
            //MainPage = new PlayX.View.Aula11Page1();
            //MainPage = new PlayX.View.Aula10Page1();
            //MainPage = new PlayX.View.Aula09Page1();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
