using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CodeChallenge1
{
    public partial class MenuDetails : System.Web.UI.Page
    {
        string conStr =
            ConfigurationManager.ConnectionStrings["FoodDBConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                if (Request.QueryString["MenuId"] != null)
                {
                    LoadDetails();
                }
            }
        }

        private void LoadDetails()
        {
            int id = Convert.ToInt32(Request.QueryString["MenuId"]);

            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM MenuItems WHERE MenuId=@id", con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblItemName.Text = "Item Name: " + dr["ItemName"].ToString();
                    lblCategory.Text = "Category: " + dr["Category"].ToString();
                    lblPrice.Text = "Price: " + dr["Price"].ToString();
                }
                else
                {
                    lblItemName.Text = "Item not found!";
                }

                con.Close();
            }
        }
    }
}