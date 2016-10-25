using MVVMPattern.Model;
using MVVMPattern.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVVMPattern.View
{
    public partial class AlunoViewPage : ContentPage
    {
        AlunoViewModel vmAluno;

        public AlunoViewPage()
        {
            //Aluno aluno = AlunoViewModel.GetAluno();
            //vmAluno = new AlunoViewModel(aluno);
            //BindingContext = vmAluno;

            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;

            
            InitializeComponent();
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            var alunoSelecionado = args.Item as Aluno;
            DisplayAlert("Aluno Selecionado",string.Format("ID do Auno :{0}", alunoSelecionado.Id),"OK");
        }
    }
}
