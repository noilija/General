using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPrL4v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vozac v1 = new Vozac();
        ListaVozaca lv1 = new ListaVozaca();
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

        private void btnZatvori_Click(object sender, EventArgs e)
        {

        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            v1 = new Vozac();
            if (tbIme.Text != String.Empty &&
                tbPrezime.Text != String.Empty &&
                tbMestoIzdavanja.Text != String.Empty &&
                tbBrojVozacke.Text != String.Empty &&
                comboPol.Text != String.Empty)
            {
                v1.Ime = tbIme.Text;
                v1.Prezime = tbPrezime.Text;
                v1.DatumRodjenja = pickerDatumRodjenja.Value;
                v1.BrojVozacke = int.Parse(tbBrojVozacke.Text);
                v1.MestoIzdavanja = tbMestoIzdavanja.Text;
                v1.VazenjeDozvoleDo = pickerVaziDo.Value;
                v1.VazenjeDozvoleOd = pickerVaziOd.Value;
                v1.Pol = comboPol.Text[0];
                //v1.PutanjaSlike = slikaVozaca.ImageLocation;
                v1.prikaz();
                lv1.dodajVozaca(v1);
            }
            else
                MessageBox.Show("Nisu popunjena sva polja");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnPrikaziListu_Click(object sender, EventArgs e)
        {
            try
            {
                lv1.prikaz();
                dgListaVozaca.Rows.Clear();
                //dgListaVozaca.
                for(int i=0;i<lv1.Vozaci.Count;i++) 
                {
                    //dgListaVozaca.Rows.Insert(i, lv1.Vozaci[i].Ime, lv1.Vozaci[i].Prezime, lv1.Vozaci[i].BrojVozacke);
                    dgListaVozaca.Rows.Add(lv1.Vozaci[i].Ime, lv1.Vozaci[i].Prezime, lv1.Vozaci[i].BrojVozacke);
                }
                //dgListaVozaca.Columns["DatumRodjenja"].Visible=false;
                //dgListaVozaca.Columns["MestoIzdavanja"].Visible = false;
                //dgListaVozaca.Columns["Pol"].Visible = false;
                //dgListaVozaca.Columns["PutanjaSlike"].Visible = false;
                //dgListaVozaca.Columns["VazenjeDozvoleOd"].Visible = false;
                //dgListaVozaca.Columns["VazenjeDozvoleDo"].Visible = false;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
