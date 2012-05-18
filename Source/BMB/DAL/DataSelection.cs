using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace BMB.DAL
{
    public class DataSelection
    {
        SqlConnection conn;
        SqlTransaction trans ;
        // Select none parameters
        public DataTable selectData(String procedureName)
        {
            try
            {
                //Get connection object
                conn = (new DataConnection()).connectDatabase();
                //trans =conn.BeginTransaction(); //Begin transaction
                //Retrieve data
                //--1. Create adapter object
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = procedureName;
                da.SelectCommand.Connection = conn;
                
                //Create DataSet object
                DataSet ds = new DataSet();
                //Fill data
                da.Fill(ds);
                //Commit Transaction
                //trans.Commit();
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                //trans.Rollback();
                return null;

            }
            finally
            {
                conn.Close();
            }

        }
        // Select with Parameters
        public DataTable selectDataWithParams(String procedureName, SqlParameter[] paras)
        {
            try
            {
                //Get connection object
                conn = (new DataConnection()).connectDatabase();
                //trans =conn.BeginTransaction(); //Begin transaction
                //Retrieve data
                //--1. Create adapter object
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = procedureName;
                da.SelectCommand.Connection = conn;
                //--2. Add parameters to SelectCommand of Adapter
                da.SelectCommand.Parameters.AddRange(paras);
                //Create DataSet object
                DataSet ds = new DataSet();
                //Fill data
                da.Fill(ds);
                //Commit Transaction
                //trans.Commit();
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                //trans.Rollback();
                return null;

            }
            finally {
                conn.Close();
            }
            
        }

    }
}
