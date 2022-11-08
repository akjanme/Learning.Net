using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning_dot_net
{
    public partial class LearningEF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CollegeDBEntities entities = new CollegeDBEntities();
            GridView1.DataSource = entities.Students.ToList();
            GridView1.DataBind();
        }
    }
}