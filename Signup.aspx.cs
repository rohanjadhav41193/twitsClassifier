using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;
using System.Windows.Forms;
public partial class Signup : System.Web.UI.Page
{

    int flag = 0;
    Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void log_Click(object sender, EventArgs e)
    {

        //try
        //{
            var name1 = name.Text;
            var email1 = email.Text;
            var username1 = username.Text;
            var password1 = password.Text;

            ISession session = cluster.Connect("confession");
            
            
            RowSet rows = session.Execute("select * from signup");
            foreach (Row rw in rows.GetRows())
            {
                if(rw["username"].ToString()== username1)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }

            if (flag == 1)
            {
                MessageBox.Show("This username is already Exist....");
            }
            else if (flag == 0)
            {
                session.Execute("insert into signup (name,email,username,password) values ('" + name1 + "', '" + email1 + "','" + username1 + "','" + password1 + "')");
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

            //int result = String.Compare(username.ToString(),username1.ToString());

            //if(result == 1)
            //{
            //    Response.Write("<script type=\"text/javascript\">alert('Username is already exist..... Sorry enter another UserName');</script>");
            //}

            //Response.Redirect("Login.aspx", false);
        //}
        //catch(Exception t)
        //{
        //    //Alert("Username is already exist..... Sorry enter another UserName");
        //    Response.Write("<script type=\"text/javascript\">alert('Username is already exist..... Sorry enter another UserName');</script>");
        //}
    }

    
}