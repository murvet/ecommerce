using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteExample
{
    public class dbClass : IDisposable
    {
        public SqlConnection cnn;

        public dbClass()
        {
            cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["WebsiteDB"].ConnectionString);
        }

        public bool SQLExecute(string SQLSorgu)
        {
            cnn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(SQLSorgu, cnn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch { return false; }
                }
            }
            finally
            {
                cnn.Close();
            }
        }

        public object SQLExecuteScalar(string SQLSorgu)
        {
            cnn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(SQLSorgu, cnn))
                {
                    try
                    {
                        return cmd.ExecuteScalar();
                    }
                    catch { return null; }
                }
            }
            finally
            {
                cnn.Close();
            }
        }

        public DataTable LoadDataTable(string SQLSorgu)
        {
            DataTable dtTemp = new DataTable("TDataTable");
            cnn.Open();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(SQLSorgu, cnn))
                {
                    try
                    {
                        da.Fill(dtTemp);
                    }
                    catch { return null; }
                }
            }
            finally
            {
                cnn.Close();
            }
            return dtTemp;
        }

        public DataSet LoadDataSet(string SQLSorgu)
        {
            DataSet dtTemp = new DataSet("TDataSet");
            cnn.Open();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(SQLSorgu, cnn))
                {
                    try
                    {
                        da.Fill(dtTemp);
                    }
                    catch { return null; }
                }
            }
            finally
            {
                cnn.Close();
            }
            return dtTemp;
        }

        public void Dispose()
        {
            if (cnn.State != ConnectionState.Closed) cnn.Close();
            cnn.Dispose();
            cnn = null;
            GC.SuppressFinalize(this);
        }
    }
}