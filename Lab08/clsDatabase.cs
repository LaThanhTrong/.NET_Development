using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

class clsDatabase
{
    public static SqlConnection conn;

    public static bool OpenConnection()
    {
        try
        {
            conn = new SqlConnection("Server=Razer; Database=QLSV; uid=admin; pwd=admin");
            conn.Open();
        }
        catch (Exception ex)
        {
            return false;
        }
        return true;
    }

    public static bool CloseConnection()
    {
        try
        {
            conn.Close();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }
}
