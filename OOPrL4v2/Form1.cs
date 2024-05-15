using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPrL4v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region DATETIME PICKER VOZAC
            // picker format dan rodnjenaj
            pickerDatumRodjenja.Format = DateTimePickerFormat.Custom;
            pickerDatumRodjenja.CustomFormat = "dd.MM.yyyy"; 
            pickerDatumRodjenja.ShowUpDown = false;

            // pikcer format vazi od
            pickerVaziOd.Format = DateTimePickerFormat.Custom;
            pickerVaziOd.CustomFormat = "dd.MM.yyyy";
            pickerVaziOd.ShowUpDown = false;

            // picker vazi do
            pickerVaziDo.Format = DateTimePickerFormat.Custom;
            pickerVaziDo.CustomFormat = "dd.MM.yyyy";
            pickerVaziDo.ShowUpDown = false;
            #endregion

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                // Ako nije karakter, sprečavamo unos tako što označavamo događaj kao obrađen
                e.Handled = true;
            }
        }
        private void tbBrojVozacke_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ako nije karakter, sprečavamo unos tako što označavamo događaj kao obrađen
                e.Handled = true;
            }
        }
    }
}
