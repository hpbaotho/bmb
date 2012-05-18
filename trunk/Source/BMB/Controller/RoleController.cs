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
using BMB.DAL;
using BMB.Entity;

namespace BMB.Controller
{
    public class RoleController
    {
        //Select all Roles
        public DataTable selectAllRoles()
        { 
            //Create DataSelection object
            DataSelection dataSelection = new DataSelection();
            return dataSelection.selectData("prcRole_Select");

        }
        // Insert new Role
        public int insertRole(String Name, String Description)
        {
            DataManipulation dm = new DataManipulation();
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            paras[0].Value = Name;

            paras[1] = new SqlParameter("@Des", SqlDbType.VarChar);
            paras[1].Value = Description;

            return dm.manipulateData("prcRole_Insert", paras);
        }
        // Delete existing Role
        public int deleteRole(int RoleID)
        {
            DataManipulation dm = new DataManipulation();
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@RoleID", SqlDbType.Int);
            paras[0].Value = RoleID;

            return dm.manipulateData("prcRole_Delete", paras);
        }

    }
}
