using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB_XF_Hello.Views
{
    public partial class NavPage2 : ContentPage
    {
        public NavPage2()
        {
            //Content = new Label() { Text = "Kenji" };

            //Content = new StackLayout()
            //{
            //    Children = {
            //        new Label() { Text = "Kenji" }
            //    }
            //};

            InitializeComponent();
            Button button = new Button() { Text = "Voltar" };
            this.container.Children.Add(
                button
            );
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PopAsync();
            };
        }

    }
}
