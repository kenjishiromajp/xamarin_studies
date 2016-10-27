using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//using System.Runtime.CompilerServices;
using MOB.XF.AulaDB.Data;
using MOB.XF.AulaDB.Droid;
using Xamarin.Forms;
using System.IO;
using SQLite;

[assembly: Dependency(typeof(SQLite_Droid))]
namespace MOB.XF.AulaDB.Droid
{
    public class SQLite_Droid : ISQLite
    {
        public SQLite_Droid()
        {

        }

        public SQLite.SQLiteConnection GetConnection()
        {
            //Caminho + nomeDoArquivo
            var caminhoArquivo = "fiapdb.db3";
            string caminho = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(caminho, caminhoArquivo);

            var conexao = new SQLiteConnection(path);
            return conexao;
        }
    }
}