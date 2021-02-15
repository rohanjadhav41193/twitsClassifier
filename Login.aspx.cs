using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;
using System.Windows.Forms;

public partial class Login : System.Web.UI.Page
{
    bool flag;
    String name1;
    //String username1;
    String usr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();

    }
            
    public void log_Click(object sender, EventArgs e)
    {

        Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();

        usr = usrname.Text;
        String pass = password.Text;
        ISession session = cluster.Connect("confession");
        RowSet rows = session.Execute("select * from signup");
        foreach(Row rw in rows)
        {
            if(rw["username"].ToString()== usr && rw["password"].ToString() == pass)
            {
                name1 = rw["name"].ToString();
                flag = true;
                Console.WriteLine("\n || " + rw["username"]);
            }
        }

        if (flag)
        {
            Session["usrname"] = name1;
            Session["username1"] = usr;
            Response.Redirect("profile.aspx");
            Session.RemoveAll();
        }
        else
                MessageBox.Show("Plese check username or password");


        
    }
    protected void sign_Click(object sender, EventArgs e)
    {
        Response.Redirect("Signup.aspx",false);
    }
}