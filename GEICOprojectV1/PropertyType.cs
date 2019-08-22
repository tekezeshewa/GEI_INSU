using System;
using System.Windows.Forms;

namespace GEICOprojectV1
{
    public partial class PropertyType : Form
    {
        public PropertyType()
        {
            InitializeComponent();
        }

        private void Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VehicleTypeClass vehicleType = new VehicleTypeClass();
            vehicleType.Show();
            Visible = false;
        }
    }
}
