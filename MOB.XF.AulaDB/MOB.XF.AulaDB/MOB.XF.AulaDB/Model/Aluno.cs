using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.AulaDB.Model
{
    //[Table("Aluno")]
    public class Aluno
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        //[Column("Name")]
        public string Nome { get; set; }
        public string RM { get; set; }
        public string Email { get; set; }
        //[Ignore]
        public string Profissao { get; set; }
        public bool Aprovado { get; set; }
    }
}
