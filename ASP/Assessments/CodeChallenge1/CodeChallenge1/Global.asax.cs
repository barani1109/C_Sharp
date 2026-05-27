using System;
using System.Web;

namespace CodeChallenge1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["Visitors"] = 0;
            Application["Users"] = 0;
        }

        void Session_Start(object sender, EventArgs e)
        {
            Application["Visitors"] = Convert.ToInt32(Application["Visitors"]) + 1;
            Application["Users"] = Convert.ToInt32(Application["Users"]) + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["Users"] = Convert.ToInt32(Application["Users"]) - 1;
        }
    }
}