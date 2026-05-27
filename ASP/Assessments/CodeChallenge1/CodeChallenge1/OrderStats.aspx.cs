using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CodeChallenge1
{
    public partial class OrderStats : System.Web.UI.Page
    {
        string cs =
            ConfigurationManager.ConnectionStrings["FoodDBConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitors.Text = "Total Visitors : " + Application["Visitors"];
            lblUsers.Text = "Current Active Users : " + Application["Users"];
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCategoryStats();
        }

        private void LoadCategoryStats()
        {
            DataTable dt;

            if (Cache["FoodCategoryStats"] != null)
            {
                dt = (DataTable)Cache["FoodCategoryStats"];

                lblCacheMessage.Text = "Loaded from CACHE ";
                lblCacheMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                dt = GetDataFromDB();

                Cache.Insert(
                    "FoodCategoryStats",
                    dt,
                    null,
                    DateTime.Now.AddMinutes(5),
                    System.Web.Caching.Cache.NoSlidingExpiration
                );

                lblCacheMessage.Text = "Loaded from DATABASE  (Stored in Cache)";
                lblCacheMessage.ForeColor = System.Drawing.Color.Blue;
            }

            gvCategory.DataSource = dt;
            gvCategory.DataBind();
        }

        private DataTable GetDataFromDB()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query =
                    "SELECT Category, COUNT(*) AS TotalItems FROM MenuItems GROUP BY Category";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}