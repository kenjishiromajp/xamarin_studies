using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.SF.EstiloVisual
{
    public partial class EstiloDinamico : ContentPage
    {
        bool temaPadrao;

        public EstiloDinamico()
        {
            InitializeComponent();
            temaPadrao = true;
            Resources["estiloDinamico"] = Resources["TextoAzul"];
        }

        private void OnClicked_AlterarEstilo(object sender, EventArgs e)
        {
            Resources["estiloDinamico"] = (temaPadrao) ? Resources["TextoAzul"] : Resources["TextoBranco"];
            temaPadrao = !temaPadrao;
        }

        private bool desligaRelogio = false;
        protected override void OnAppearing()
        {
            desligaRelogio = false;
            Device.StartTimer(TimeSpan.FromSeconds(1),() =>
            {
                Resources["hora"] = DateTime.Now.ToString();
                return !desligaRelogio;
            });
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            desligaRelogio = true;
            base.OnDisappearing();
        }
    }
}
