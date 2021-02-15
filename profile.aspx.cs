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
public partial class profile : System.Web.UI.Page
{

    Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
    string username="";
    int rate;
    string username1;
    protected void Page_Load(object sender, EventArgs e)
    {


        showdata();

        Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();

        ISession session = cluster.Connect("confession");
        RowSet rows = session.Execute("select * from signup");

        DataTable dt1 = new DataTable();
        dt1.Columns.AddRange(new DataColumn[1] { new DataColumn(" ") });
        foreach (var te in rows.GetRows())
        {
            dt1.Rows.Add(te.GetValue<string>("name"));
        }
        gvUserList.DataSource = dt1;
        gvUserList.DataBind();

        username1 = Session["username1"].ToString();


    }
    protected void showdata()
    {
        ISession session = cluster.Connect("confession");
        usrName.Text = Session["usrname"].ToString();
        RowSet rows = session.Execute("select * from confess");

        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Confessions"), new DataColumn("Likes"), new DataColumn("User") });
        foreach (var te in rows.GetRows())
        {
            dt.Rows.Add(te.GetValue<string>("confesstext"), te.GetValue<int>("rating"), te.GetValue<string>("username"));
        }
        gvConfess.DataSource = dt;
        gvConfess.DataBind();
    }
    protected void btnHome_Click(object sender, EventArgs e)
    {
        editPanel.Visible = false;
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        editPanel.Visible = true;
    }
    protected void btnDone_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        string email = txtEmail.Text;
        string username = txtUserName.Text;
        string password = txtPassword.Text;


        ISession session = cluster.Connect("confession");
        session.Execute("update signup set name='" + name + "',email='" + email +"',password ='"+password+ "' where username='" + username+"';");
      //  MessageBox.Show("Updation Successful...");

    }
    protected void btnCancle_Click(object sender, EventArgs e)
    {
        editPanel.Visible = false;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*
        ISession session = cluster.Connect("confession");
        //rate = rate + 1;
       
        string confessname1 = GridView1.SelectedRow.Cells[1].ToString();
        string rate1 = GridView1.SelectedRow.Cells[2].ToString();
        int r = Int32.Parse(rate1);
        r++;
        

        session.Execute("update confess set rating =" + r + " where confessname = '" + confessname1 + "';");*/

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvConfess.EditIndex = e.NewEditIndex;
        showdata();
    }
    protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
    {
        //Label eno = (Label)GridView1.Rows[GridView1.SelectedIndex].Cells[0];
        //int s1=GridView1.Rows[GridView1.SelectedIndex].ToString();
        ///string s1 = GridView1.Rows[GridView1.SelectedIndex].Cells[1].ToString();
        //Label1.Text = s1;
        
        // logic 2:
        //ISession session = cluster.Connect("confession");
        //Label rating = GridView1.Rows[e.RowIndex].FindControl("rating") as Label;
        //Label1.Text = rating.ToString();      
        
        //string confessname = GridView1.SelectedRow.Cells[1].ToString();
        //session.Execute("update confess set rating=" + rate + "where confessname='" + confessname + "'");
        gvConfess.EditIndex = -1;
        showdata();

    }

    public void btnReTweet_Click(object sender, EventArgs e)
    {
        Session["username1"] = username1;
        Response.Redirect("userlist.aspx");
    }
}