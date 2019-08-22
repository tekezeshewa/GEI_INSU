using System;
using System.Windows.Forms;

namespace GEICOprojectV1
{
    public partial class DateOfBirth : Form
    {
        public DateOfBirth()
        {
            InitializeComponent();
        }
        public void FullName(string fullName) //method toreceive full name and display on the next page
        {

            lblFullName.Text = fullName;
        }
        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Name frmName = new Name();
            frmName.Show();
            //call method to send Zip COde
            Visible = false;
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Write code to clean all field,
            //Delete if we save in database since it is not reach final submit
            //close
            Application.Exit();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //call current Address Page
            CurrentAddress curntAddress = new CurrentAddress();
            curntAddress.Show();
            Visible = false;
        }

        private void LnkClose_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

   
    }
}
