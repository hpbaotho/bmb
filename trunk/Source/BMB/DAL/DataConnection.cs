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
    public class DataConnection
    {
        //Return connection
        public SqlConnection connectDatabase()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["BMBConnectionString"].ConnectionString;
                return conn;
            }
            catch(Exception ex)
            {
                return null;   
            }
        }
    }
}
