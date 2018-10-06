//
//  Netflix Database  Application  using  N-Tier Design.
//
//  <<Tejash Contractor>>
//  U.  of  Illinois,  Chicago
//  CS341, Spring  2018
//  Project  08
//

//
// Referene: I Used Code from Last Wed and Friday Lacture (Week 14):
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        //Movie Button Click even which display all the movie names in the list Movie Box:
        //
        private void movButton_Click(object sender, EventArgs e)
        {

            //Code taken from Wed Lacture:
            string filename, version, connectionInfo;
            SqlConnection db;

            version = "MSSQLLocalDB";
            filename = this.txtDatabase.Text;

            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"select MovieName from Movies Order by Moviename ASC;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);

            db.Close();
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["MovieName"]));

                this.lstMovies.Items.Add(msg);
            }
        } // end of the movie button clickEvent

        //
        // Select movie from movie list and it will display movie id and review in seperate text boxes:
        //
        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Code taken from Wed Lacture:
            string filename = this.txtDatabase.Text;

            BusinessTier.Business biztier = new BusinessTier.Business(filename);
            var movie = biztier.GetMovie(this.lstMovies.Text);
            

            this.textMovieID.Text = movie.MovieID.ToString();
            var details = biztier.GetMovieDetail(movie.MovieID);

            this.textMovieRating.Text = details.AvgRating.ToString();
        }// end of the lstMovies Select Index event:


        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
        }// txtDatabase

        //
        //Click review button to display the review of selected movie:
        //
        private void revButton_Click(object sender, EventArgs e)
        {
            this.lstReviews.Items.Clear();

            if(this.lstMovies.SelectedIndex <0)
            {
                MessageBox.Show("Please select a movie...");
                return;
            }

            // Code taken From Friday Lacture:
            string moviename = this.lstMovies.Text;
            int movieid = System.Int32.Parse(this.textMovieID.Text);

            this.lstReviews.Items.Add(moviename);
            this.lstReviews.Items.Add("");

            if (this.textMovieRating.Text == "0")
            {
                this.lstReviews.Items.Add("There are No Reviews");
            }

            BusinessTier.Business biztier = new BusinessTier.Business(this.txtDatabase.Text);

            BusinessTier.MovieDetail details = biztier.GetMovieDetail(movieid);
          
            foreach (BusinessTier.Review review in details.Reviews)
            {
                string line = string.Format("{0}: {1}", review.UserID, review.Rating);
                this.lstReviews.Items.Add(line);
            }
        }//end of the review button:

        //
        // Each Reveiw button which is dispalyed in the listEach rating box which take input
        // by selecting movie in the movie List.
        //
        private void eachRating_Click(object sender, EventArgs e)
        {
            this.lstEachRating.Items.Clear();

            if (this.lstMovies.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a movie...");
                return;
            }
            // Code taken From Friday Lacture:
            string moviename = this.lstMovies.Text;
            int movieid = System.Int32.Parse(this.textMovieID.Text);

            this.lstEachRating.Items.Add(moviename);
            this.lstEachRating.Items.Add("");

            BusinessTier.Business biztier = new BusinessTier.Business(this.txtDatabase.Text);

            BusinessTier.MovieDetail details = biztier.GetMovieDetail(movieid);

            var reviews = details.Reviews;

            //query taken from Friday Lacture
            var query = from r in details.Reviews
                        group r by r.Rating into grp
                        orderby grp.Key descending
                        select new
                        {
                            Rating = grp.Key,
                            Count = grp.Count()
                        };
            var count = 0;
            foreach(var tuple in query)
            {
                string line = string.Format("{0}: {1}",
                    tuple.Rating, tuple.Count);
                count = count + tuple.Count;

                this.lstEachRating.Items.Add(line);
            }
            this.lstEachRating.Items.Add("");

            this.lstEachRating.Items.Add("Total:" + count);

        }//ebd of the each Review Button:

        //
        // Usr button which display username in the list user name box:
        //
        private void cmdUserName_Click(object sender, EventArgs e)
        {
            string filename, version, connectionInfo;
            SqlConnection db;

            version = "MSSQLLocalDB";
            filename = this.txtDatabase.Text;

            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"select UserName from Users Order by UserName ASC;");

            //MessageBox.Show(sql);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);

            db.Close();
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["UserName"]));

                this.lstUserName.Items.Add(msg);
            }
        }// end of the UserName BUtton:

        //
        //Select username and it will diplay User ID and Occupation in the text Box:
        //
        private void lstUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filename = this.txtDatabase.Text;

            BusinessTier.Business biztier = new BusinessTier.Business(filename);
            var username = biztier.GetNamedUser(this.lstUserName.Text);
            this.txtUserID.Text = username.UserID.ToString();

            var details = biztier.GetUserDetail(username.UserID);
            if (details.user.Occupation.ToString() == "")
            {
                this.txtOccupation.Text = "NULL";
            }
            else
            {
                this.txtOccupation.Text = details.user.Occupation.ToString();
            }
        }// end of the lstUserName Select Event:

        //
        // UserReview button which will display movie name and review given in the movie with username on the top:
        //
        private void cndUserReview_Click(object sender, EventArgs e)
        {
            this.lstReview1.Items.Clear();

            if (this.lstUserName.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a user...");
                return;
            }

            string username = this.lstUserName.Text;
            int userID = System.Int32.Parse(this.txtUserID.Text);

            this.lstReview1.Items.Add(username);
            this.lstReview1.Items.Add("");

            BusinessTier.Business biztier = new BusinessTier.Business(this.txtDatabase.Text);

            BusinessTier.UserDetail details = biztier.GetUserDetail(userID);
           

            var reviews = details.Reviews;

            foreach (var review in reviews)
            {
                var movieID = review.MovieID;
                BusinessTier.MovieDetail detail = biztier.GetMovieDetail(movieID);
                string line = string.Format("{0}-> {1}", detail.movie.MovieName, review.Rating);
                this.lstReview1.Items.Add(line);
            }
        }//end of the username review button:

        private void txtInsertBox_TextChanged(object sender, EventArgs e)
        {
        }//txtInsertBox

        //
        // Instert Review :
        //
        private void addReview_Click(object sender, EventArgs e)
        {
            if (this.txtInsertBox.Text == "")
            {
                MessageBox.Show("Please select a Movie name , User Name and enter Review..");
                return;
            }
            if (this.lstMovies.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a movie...");
                return;
            }
            if (this.lstUserName.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a UserName...");
                return;
            }
            

            int input = System.Int32.Parse(this.txtInsertBox.Text);
            if (input < 0 || input > 5)
            {
                MessageBox.Show("Please enter Rating between 1 to 5...");
                return;
            }

            
            int movieid = System.Int32.Parse(this.textMovieID.Text);
            int userid = System.Int32.Parse(this.txtUserID.Text);
            

            BusinessTier.Business biztier = new BusinessTier.Business(this.txtDatabase.Text); 
            BusinessTier.Review review = biztier.AddReview(movieid, userid, input);

            MessageBox.Show("Review is added...");


            //this.lstReviews.Items.Add(review.UserID.ToString());
            //this.lstReview1.Items.Add(review.MovieID.ToString());
        }//end of the insert review event:

        //
        // Top nth movies will be displayed with the average review of the movies in decending order:
        //
        private void TopNButton_Click(object sender, EventArgs e)
        {
            this.lstTopNAverageRattingMovies.Items.Clear();

            if (this.NValue.Text == "")
            {
                MessageBox.Show("Please emter Nth value...");
                return;
            }

            int N = System.Int32.Parse(this.NValue.Text);

            if (N < 1)
            {
                MessageBox.Show("Please enter positive number...");
                return;
            }

            BusinessTier.Business biztier = new BusinessTier.Business(this.txtDatabase.Text);

            //var numReviews = biztier.GetTopMoviesByNumReviews(N);
            var avgRating = biztier.GetTopMoviesByAvgRating(N);
           // var userNumReviews = biztier.GetTopUsersByNumReviews(N);

            foreach(var review in avgRating)
            {

                var details = biztier.GetMovieDetail(review.MovieID);
                string line = string.Format("{0}: {1}", review.MovieName, details.AvgRating.ToString());
                this.lstTopNAverageRattingMovies.Items.Add(line);
            }
            
            //this.lstTopNAverageRattingMovies.Items.Add(avgRating.ToString());
        }// end of the Nth top list:

        private void textMovieRating_TextChanged(object sender, EventArgs e)
        {
        }//textMovieRating

        private void lstReviews_SelectedIndexChanged(object sender, EventArgs e)
        {
        }//lstReviews

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
