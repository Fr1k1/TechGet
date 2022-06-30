using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGet.Models;
using TechGet.Repositories;

namespace TechGet
{
    public partial class FrmUpdate : Form
    {

        private Procuration procuration;

        public Procuration selected_procuration { get => procuration; set=> procuration = value; }
        public FrmUpdate(Procuration selected_procuration)
        {
            InitializeComponent();
            this.selected_procuration = selected_procuration;
        }

        private void FrmAzuriraj_Load(object sender, EventArgs e)
        {
            txtUrBroj.Text = selected_procuration.ur_broj.ToString();
            txtKlasa.Text=selected_procuration.klasa.ToString();
            txtDatum.Text = selected_procuration.Datum.ToString();
            txtOpisPredmetaNabave.Text=selected_procuration.Opis_predmeta_nabave.ToString();
            txtPonuda1Cijena.Text = selected_procuration.p1_cijena.ToString();
            txtPonuda1Odabrano.Text = selected_procuration.p1_odabrano.ToString();
            txtPonuda1Ponuditelj.Text = selected_procuration.p1_ponuditelj.ToString();

            txtPonuda2Cijena.Text = selected_procuration.p2_cijena.ToString();
            txtPonuda2Odabrano.Text = selected_procuration.p2_odabrano.ToString();
            txtPonuda2Ponuditelj.Text = selected_procuration.p2_ponuditelj.ToString();

            txtBrojProjekta.Text = selected_procuration.br_projekta.ToString();
            txtDodatnaPojasnjenja.Text = selected_procuration.dodatna_pojasnjenja.ToString();
            txtNazivProjekta.Text = selected_procuration.naziv_projekta.ToString();

            var fundings=FundingSourceRepository.GetFundingSources();
            cboFundingSources.DataSource = fundings;
            //tak napravi za sve elemente
        }

        private void txtUrBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objekt_nabava = this.selected_procuration;
            int ur_broj = int.Parse(txtUrBroj.Text.ToString());
            
            int klasa = int.Parse(txtKlasa.Text);
            string datum = txtDatum.Text;
            string opis_predmeta_nabave = txtOpisPredmetaNabave.Text;
            
            int br_projekta = int.Parse(txtBrojProjekta.Text);

            var fundings = cboFundingSources.SelectedItem as FundingSource;
            int p1_odabrano = int.Parse(txtPonuda1Odabrano.Text);
            int p2_odabrano = int.Parse(txtPonuda2Odabrano.Text);

            float p1_cijena = float.Parse(txtPonuda1Cijena.Text);
            float p2_cijena = float.Parse(txtPonuda2Cijena.Text);

            string p1_ponuditelj = txtPonuda1Ponuditelj.Text;       //mozda treba svugde postaviti ToString()
            string p2_ponuditelj = txtPonuda2Ponuditelj.Text;

            string naziv_projekta = txtNazivProjekta.Text;
            string dodatna_pojasnjenja = txtDodatnaPojasnjenja.Text;

            /*
             * public static void UpdateProcuration(Procuration procuration, int ur_broj, int klasa, string datum, string opis_predmeta_nabave, int p1_odabrano,
            int p2_odabrano, float p1_cijena, float p2_cijena, string p1_ponuditelj, string p2_ponuditelj, string naziv_projekta, string dodatna_pojasnjenja,
            FundingSource fundings, int br_projekta)
            */
            ProcurationRepository.UpdateProcuration(objekt_nabava, ur_broj, klasa,datum, opis_predmeta_nabave, p1_odabrano, p2_odabrano, p1_cijena, p2_cijena,
                p1_ponuditelj,p2_ponuditelj,naziv_projekta,dodatna_pojasnjenja,fundings,br_projekta); //proslijedi sve vrijednosti
            
            Close();

           /* string sql = $"UPDATE Nabave SET Ur_broj={ur_broj},Klasa={klasa}, Datum='{datum}',Opis_predmeta_nabave" +
                $"='{opis_predmeta_nabave}', p1_ponuditelj='{p1_ponuditelj}', p2_ponuditelj='{p2_ponuditelj}" +
                $"Naziv_projekta='{naziv_projekta}', Dodatna_pojasnjenja='{dodatna_pojasnjenja}', p1_cijena={p1_cijena}," +
                $"p2_odabrano={p2_odabrano}, p1_odabrano={p1_odabrano}, p2_cijena='{p2_cijena}', Br_projekta={br_projekta}, FinanciranjeId={fundings.Id} WHERE Id='{procuration.Id}'";
           */
            FrmChooseOperation frmUpdateDelete = new FrmChooseOperation();
            MessageBox.Show("Uspješno ste ažurirali nabavu!");
            frmUpdateDelete.ShowDialog();


        }
    }
}
