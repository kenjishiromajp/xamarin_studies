using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MOB_XF_Hello
{
    public class MainPage : ContentPage
    {
        private Label labelTexto;
        private Button buttonClick;

        public MainPage()
        { 

            labelTexto = new Label()
            {
                Text = "Hello louco!"
            };

            buttonClick = new Button()
            {
                Text = "Clique Aqui"
            };

            buttonClick.Clicked += ButtonClick_Clicked;

            Content = new StackLayout
            {
                Children = {
                    labelTexto,
                    buttonClick
                }
            };
            Padding = new Thickness(20, 40, 20, 20);
            switch (Device.OS)
            {
                case TargetPlatform.Other:
                    break;
                case TargetPlatform.iOS:
                    break;
                case TargetPlatform.Android:
                    break;
                case TargetPlatform.WinPhone:
                    break;
                case TargetPlatform.Windows:
                    break;
                default:
                    break;
            }

            Device.OnPlatform(Android: () => { Padding = new Thickness(20, 40, 20, 20); });

            //Padding = Device.OnPlatform(
            //    new Thickness(20, 40, 20, 20),
            //    new Thickness(20, 40, 20, 20),
            //    new Thickness(20, 40, 20, 20)
            //);
        }

        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            labelTexto.Text = "Para com essa Zika!";
            //throw new NotImplementedException();
        }
    }
}
