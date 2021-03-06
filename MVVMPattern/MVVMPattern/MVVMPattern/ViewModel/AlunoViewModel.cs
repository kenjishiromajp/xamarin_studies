﻿using MVVMPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.ViewModel
{
    class AlunoViewModel
    {
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion
        public AlunoViewModel(Aluno aluno)
        {
            this.RM = aluno.RM;
            this.Nome = aluno.Nome;
            this.Email = aluno.Email;
        }

        public static Aluno GetAluno()
        {
            var aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "542621",
                Nome = "Anderson Silva",
                Email = "anderson@ufc.com"
            };
            return aluno;
        }

        public AlunoViewModel()
        {
            
        }
        public List<Aluno> Alunos
        {
            get
            {
                return new List<Aluno>()
                {
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" },
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" },
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" },
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" },
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" },
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" },
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" },
                    new Aluno() {Id= Guid.NewGuid(),Nome="João",RM="1246",Email="joao@joao.com.br" }
                };
            }
        }


    }
}
