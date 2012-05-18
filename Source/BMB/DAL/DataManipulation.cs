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
    public class DataManipulation
    {
        SqlConnection conn;
        SqlTransaction trans;
        public int manipulateData(String procedureName, SqlParameter[] paras)
        {
            try
            {
                //Get connection object
                conn = (new DataConnection()).connectDatabase();
                conn.Open();
                //trans = conn.BeginTransaction();
                //Retrieve data
                //--1. Create SqlCommand object
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedureName;
                cmd.Connection = conn;
                //--2. Add parameters to SelectCommand of Adapter
                cmd.Parameters.AddRange(paras);
                // Execute command011002310
                int rowEffected = cmd.ExecuteNonQuery();
                //trans.Commit();
                return rowEffected;

            }
            catch (Exception ex)
            {
                //trans.Rollback();
                return -1;
            }
            finally {
                conn.Close();
            }
            
        }
    }
}
