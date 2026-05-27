using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace CodeChallenge1
{
    public partial class MenuList : System.Web.UI.Page
    {
        string conStr =
            ConfigurationManager.ConnectionStrings["FoodDBConnection"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadMenu();
            }
        }

        private void LoadMenu()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT * FROM MenuItems", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gvMenu.DataSource = dt;
            gvMenu.DataBind();
        }

        protected void gvMenu_RowDeleting(object sender,
            System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id =
                Convert.ToInt32(gvMenu.DataKeys[e.RowIndex].Value);

            SqlConnection con =
                new SqlConnection(conStr);

            SqlCommand cmd =
                new SqlCommand(
                    "DELETE FROM MenuItems WHERE MenuId=@id", con);

            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadMenu();
        }
    }
}