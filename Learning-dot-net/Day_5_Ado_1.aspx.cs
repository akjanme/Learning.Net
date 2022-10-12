using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;

namespace Learning_dot_net
{
    public partial class Day_5_Ado_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetData();
            }
        }
        private void GetData()
        { 
            string constring = "server=ANIL;database=CollegeDB;integrated security=true";
            //string constring = "data source=ANIL;initial catalog=CollegeDB;integrated security=true";
            //string constring = "data source=ANIL;initial catalog=CollegeDB;user id=test;password=test@123";
            //SqlConnection sqlConnection = new SqlConnection("server=ANIL;database=CollegeDB;integrated security=true");

            SqlConnection sqlConnection = new SqlConnection(constring);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Student", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("<table class='table'>");
            //while(sqlDataReader.Read())
            //{
            //    stringBuilder.Append("<tr><td>" + sqlDataReader["Name"] + "</td><td>" + sqlDataReader["FatherName"] + "</td></tr>");
            //}
            //stringBuilder.Append("</table>");
            //sqlConnection.Close(); 
            //studentData.InnerHtml = stringBuilder.ToString();

            GridView1.DataSource = sqlDataReader;
            GridView1.DataBind();

        }
    }
}