using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace GEICOprojectV1
{
    public partial class VehicleTypeClass : Form
    {
        SqlConnection conSt = new SqlConnection(@"Data Source=DESKTOP-H6O0PBI\MYSQL2026;Initial Catalog=Geico;Integrated Security=True");
        SqlCommand cmnd;
        SqlDataReader dtReader;
        string VhcleMake;     //declare to take list of vehicle manufacturer/make
        string VhcleModel;    //declare to take list of vehicle model
        string VhcleYear;     //declare to take list of vehicle Year

        public VehicleTypeClass()
        {
            InitializeComponent();
            ModelYearMethod(); //call method that model year
            VhcleMakeMethod();//call method of manufacturere/make

        }

        private void VhcleMakeModel(Object sender, EventArgs e)
        {
            conSt.Open();
            SqlCommand cmdCate = new SqlCommand("select * from categories", conSt);
            SqlDataReader ReaderCate = cmdCate.ExecuteReader();
            while (ReaderCate.Read())
            {

            }
        }
        //method to call Model Year and list when the form open
        void ModelYearMethod()
        {

            conSt.Open();
            //MessageBox.Show("DB Connected");
            string selectQuery = "select distinct VhcleYear from [Property].[VehicleDetailInfo] order by VhcleYear";
            cmnd = new SqlCommand(selectQuery, conSt);

            try
            {
                dtReader = cmnd.ExecuteReader();
                while (dtReader.Read())
                {
                    VhcleYear = Convert.ToString(dataReader["VhcleYear"].ToString());
                    cmbYear.Items.Add(VhcleYear);

                }

            }
            catch (Exception)
            {
                //write exception code
            }


            conSt.Close();
        }

        //call method Vehicle Make
        void VhcleMakeMethod()
        {

            conSt.Open();

            string selectQuery = "select distinct VhcleMake from [Property].[VehicleDetailInfo] order by VhcleMake";
            cmnd = new SqlCommand(selectQuery, conSt);

            try
            {

                dtReader = cmnd.ExecuteReader();
                while (dtReader.Read())
                {
                    VhcleMake = Convert.ToString(dataReader["VhcleMake"].ToString());
                    cmbMake.Items.Add(VhcleMake);
                }

            }
            catch (Exception)
            {
                //write exception code
            }
            conSt.Close();
        }
        //this method is used to select Vehicle model
        private void CmbModel_SelectedValueChanged(object sender, EventArgs e)
        {
            conSt.Open();
            string selectQuery = "select VhcleModel from [Property].[VehicleDetailInfo] where VhcleMake = '" + cmbMake.Text + "' "; //cmbMake is the combobox selected above VhcleMakeMethod()
            cmnd = new SqlCommand(selectQuery, conSt);
            try
            {
                cmbModel.Items.Clear(); //make clear list of combobox when other Manufacturere/make selected
                cmbModel.Text = string.Empty;//make clear selected combobox value
                dtReader = cmnd.ExecuteReader();
                while (dtReader.Read())
                {
                    VhcleModel = Convert.ToString(dtReader["VhcleModel"].ToString());
                    cmbModel.Items.Add(VhcleModel);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Some thing error, please check and retry");
            }
            conSt.Close();


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

    }
}

