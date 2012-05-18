using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BMB.Entity;
using BMB.Controller;

namespace BMB
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1. Test Select Done
                RoleController rc = new RoleController();
                //DataTable dt = rc.selectAllRoles();
                //GridView1.DataSource = dt;
                //GridView1.DataBind();
            //2. Test Insert/Delete/Update
                //Response.Write(rc.insertRole("Patient Role", "For Patient Only!"));
                Response.Write(rc.deleteRole(1));
        }
    }
}
