using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.SF.EstiloVisual
{
    public partial class MessagingPage2 : ContentPage
    {
        public MessagingPage2()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            var pagina1 = new MessagingPage1();
            MessagingCenter.Send<MessagingPage1>(pagina1, "voltei");
            Navigation.PopAsync();
        }
    }
}
