using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyClient
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyServiceClient client = new CompanyService.CompanyServiceClient("BasicHttpBinding_ICompanyService");
            Label1.Text = client.GetData();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}