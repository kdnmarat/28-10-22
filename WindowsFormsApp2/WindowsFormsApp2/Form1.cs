﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ContactDetails.AllRecords = new List<ContactDetails>();
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string street = tbStreet.Text;
            string city = tbCity.Text;
            string state = tbState.Text;
            string zip = tbZip.Text;
            if (name.Length == 0 || street.Length == 0 || city.Length == 0 || state.Length == 0 || zip.Length == 0)
            {
                slStatus.ForeColor = Color.Red;
                slStatus.Text = "ERROR!";
                slDetails.Text = "Fields can't be empty";
                return;
            }
            ContactDetails record = new ContactDetails(name,street,city,state,zip);
            ContactDetails.AllRecords.Add(record);
            slStatus.ForeColor = Color.Green;
            slStatus.Text = "OK!";
            slDetails.Text = "Record was stored";
        }
    }
}
