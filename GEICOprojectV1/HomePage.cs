using System;
using System.Windows.Forms;

namespace GEICOprojectV1
{
    public partial class HomePage : Form
    {
        public string zipCode = "";
        public HomePage()
        {
            InitializeComponent();


        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Write code to clean all data and then exit
            Application.Exit();

        }




        private void BtnCheckRate_Click_1(object sender, EventArgs e)
        {
            if (txtZipCode.TextLength < 5)
            {
                MessageBox.Show("Please insert the correct Zip Code");
                HomePage hp = new HomePage();
                hp.Show();
                Visible = true;
            }
            else
            {
                Name frmName = new Name();
                frmName.Show();
                //call method to send Zip COde
                CurrentAddress curntAddress = new CurrentAddress();
                zipCode = txtZipCode.Text;
                curntAddress.ZipCode(zipCode);
                Visible = false;
            }
        }
    }
}
