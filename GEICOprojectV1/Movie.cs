using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace GEICOprojectV1
{
    public partial class Movie : Form
    {
        SqlConnection conString = new SqlConnection(@"Data Source=DESKTOP-H6O0PBI\MYSQL2026;Initial Catalog=Geico;Integrated Security=True");
        List<Movie> Movies = new List<Movie>();
        public Movie()
        {
            InitializeComponent();
        }

        public object movie_name { get; private set; }
        public object movie_id { get; private set; }

        private void Movie_Load(object sender, System.EventArgs e)
        {
            conString.Open();
           
            string select = "select * from Movie order by movie_name";
            SqlCommand cmdMovie = new SqlCommand(select, conString);
            SqlDataReader selectRead = cmdMovie.ExecuteReader();
            while (selectRead.Read())
            {

                cmbMovieR.Items.Add(selectRead["Movie_name"]);
                Movies.Add(new Movie()
                {
                    movie_name = selectRead["Movie_name"] as string, //User movie_name string variable from Mov method
               

                    //movie_id = (int)selectRead["Movie_id"]
                }
                ) ; 
                    
            }
           conString.Close();
        }
      
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //How call function and return function return value, how to get return value of SQL function store procedure, 
             
        private void CmbMovieR_SelectedIndexChanged(object sender, EventArgs e) //method that trigger when movie text box selected, and call function method
        {
            conString.Open();
           

           //------- //Get ID and display in text Filed, then pass the ID to function store procedure
            string idQuery = @"select id from Movie where Movie_name = '" + cmbMovieR.Text + "';"; 
            SqlCommand cmdExc = new SqlCommand(idQuery, conString);
            MessageBox.Show("MovieId Send successfuly! done");
            int id = (int)cmdExc.ExecuteScalar(); //get id from database based on type of selected movie "cmbMovieR.Text"
            //txtMovieID.Text = Convert.ToString(id);//it is simply to display and see the result to confirm id is bring from database or not
            //-------------

            string udFunction = @"select dbo.udf_RentPrice (@id)";
           
            SqlCommand cmdFun = new SqlCommand(udFunction, conString);

            //define and set parameter value, How to pass parameter to Function
            SqlParameter parm1 = new SqlParameter();
            parm1.ParameterName = "@id";
            parm1.SqlDbType = SqlDbType.Int;
            parm1.Value = id; //assign parameter value  based on above selected query 

            //pass paramter value to user defined function "dbo.udf_RentPrice (@id)"
            cmdFun.Parameters.Add(parm1); 

           
            try
            {
               
                //Execute function query and return the result
                Decimal rentPrice = (Decimal)cmdFun.ExecuteScalar();
                
                //put the result into text box for display
                txtRentPrice.Text = Convert.ToString(rentPrice);



                ////How to getdate function result, how to return Function, return getdate
                string getDateQuery = @"SELECT GETDATE() AS CurrentDateTime;";
                SqlCommand cmdGetDate = new SqlCommand(getDateQuery, conString);
                DateTime getDateResult;
                getDateResult = (DateTime)cmdGetDate.ExecuteScalar();
                txtGetDate.Text = getDateResult.ToString();
                MessageBox.Show("GetDate code reach");

            }
            catch (Exception)
            {
                MessageBox.Show("Stop: Exception Error Result");
                InitializeComponent();
            }

            conString.Close();

        }
    }
}
