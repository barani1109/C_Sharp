using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CodeChallenge1
{
    public partial class AddEditMenu : System.Web.UI.Page
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
                    lblTitle.Text = "Edit Menu Item ✔";
                    LoadMenu();
                }
                else
                {
                    lblTitle.Text = "Add Menu Item ✔";
                }
            }
        }

        private void LoadMenu()
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
                    txtItemName.Text = dr["ItemName"].ToString();
                    txtCategory.Text = dr["Category"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    txtQty.Text = dr["AvailableQuantity"].ToString();

                    rblFoodType.SelectedValue = dr["FoodType"].ToString();
                    chkAvailable.Checked = dr["IsAvailable"].ToString() == "Yes";
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd;

                if (Request.QueryString["MenuId"] == null)
                {
                    cmd = new SqlCommand(@"
                        INSERT INTO MenuItems
                        (ItemName, Category, FoodType, Price, AvailableQuantity, IsAvailable, CreatedDate)
                        VALUES
                        (@name, @cat, @type, @price, @qty, @avail, @date)", con);
                }
                else
                {
                    cmd = new SqlCommand(@"
                        UPDATE MenuItems SET
                        ItemName=@name,
                        Category=@cat,
                        FoodType=@type,
                        Price=@price,
                        AvailableQuantity=@qty,
                        IsAvailable=@avail
                        WHERE MenuId=@id", con);

                    cmd.Parameters.AddWithValue("@id", Request.QueryString["MenuId"]);
                }

                cmd.Parameters.AddWithValue("@name", txtItemName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@type", rblFoodType.SelectedValue);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQty.Text));
                cmd.Parameters.AddWithValue("@avail", chkAvailable.Checked ? "Yes" : "No");

                if (Request.QueryString["MenuId"] == null)
                {
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                }

                cmd.ExecuteNonQuery();
            }

            Response.Redirect("MenuList.aspx");
        }
    }
}