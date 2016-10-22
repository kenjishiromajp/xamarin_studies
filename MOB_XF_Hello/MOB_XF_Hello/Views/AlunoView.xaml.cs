using MOB_XF_Hello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB_XF_Hello.Views
{
    public partial class AlunoView : ContentPage
    {
        public AlunoView()
        {
            Aluno aluno = GetAluno("Kenji", "40545786", "kenjishiroajp@gmail.com");
            BindingContext = aluno;

            InitializeComponent();
        }

        /*
         * <summary>
         *  Recupera o usuário por meio de um web service
         * </summary>
         * <param name="nome">Informar o nome do aluno</param>
         * <param name="rm">Informar o rm do aluno</param>
         * <param name="email">Informar o nome do email</param>
         */
        private Aluno GetAluno(string nome, string rm, string email)
        {
            return new Aluno() {
                Nome = nome,
                RM = rm,
                Email = email
            };
        }
    }
}
