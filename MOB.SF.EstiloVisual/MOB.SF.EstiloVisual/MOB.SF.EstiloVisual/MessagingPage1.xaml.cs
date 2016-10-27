using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.SF.EstiloVisual
{
    public partial class MessagingPage1 : ContentPage
    {
        public MessagingPage1()
        {
            InitializeComponent();
            AtivarCentroDeMensagens();
        }

        private void AtivarCentroDeMensagens()
        {
            MessagingCenter.Subscribe<MessagingPage1>(this, "voltei", (sender) =>
              {
                  lblBoasVindas.Text = "Continue explorando o app..";
              });
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MessagingPage2());
        }
    }
}
