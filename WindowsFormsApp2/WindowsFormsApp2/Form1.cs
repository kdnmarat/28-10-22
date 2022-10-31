using System;
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
        BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
            ContactDetails.AllRecords = new List<ContactDetails>();
            bindingSource = new BindingSource(ContactDetails.AllRecords, null);
            dgContacts.DataSource = bindingSource;
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
            bindingSource.Add(record);
            slStatus.ForeColor = Color.Green;
            slStatus.Text = "OK!";
            slDetails.Text = $"Record was stored. {ContactDetails.AllRecords.Count} in total.";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            slStatus.ForeColor = Color.Green;
            slStatus.Text = "OK!";
            slDetails.Text = $"{ContactDetails.AllRecords.Count} rows are loaded.";
        }

        private void dgContacts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            slStatus.ForeColor = Color.OrangeRed;
            slStatus.Text = "Changed!";
            slDetails.Text = $"Row '{e.RowIndex}' was changed in cell '{e.ColumnIndex}'.";
        }

        private void dgContacts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            slStatus.ForeColor = Color.OrangeRed;
            slStatus.Text = "Removed!";
            slDetails.Text = $"Row '{e.RowIndex}' was deleted.'";
        }
    }
}
