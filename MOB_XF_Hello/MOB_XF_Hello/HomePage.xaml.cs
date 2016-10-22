using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB_XF_Hello
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void NomeAluno_TextChanged(object sender, TextChangedEventArgs e)
        {
            mensagemStatus.Text = string.Empty;
            //throw new NotImplementedException();
        }

        private void OnButton_Cadastrar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.nomeAluno.Text))
            {
                this.mensagemStatus.Text = "Informe o Texto!";
            }
            else
            {
                this.mensagemStatus.Text = nomeAluno.Text + "Aeeee";
                this.nomeAluno.Text = "";
            }
        }
    }
}
