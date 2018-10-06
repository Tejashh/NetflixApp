//
// BusinessTier: business logic, acting as interface between UI and data store.
//
// <<Tejash Contractor>>
// U. of Illinois, Chicago
// CS341, Spring 2018
// Final Project
//

using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{

  //
  // Business:
  //
  public class Business
  {
    //
    // Fields:
    //
    private string _DBFile;
    private DataAccessTier.Data dataTier;


    //
    // Constructor:
    //
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;

      dataTier = new DataAccessTier.Data(DatabaseFilename);
    }


    //
    // TestConnection:
    //
    // Returns true if we can establish a connection to the database, false if not.
    //
    public bool TestConnection()
    {
      return dataTier.TestConnection();
    }


    //
    // GetNamedUser:
    //
    // Retrieves User object based on USER NAME; returns null if user is not
    // found.
    //
    // NOTE: there are "named" users from the Users table, and anonymous users
    // that only exist in the Reviews table.  This function only looks up "named"
    // users from the Users table.
    //
    public User GetNamedUser(string UserName)
    {
            //
            // TODO!
            //

            User users = null;

            string sql = string.Format(@"SELECT * FROM Users WHERE UserName = '{0}';", UserName);
            DataSet data = dataTier.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                users = new User(Convert.ToInt32(row["UserID"]), Convert.ToString(row["UserName"]), Convert.ToString(row["Occupation"]));
            }
            return users;
        }


    //
    // GetAllNamedUsers:
    //
    // Returns a list of all the users in the Users table ("named" users), sorted 
    // by user name.
    //
    // NOTE: the database also contains lots of "anonymous" users, which this 
    // function does not return.
    //
    public IReadOnlyList<User> GetAllNamedUsers()
    {
      List<User> users = new List<User>();

            //
            // TODO!
            //
            string sql = string.Format(@"SELECT * From Users ORDER BY UserName;");
            DataSet data = dataTier.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                User user = new User(Convert.ToInt32(row["UserID"]), Convert.ToString(row["UserName"]), Convert.ToString(row["Occupation"]));
                users.Add(user);
            }
            return users;
    }


    //
    // GetMovie:
    //
    // Retrieves Movie object based on MOVIE ID; returns null if movie is not
    // found.
    //
    public Movie GetMovie(int MovieID)
    {
            //
            // TODO!
            //

            Movie movies = null;

            string sql = string.Format(@"SELECT * FROM Movies WHERE MovieID = '{0}';", MovieID);
            DataSet data = dataTier.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                movies = new Movie(Convert.ToInt32(row["MovieID"]), Convert.ToString(row["MovieName"]));
            }
            return movies;
        }


    //
    // GetMovie:
    //
    // Retrieves Movie object based on MOVIE NAME; returns null if movie is not
    // found.
    //
    public Movie GetMovie(string MovieName)
    {
            //
            // TODO!
            //

            Movie movies = null;

            string sql = string.Format(@"SELECT * FROM Movies WHERE MovieName = '{0}';", MovieName);
            DataSet data = dataTier.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                movies = new Movie(Convert.ToInt32(row["MovieID"]), Convert.ToString(row["MovieName"]));
            }
      
      return movies;
    }


    //
    // AddReview:
    //
    // Adds review based on MOVIE ID, returning a Review object containing
    // the review, review's id, etc.  If the add failed, null is returned.
    //
    public Review AddReview(int MovieID, int UserID, int Rating)
    {
            //
            // TODO!
            //
            Review review = null;
            // IDEA TAKEN FROM GIVEN DOCUMENTATION:
            string sql = string.Format(@"INSERT INTO Reviews(UserID,MovieID,Rating) VALUES('{0}','{1}','{2}');
SELECT ReviewID FROM Reviews WHERE ReviewID = SCOPE_IDENTITY();", UserID,MovieID,Rating);
            DataSet data = dataTier.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                review = new Review(Convert.ToInt32(row["ReviewID"]),MovieID, UserID, Rating);
            }
            return review;
    }


    //
    // GetMovieDetail:
    //
    // Given a MOVIE ID, returns detailed information about this movie --- all
    // the reviews, the total number of reviews, average rating, etc.  If the 
    // movie cannot be found, null is returned.
    //
    public MovieDetail GetMovieDetail(int MovieID)
    {
            //
            // TODO!
            //
            List<Review> reviews = new List<Review>();
            MovieDetail movies = null;
            Movie movie = null;

            string sql = string.Format(@"SELECT * FROM Reviews INNER JOIN Movies ON Reviews.MovieID = Movies.MovieID
WHERE Reviews.MovieID = '{0}'
ORDER BY Rating DESC, UserID ASC;", MovieID);
            DataSet data = dataTier.ExecuteNonScalarQuery(sql);
            double rat = 0.0;
            int count = 0;
            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                movie = new Movie(Convert.ToInt32(row["MovieID"]), Convert.ToString(row["MovieName"]));
                Review review = new Review(Convert.ToInt32(row["ReviewID"]), Convert.ToInt32(row["MovieID"]), Convert.ToInt32(row["UserID"]), Convert.ToInt32(row["Rating"]));
                reviews.Add(review);
                rat = rat + Convert.ToInt32(row["Rating"]);
                count++;
                movies = new MovieDetail(movie, Math.Round((rat/count),1), MovieID, reviews);
            }

            return movies;
    }


    //
    // GetUserDetail:
    //
    // Given a USER ID, returns detailed information about this user --- all
    // the reviews submitted by this user, the total number of reviews, average 
    // rating given, etc.  If the user cannot be found, null is returned.
    //
    public UserDetail GetUserDetail(int UserID)
    {
            //
            // TODO!
            //

            List<Review> reviews = new List<Review>();
            UserDetail users = null;
            User user = null;

            string sql = string.Format(@"SELECT * FROM Reviews INNER JOIN Movies ON Reviews.MovieID = Movies.MovieID INNER JOIN Users ON Reviews.UserID = Users.UserID
WHERE Reviews.UserID = '{0}'
ORDER BY MovieName ASC;", UserID);
            DataSet data = dataTier.ExecuteNonScalarQuery(sql);
            double rat = 0.0;
            int count = 0;
            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                user = new User(Convert.ToInt32(row["UserID"]), Convert.ToString(row["UserName"]), Convert.ToString(row["Occupation"]));
                Review review = new Review(Convert.ToInt32(row["ReviewID"]), Convert.ToInt32(row["MovieID"]), Convert.ToInt32(row["UserID"]), Convert.ToInt32(row["Rating"]));
                reviews.Add(review);
                rat = rat + Convert.ToInt32(row["Rating"]);
                count++;
                users = new UserDetail(user, Math.Round((rat / count), 1), UserID, reviews);
            }

            return users;
        }


    //
    // GetTopMoviesByAvgRating:
    //
    // Returns the top N movies in descending order by average rating.  If two
    // movies have the same rating, the movies are presented in ascending order
    // by name.  If N < 1, an EMPTY LIST is returned.
    //
    public IReadOnlyList<Movie> GetTopMoviesByAvgRating(int N)
    {
      List<Movie> movies = new List<Movie>();

            //
            // TODO!
            //
            string sql = string.Format(@"SELECT TOP {0} Reviews.Rating, Movies.MovieName
            FROM Reviews
            INNER JOIN Movies
            ON Movies.MovieID = Reviews.MovieID ORDER BY Reviews.Rating DESC;", N);

            DataSet data = dataTier.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in data.Tables["TABLE"].Rows)
            {
                var movie = new Movie(Convert.ToInt32(row["Rating"]), Convert.ToString(row["MovieName"]));
                movies.Add(movie);
            }
            return movies;
    }


  }//class
}//namespace
