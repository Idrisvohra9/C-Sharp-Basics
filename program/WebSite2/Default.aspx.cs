using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        connect obj = new connect();
        string str = "insert into User_demo values('" + txtid.Text + "','" + txtname.Text + "')";
        obj.execute(str);
        Label3.Text = "sucess";
    }
}
