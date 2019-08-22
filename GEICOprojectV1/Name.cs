using System;
using System.Windows.Forms;

namespace GEICOprojectV1
{
    public partial class Name : Form
    {
        public string firstName = "";
        public string lastName = "";
        public Name()
        {
            InitializeComponent();
        }

        private void LnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage frmHomePage = new HomePage();//declar object to call HomePage form/page

            frmHomePage.Show(); //when click back, Open Date of Hoem Page Form/page
            Visible = false; //close other form/page opened
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Write code to clean all field,
            //Delete if we save in database
            //close
            Application.Exit();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            DateOfBirth dateBirth = new DateOfBirth(); //declar object to call DateOfBirth form/page
            dateBirth.FullName(firstName + " " + lastName); //call FullName name mehtod of date of birth 

            CurrentAddress curntAddress = new CurrentAddress();
            curntAddress.FullName(firstName + " " + lastName);  //call FullName name mehtod of CurrentAddress

            //mehtod to pass FirstName and Last Name to final Database on Final Page
            //FullName(txtFirstName, txtLastName
            dateBirth.Show();//Open Date of Birth Form/page
            Visible = false; //close other form/page opened
        }

    
    }
}
