using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;
using System.Windows.Forms;


public partial class confess : System.Web.UI.Page
{

    Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
    String username ;
    int rate;
    String conf;
    int count;
    //int count1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void topost_Click(object sender, EventArgs e)
    {

        ISession session = cluster.Connect("confession");        
        conf = txtConfessionArea.Text;
        username = txtUserName.Text;
        int max = 1;
        RowSet rows = session.Execute("select * from confess");
        foreach (Row rw in rows.GetRows())
        {
            string temp = rw["id"].ToString();
            if(max<= Int32.Parse(temp))
            {
                max =Int32.Parse(temp);
            }
        }
        count = max;
        session.Execute("insert into confess (id,confesstext,rating,username) values ("+ (++count) +",'" + conf + "',0,'" + username + "')");


        lblReadConfess.Visible = true;
        lblReadConfess.Text = "Your Confession is posted...Go back to home";
        //count1 = count;

        //lblReadConfess.Visible = true;
        //btnLike.Visible = true;

        //lblReadConfess.Text = txtConfessionArea.Text;
    }
    //protected void btnLike_Click(object sender, EventArgs e)
    //{
    //    ISession session = cluster.Connect("confession");
    //    ////rate = rate + 1;


    //    //RowSet rows = session.Execute("select * from confess");
    //    //foreach (Row rw in rows)
    //    //{
    //    //    string vr = rw["id"].ToString();
    //    //    if (Int32.Parse(vr) == count)
    //    //    {
    //    //        String r = rw["rating"].ToString();
    //    //        rate = Int32.Parse(r);
    //    //        rate = rate + 1;
    //    //    }
    //    //}

    //    session.Execute("update confess set rating = 1 where id = " + count1 + ";");
    //}
    //protected void btnDelete_Click(object sender, EventArgs e)
    //{
    //    ISession session = cluster.Connect("confession");

    //    session.Execute("delete from confess id = " + count1 + ";");
    //    lblDelete.Text = "Confession is Deleted...";
    //}
}