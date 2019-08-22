using System;
using System.Data.SqlClient;
using System.Windows.Forms;





namespace GEICOprojectV1
{
    public partial class CurrentAddress : Form
    {
        SqlConnection conString = new SqlConnection(@"Data Source=DESKTOP-H6O0PBI\MYSQL2026;Initial Catalog=Geico;Integrated Security=True");
        SqlCommand comand;
        SqlDataReader dataReader;
        public CurrentAddress()
        {
            InitializeComponent();
            CityStateListFromDB();

        }

        //emporary pend 
        void CityStateListFromDB()
        {


            conString.Open();
            //MessageBox.Show("DB Connected");
            string selectQuery = "select distinct StateCatg, city from [Place].[Location] order by city asc, StateCatg asc";
            comand = new SqlCommand(selectQuery, conString);

            try
            {

                dataReader = comand.ExecuteReader();
                while (dataReader.Read())
                {
                    string city = Convert.ToString(dataReader["City"].ToString());
                    cmbCiy.Items.Add(city);
                    string stateCatg = Convert.ToString(dataReader["stateCatg"].ToString());
                    cmbState.Items.Add(stateCatg);
                }

            }
            catch (Exception)
            {
                //write exception code
            }


            conString.Close();
        }
        public void FullName(string fullName)//method data receive from Name Page
        {
            lblFullName.Text = fullName;
        }
        //method to receive zipCode from HomePage
        public void ZipCode(string zipCode)
        {
            lblZipCode.Text = zipCode;
            txtZipCode.Text = zipCode;
        }

        //click back button on Current page
        private void LnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateOfBirth dateBirth = new DateOfBirth();//delare object to call Date of Birth form
            dateBirth.Show(); //open Date of Birth form
            Visible = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            PropertyType propertyTpe = new PropertyType();
            propertyTpe.Show();
            Visible = false;
        }
        //close the application when 'Cancled'
        private void LnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }




    }
}
