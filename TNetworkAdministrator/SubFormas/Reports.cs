﻿using System;


namespace TNetworkAdministrator.SubFormas
{
    public partial class Reports : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SubFormas.Report rp = new Report();
                rp.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
