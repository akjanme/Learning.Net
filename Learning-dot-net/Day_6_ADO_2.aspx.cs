using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning_dot_net
{
    public partial class Day_6_ADO_2 : System.Web.UI.Page
    {
        string constring = "server=ANIL;database=SchoolDB;integrated security=true";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetData();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(constring);
            string query = "insert into student (name,fathername,mobile,dateofbirth) values ('" + txtName.Text + "','" + txtFatherName.Text + "','" + txtMobile.Text + "','" + txtDateOfBirth.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int cmd = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            lblMessage.Text = "Data Saved Successfully!";
            ResetValues();
            GetData();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        private void ResetValues()
        {
            txtName.Text = string.Empty;
            txtMobile.Text = "";
            txtDateOfBirth.Text = string.Empty;
            txtFatherName.Text = string.Empty;
        }
        private void GetData()
        {
            SqlConnection sqlConnection = new SqlConnection(constring);
            string query = "select * from student";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            GridView1.DataSource = sqlDataReader;
            GridView1.DataBind();
        }
         

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}