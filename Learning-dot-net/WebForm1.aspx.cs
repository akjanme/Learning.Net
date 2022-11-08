using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning_dot_net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string constring = "server=ANIL;database=CollegeDB;integrated security=true";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetData();
            }
        } 
        private void GetData()
        {
            SqlConnection sqlConnection = new SqlConnection(constring);
            string query = "select * from student";
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, constring);
            sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            GridView1.DataSource = dataSet;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GetData();
        }
    }
}