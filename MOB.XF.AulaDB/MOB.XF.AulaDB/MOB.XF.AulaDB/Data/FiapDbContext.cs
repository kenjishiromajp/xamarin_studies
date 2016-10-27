using MOB.XF.AulaDB.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MOB.XF.AulaDB.Data
{
    public class FiapDbContext
    {
        private SQLiteConnection database;
        static object bloquear = new object();

        public FiapDbContext()
        {
            //Dependency Injection
            database = DependencyService.Get<ISQLite>().GetConnection();
            //Criar as tabelas
            database.CreateTable<Aluno>();
        }

        #region Aluno
        public int SalvarAluno(Aluno aluno)
        {
            lock (bloquear)
            {
                if (aluno.Id != 0)
                {
                    database.Update(aluno);
                    return aluno.Id;
                }
                return database.Insert(aluno);
            }
        }

        public IEnumerable<Aluno> GetAlunos()
        {
            lock (bloquear)
            {
                //return database.Query<Aluno>("SELECT * FROM aluno");
                return (from a in database.Table<Aluno>() select a).ToList();
            }
        }


        public Aluno GetAluno(int id)
        {
            lock (bloquear)
            {
                //return (from a in database.Table<Aluno>() where a.Id == id select a).SingleOrDefault();
                return database.Table<Aluno>().Where(a => a.Id == id).FirstOrDefault();
            }
        }

        public int DeleteAluno(int id)
        {
            lock (bloquear){ 
                return database.Delete<Aluno>(id);
            }
        }
        #endregion
    }
}
