using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class ProductDemo : System.Web.UI.Page
    {
        string conStr =
            ConfigurationManager.ConnectionStrings["EmployeeDBConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
                ddlProducts.Items.Insert(0, new ListItem("--Select Product--", ""));
            }
        }

        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT ProductId, ProductName FROM Products", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                ddlProducts.DataSource = dr;
                ddlProducts.DataTextField = "ProductName";
                ddlProducts.DataValueField = "ProductId";
                ddlProducts.DataBind();
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedValue == "")
            {
                imgProduct.ImageUrl = "";
                lblPrice.Text = "";
                return;
            }

            int productId = Convert.ToInt32(ddlProducts.SelectedValue);

            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT ImagePath FROM Products WHERE ProductId=@ProductId", con);

                cmd.Parameters.AddWithValue("@ProductId", productId);

                con.Open();
                string imgPath = cmd.ExecuteScalar()?.ToString();
                con.Close();

                imgProduct.ImageUrl = imgPath;
                lblPrice.Text = "";
            }
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedValue == "")
            {
                lblPrice.Text = "Please select a product.";
                return;
            }

            int productId = Convert.ToInt32(ddlProducts.SelectedValue);

            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Price FROM Products WHERE ProductId=@ProductId", con);

                cmd.Parameters.AddWithValue("@ProductId", productId);

                con.Open();
                object price = cmd.ExecuteScalar();
                con.Close();

                lblPrice.Text = "Price : Rs. " + price;
            }
        }
    }
}