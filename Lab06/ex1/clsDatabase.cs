﻿using System.Data;
using System.Data.SqlClient;

class clsDatabase
{
    public static SqlConnection conn;

    public static bool OpenConnection()
    {
        try
        {
            conn = new SqlConnection("Server=DESKTOP-HGASCBA; Database=DVDLibrary; uid=mylogin; pwd=mylogin");
            conn.Open();
        } catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
        return true;
    }

    public static bool CloseConnection()
    {
        try
        {
            conn.Close();
        } catch (Exception)
        {
            return false;
        }
        return true;
    }
}
