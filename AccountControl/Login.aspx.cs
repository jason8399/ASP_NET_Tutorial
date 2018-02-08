using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountControl
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            TextBox UserId = form1.FindControl("UserId") as TextBox;
            TextBox UserPwd = form1.FindControl("UserPwd") as TextBox;
            UserId.Text = UserPwd.Text;
            UserId.DataBind();
        }
    }
}