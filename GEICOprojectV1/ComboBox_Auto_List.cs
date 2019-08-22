using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GEICOprojectV1
{
    public partial class VehicleTypeClass : Form
    {
        SqlConnection conString = new SqlConnection(@"Data Source=DESKTOP-H6O0PBI\MYSQL2026;Initial Catalog=Geico;Integrated Security=True");
        SqlCommand comand;
        SqlDataReader dataReader;
        string VehicleMake;     //declare to take list of vehicle manufacturer/make
        string VehicleModel;    //declare to take list of vehicle model
        string VehicleYear;     //declare to take list of vehicle Year

        public VehicleTypeClass()
        {
            InitializeComponent();
            ModelYear(); //call method that model year
            VehicleMakeMethod();//call method of manufacturere/make

        }

        //method to call Model Year and list when the form open
        void ModelYear()
        {

            conString.Open();
            //MessageBox.Show("DB Connected");
            string selectQuery = "select distinct VehicleYear from [Property].[VehicleDetailInfo] order by VehicleYear";
            comand = new SqlCommand(selectQuery, conString);

            try
            {
                dataReader = comand.ExecuteReader();
                while (dataReader.Read())
                {
                    VehicleYear = Convert.ToString(dataReader["VehicleYear"].ToString());
                    cmbYear.Items.Add(VehicleYear);

                }

            }
            catch (Exception)
            {
                //write exception code
            }


            conString.Close();
        }

        //call method Vehicle Make
        void VehicleMakeMethod()
        {

            conString.Open();

            string selectQuery = "select distinct VehicleMake from [Property].[VehicleDetailInfo] order by VehicleMake";
            comand = new SqlCommand(selectQuery, conString);

            try
            {

                dataReader = comand.ExecuteReader();
                while (dataReader.Read())
                {
                    VehicleMake = Convert.ToString(dataReader["VehicleMake"].ToString());
                    cmbMake.Items.Add(VehicleMake);
                }

            }
            catch (Exception)
            {
                //write exception code
            }
            conString.Close();
        }
        //this method is used to select Vehicle model
        private void CmbModel_SelectedValueChanged(object sender, EventArgs e)
        {
            conString.Open();
            string selectQuery = "select VehicleModel from [Property].[VehicleDetailInfo] where VehicleMake = '" + cmbMake.Text + "' "; //cmbMake is the combobox selected above VehicleMakeMethod()
            comand = new SqlCommand(selectQuery, conString);
            try
            {
                cmbModel.Items.Clear(); //make clear list of combobox when other Manufacturere/make selected
                cmbModel.Text = string.Empty;//make clear selected combobox value
                dataReader = comand.ExecuteReader();
                while (dataReader.Read())
                {
                    VehicleModel = Convert.ToString(dataReader["VehicleModel"].ToString());
                    cmbModel.Items.Add(VehicleModel);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Some thing error, please check and retry");
            }
            conString.Close();


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

    }
}

