using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace GEICOprojectV1
{
    public partial class AutoCombo : Form
    {
        //public string connection = @"Data Source=DESKTOP-H6O0PBI\MYSQL2026;Initial Catalog=Geico;Integrated Security=True";
        SqlConnection conString = new SqlConnection(@"Data Source=DESKTOP-H6O0PBI\MYSQL2026;Initial Catalog=Geico;Integrated Security=True");
        SqlConnection conString2 = new SqlConnection(@"Data Source=DESKTOP-H6O0PBI\MYSQL2026;Initial Catalog=Geico;Integrated Security=True");
        SqlCommand comand;
        SqlDataReader dataReader;
        List<category> categories = new List<category>();
        private object movie_name;
        public string cate_name;
        string imgLocation = "";//string to pass image path or image location


        public AutoCombo()
        {
            InitializeComponent();
            myToolTip(); //Display hint information when mouse appear or click
        }

    
        //Display hint information when mouse appear or click
        public void myToolTip() //this method will be called in Intialize method "myToolTip()"
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(txtDisply, "Display Hint");
            myToolTip.SetToolTip(cmbMovie2, " select movie");
            myToolTip.SetToolTip(cmbCategory, "select category");
            //this.txtDisply.Text = "Insert here";
        }
        //Auto fetch data from table using dataset
        public void AutoCombo_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'geicoDataSet.Movie' table. You can move, or remove it, as needed.
            movieTableAdapter.Fill(geicoDataSet.Movie);
            conString.Open();
            SqlCommand cmdCate = new SqlCommand("select * from category", conString);
            SqlDataReader ReaderCate = cmdCate.ExecuteReader();
            while (ReaderCate.Read())
            {
                cmbCategory.Items.Add(ReaderCate["Cate_name"]);
                categories.Add(new category()
                {
                    //id=((int) ReaderCate["Cate_id"]),
                    cate_name = ReaderCate["Cate_name"] as string
                });
            }
            conString.Close();

        }
        [Serializable]
        class category //class define to get list of data from category table
        {
            public int id { get; set; }
            public string cate_name { get; set; }
        }
        private void CmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {

            conString.Open();
            cate_name = cmbCategory.Text;
            MessageBox.Show("DB Connected");
            lblAA.Text = cate_name;
            string selectQuery = "select Movie_name from Movie";
            comand = new SqlCommand(selectQuery, conString);

            try
            {
                //string cmbMovieNull = ""; //create null string to assign cmbMovie2 combobox
                //cmbMovie2.Text = cmbMovieNull; //is used to set combo box clear
                //txtMovie.Clear(); //it is used to clear text box 
                cmbMovie2.Items.Clear(); //make the list of combobox
                cmbMovie2.Text = string.Empty;//make clear selected combobox value
               
                dataReader = comand.ExecuteReader();
                while (dataReader.Read())
                {
                    string movieList = Convert.ToString(dataReader["Movie_name"].ToString()); //data read from database
                    cmbMovie2.Items.Add(movieList); //add read data into combobox value

                }

            }
            catch (Exception)
            {
                //write exception code
            }


            conString.Close();
        }


      

        private void BtnSubmit_Click(object sender, EventArgs e)
        {


            //Automatically update bridge table using store procedure, Submit data in the Income table
            string storeProc = @"dbo.usp_CategMovi";
            conString.Open();
            SqlCommand cmdExc = new SqlCommand(storeProc, conString)
            {
                CommandType = CommandType.StoredProcedure
            };
            
            try
            {

                cmdExc.CommandTimeout = 0;
                cmdExc.Parameters.Add("@Movie_name", SqlDbType.NVarChar, 20).Value = cmbMovie2.Text;
                cmdExc.Parameters.Add("@Cate_name", SqlDbType.NVarChar, 20).Value = cmbCategory.Text;
                MessageBox.Show("SP assign parameter OK");
                cmdExc.ExecuteNonQuery();

                MessageBox.Show("read combo box and pass parameter!");

            }
            catch
            {
                MessageBox.Show("SP error");
                
            }

            /*
             * //Option 1: store procedure, but not work
            SqlParameter Movie_name = cmdExc.Parameters.Add("@Movie_name", SqlDbType.NVarChar, 20);
            SqlParameter Cate_name = cmdExc.Parameters.Add("@Cate_name", SqlDbType.NVarChar, 20);

            MessageBox.Show("SP assign parameter OK");
            Movie_name.Value = cmbMovie2.Text;
            Cate_name.Value = cmbCategory.Text;

            MessageBox.Show("read combo box and pass parameter!");
            */

            conString.Close();

        }

        private void BtnClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MovieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            movieBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(geicoDataSet);

        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {

        }

        //Insert image into database, load image, insert picture, load picture
        private void BtnSave_Click(object sender, EventArgs e)
        {

            byte[] image = null;
            FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader binryRead = new BinaryReader(streem);//convert the streem file path to binary
            image = binryRead.ReadBytes((int)streem.Length);//Read binary into int 
            conString.Open();
            try
            {
                string insertPic = "insert into Movie values ('" + cmbMovie2.Text + "',@image)";
                SqlCommand cmdInsert = new SqlCommand(insertPic, conString);
                cmdInsert.Parameters.Add(new SqlParameter("@image", image));//insert or the binary image data to table
                int N = cmdInsert.ExecuteNonQuery(); //count number of transaction excuted
                MessageBox.Show(N.ToString() + " Row is effected");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again");
            }
        }

        //Browse image, browse picture, upload picture and bring to the form
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*",
                Title = "Selected Picture"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString(); //copy the path of the picture, copy the image location, 
                pictureBox1.ImageLocation = imgLocation; //provide the path of the image and set in the picture box to display the picture
            }

        }
        //How to display hint information in textbox or combobox
        //Method following Event "Enter" that change color of selected item and category combobox
        private void CmbCategory_Enter(object sender, EventArgs e)
        {
            if(cmbCategory.Text == "Movie Category")
            {
                cmbCategory.Text = "";
                cmbCategory.ForeColor = Color.Black;
            }
        }
    
        //Method following Event "Leave" that change color of hint information "Movie Category" in combobox
        private void CmbCategory_Leave(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "")
            {
                cmbCategory.Text = "Movie Category";
                cmbCategory.ForeColor = Color.Silver;
            }
        }
        //Method following Event "Enter" that change color of selected item and category combobox
        private void CmbMovie2_Enter(object sender, EventArgs e)
        {
            if (cmbMovie2.Text == "Select Movie")
            {
                cmbMovie2.Text = "";
                cmbMovie2.ForeColor = Color.Black;
            }
        }
        //Method following Event "Leave" that change color of hint information "Movie Category" in combobox
        public void CmbMovie2_Leave(object sender, EventArgs e)
        {
            if (cmbMovie2.Text == "")
            {
                cmbMovie2.Text = "Select Movie";
                cmbMovie2.ForeColor = Color.Silver;
            }
        }







        //class Movie
        //{
        //    public int id { get; set; }
        //    public string movie_name { get; set; }
        //    public int cate_id { get; set; }
        //}


    }

}


