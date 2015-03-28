using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

class ADOSql
{
    SqlConnection conn;
    SqlDataReader dr;

    public SqlConnection connect()
    {
        conn = new SqlConnection();
        conn.ConnectionString = @"server=.\sqlexpress;database=TSQLFundamentals2008;integrated security=true";
        conn.Open();

        return conn;
    }
    public SqlConnection connect(string connectString)
    {
        conn = new SqlConnection();
        conn.ConnectionString = connectString;
        conn.Open();

        return conn;
    }

    public int executeNonQuery(string sql)
    {
        dr = null;
        if (sql != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            int ret = cmd.ExecuteNonQuery();

            this.closeDataReader();
            
            return ret;
        }
        return 0;
    }

    public SqlDataReader executeQuery(string sql)
    {
        dr = null;
        if (sql != null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            dr = cmd.ExecuteReader();
        }

        return dr;
    }

    public SqlDataReader result()
    {
        return this.dr;
    }

    public void closeDataReader()
    {
        if (dr != null)
            dr.Close();
    }

    public void closeConnection()
    {
        if (conn !=null)
            conn.Close();
    }

    public void close()
    {
        this.closeDataReader();
        this.closeConnection();
    }
}
