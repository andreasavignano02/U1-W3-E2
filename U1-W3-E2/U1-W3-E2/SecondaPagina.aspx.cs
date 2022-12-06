using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_E2
{
    public partial class SecondaPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies[Request.Cookies.Count ] == null) 
            {
                Response.Redirect("Main.aspx");

            }else if (Request.Cookies["DatiUtente"]!= null) 
            {
                UserText.Text = Request.Cookies["DatiUtente"]["Username"];
            }
        }

        protected void DeleteCookie_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("DatiUtente");
            c.Expires = DateTime.Now.AddDays(-1); //DateTime.Now
            Response.Cookies.Add(c);
            Response.Redirect("Main.aspx");
        }
    }
}