using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace lab9_again
{
    class clsDatabase
    {
        public static SqlConnection con;
        public static bool openConnection()
        {
            try
            {
                con = new SqlConnection("Server=Razer; Database=lab9; uid=mylogin; pwd=mylogin");
                con.Open();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static bool closeConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}