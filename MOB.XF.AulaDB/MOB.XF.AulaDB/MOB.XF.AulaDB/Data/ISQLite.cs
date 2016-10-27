using SQLite;

namespace MOB.XF.AulaDB.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
