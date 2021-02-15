using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinqToTwitter;
using System.IO;
using CassandraSharp;
using Cassandra;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.Windows.Forms;
public partial class tweet : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void btnImport_Click(object sender, EventArgs e)
    {
         string twitterAccountToDisplay = txtHashTag.Text; 

            const string accessToken = "3067838468-v5w7Yi0KyiZq4mx3aHZcPZusbYEiwGg2nRSj8Fl";
        
            const string accessTokenSecret = "HIJMuXveOkhKAL3ZVksDCucadGxd2ChqUSbUarpvFKAPp";

        
            const string consumerKey = "q8NG0WajAzUQNSzamvlX5wYbx";
        
            const string consumerSecret = "vlDw4gYfEQIAvUfoQ5a0ZN6sMYo1sGCDdnfsXQFLK2Ljpvoui3";

            var auth = new SingleUserAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = consumerKey,
                    ConsumerSecret = consumerSecret,
                    OAuthToken = accessToken,
                    OAuthTokenSecret = accessTokenSecret
                }
            };

            var tweetContext = new TwitterContext(auth);
            int c = 0;    

            var statusTweets = from tweet in tweetContext.Status
                               where tweet.Type == StatusType.User &&
                               tweet.ScreenName == twitterAccountToDisplay &&
                               tweet.IncludeContributorDetails == true &&
                               tweet.Count == 100 &&
                               tweet.RetweetCount >= 0 &&
                               tweet.IncludeEntities == true
                               select tweet;


            int j = 0;
            int count;
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            ISession session = cluster.Connect("confession");
            foreach (var stateTweet in statusTweets)
            {
                c = c + 1;
                String id = stateTweet.ScreenName;
                String twt = stateTweet.Text;
                DateTime dt = stateTweet.CreatedAt;

                int max = 1;
                int r = stateTweet.RetweetCount;
                RowSet rows = session.Execute("select * from confess");
                foreach (Row rw in rows.GetRows())
                {
                    string temp = rw["id"].ToString();
                    if (max <= Int32.Parse(temp))
                    {
                        max = Int32.Parse(temp);
                    }
                }
                char[] chararr = twt.ToCharArray();
                for (int i = 0; i < chararr.Length;i++ )
                {
                    if(chararr[i].Equals('\"') || chararr[i].Equals('\''))
                    {
                        chararr[i] = ' ';
                    }
                }
                twt = new string(chararr);
                count = max;
                session.Execute("insert into confess (id,confesstext,rating,username) values (" + (++count) + ", '" + twt + "'," + r + ",'" + twitterAccountToDisplay + "')");
                string dwnloadFilePath = @"G:\tweets\tweets.log";
                //Console.WriteLine("Tweets are here || " + twt);
                // CREATE AN EMPTY TEXT FILE
                FileStream fs1 = null;
                if (!File.Exists(dwnloadFilePath))
                {
                    using (fs1 = File.Create(dwnloadFilePath)) ;
                }

                // WRITE DATA INTO TEXT FILE
                if (File.Exists(dwnloadFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(dwnloadFilePath))
                    {

                        statusTweets.ToList().ForEach(
                        tweet => sw.Write(
                        "\n\n{0}]Tweet From [{1}] at |\n [{2}]| \n-{3} \n || {4}",
                        j, tweet.User.Name, tweet.Text, tweet.StatusID, tweet.CreatedAt));

                    }
                }

            }
            lblDone.Text = "Accessing Done for "+ c +" Tweets ";    
        }

}