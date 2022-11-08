using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning_dot_net
{
    public partial class LinqToSql : System.Web.UI.Page
    {
        CollegeDbDataContext db = new CollegeDbDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
               
        }
    }
}