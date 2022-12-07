using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_E2
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
          
        HttpCookie c = new HttpCookie("DatiUtente");
            c.Values["Username"] = User.Text;
            c.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(c);
            Response.Redirect("SecondaPagina.aspx");
        }

        
    }
}