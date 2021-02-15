using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Cassandra;
using Cassandra.Data.Linq;
using System.Windows.Forms.Design;
using System.Windows;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class userlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();

        string username4 = Session["username1"].ToString();

        ISession session = cluster.Connect("confession");
        RowSet rows = session.Execute("select * from confess where username = '"+ username4 + "';");

        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Confessions"), new DataColumn("Re-Tweet"), new DataColumn("User") });
        foreach (var te in rows.GetRows())
        {
            string temp = te.GetValue<string>("confesstext");

            string[] strArray = temp.Split(' ');
            foreach(string str in strArray)
            {
                if (str == "RT")
                {
                    dt.Rows.Add(te.GetValue<string>("confesstext"), te.GetValue<int>("rating"), te.GetValue<string>("username"));

                }
            }
        }
        gvReTweets.DataSource = dt;
        gvReTweets.DataBind();
    }
}