using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolWeb
{
    public partial class Registration : System.Web.UI.Page
    {
        string constring = "server=ANIL-PC;database=SchoolDB;integrated security=true";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetData();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(constring); 
                SqlCommand sqlCommand = new SqlCommand("sp_InsertStudentData", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@fathername", txtFatherName.Text);
                sqlCommand.Parameters.AddWithValue("@mothername", txtMotherName.Text);
                sqlCommand.Parameters.AddWithValue("@phone", txtPhone.Text);
                sqlCommand.Parameters.AddWithValue("@gender", rdoGender.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@address", rdoGender.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@imagepath", fileImage.FileName); 
                sqlConnection.Open();
                int cmd = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (cmd == 1)
                {
                    lblMessage.Text = "Data Saved Successfully!";
                    String filePath = "~/StudentImages/" +     fileImage.FileName;
                    fileImage.SaveAs(MapPath(filePath));
                }
                else
                {
                    lblMessage.Text = "No Data Saved!";
                    lblMessage.ForeColor = Color.Red;
                }

                GetData();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                lblAddress.ForeColor = Color.Red;
            }
        }
        private void GetData()
        {
            SqlConnection sqlConnection = new SqlConnection(constring); 
            SqlCommand sqlCommand = new SqlCommand("sp_GetStudentData", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            GridView1.DataSource = sqlDataReader;
            GridView1.DataBind();
        }
    }
}