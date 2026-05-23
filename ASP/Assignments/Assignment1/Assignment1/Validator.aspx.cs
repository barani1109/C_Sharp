using System;
using System.Web.UI;

namespace Assignment1
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Write(
                    "<script>alert('Validation Successful');</script>");
            }
        }
    }
}