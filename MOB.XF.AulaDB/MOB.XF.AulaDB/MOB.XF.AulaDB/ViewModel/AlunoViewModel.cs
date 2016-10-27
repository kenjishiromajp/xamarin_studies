using MOB.XF.AulaDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.AulaDB.ViewModel
{
    public class AlunoViewModel
    {
        public string Nome { get; set; }
        public string RM { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public bool Aprovado { get; set; }

        //public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public List<Aluno> Alunos
        {
            get
            {
                return App.Database.GetAlunos().ToList();
            }
            set
            {

            }
        }
    }
}
