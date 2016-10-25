using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using MOB_XF_Hello.Views;

namespace MOB_XF_Hello
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new AlunoView();


            //Ativando o recurso de navegação
            MainPage = new NavigationPage(new TabbedNavView());
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
