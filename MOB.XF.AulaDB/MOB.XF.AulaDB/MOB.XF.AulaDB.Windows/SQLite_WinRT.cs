using MOB.XF.AulaDB.Data;
using Xamarin.Forms;
using Windows.Storage;
using MOB.XF.AulaDB.Windows;
using System.IO;
using SQLite;

[assembly: Dependency(typeof(SQLite_WinRT))]
namespace MOB.XF.AulaDB.Windows
{
    class SQLite_WinRT : ISQLite
    {
        public SQLite_WinRT()
        {

        }

        public SQLiteConnection GetConnection()
        {
            //Caminho + nomeDoArquivo
            var caminhoArquivo = "fiapdb.db3";
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path,caminhoArquivo);

            var conexao = new SQLiteConnection(path);
            return conexao;
        }
    }
}
