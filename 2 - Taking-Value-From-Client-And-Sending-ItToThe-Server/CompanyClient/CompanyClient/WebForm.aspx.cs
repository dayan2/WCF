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

        protected void Button1_Click(object sender, EventArgs e)
        {
            CompanyService.Service1Client client = new CompanyService.Service1Client("BasicHttpBinding_IService1");
            string str = TextBox1.Text;
            Label1.Text = client.GetData(str);
        }
    }
}