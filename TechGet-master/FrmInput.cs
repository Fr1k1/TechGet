using DBLayer;
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
    public partial class FrmInput : Form
    {

       
        public FrmInput() 
        {
            InitializeComponent();
            //fundingSource=selectedSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<FundingSource> fundingSources = FundingSourceRepository.GetFundingSources();
            cboFundingSources.DataSource = fundingSources;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmProcurations frmProcurations = new FrmProcurations();
            Hide();
            frmProcurations.ShowDialog();
            Close();

        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboFundingSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            FundingSource currentSource= cboFundingSources.SelectedItem as FundingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

           
            

            if (txtBrojProjekta.Text == "" || txtPonuda1Odabrano.Text=="" || txtPonuda2Odabrano.Text=="" || txtPonuda1Cijena.Text==""
                || txtPonuda2Odabrano.Text=="" || txtKlasa.Text=="" || txtUrBroj.Text=="" || txtPonuda1Ponuditelj.Text=="" || txtPonuda2Ponuditelj.Text==""
                ||txtDodatnaPojasnjenja.Text=="")
            MessageBox.Show("Molim popunite sve podatke");

            else
            {
                int ur_broj = int.Parse(txtUrBroj.Text);
                int klasa = int.Parse(txtKlasa.Text);
                string datum = txtDatum1.Text;
                string opis_predmeta_nabave = txtOpisPredmetaNabave.Text;
                int br_projekta = 0;
                br_projekta = int.Parse(txtBrojProjekta.Text);


                int p1_odabrano = int.Parse(txtPonuda1Odabrano.Text);
                int p2_odabrano = int.Parse(txtPonuda2Odabrano.Text);

                float p1_cijena = float.Parse(txtPonuda1Cijena.Text);
                float p2_cijena = float.Parse(txtPonuda2Cijena.Text);

                string p1_ponuditelj = txtPonuda1Ponuditelj.Text;
                string p2_ponuditelj = txtPonuda2Ponuditelj.Text;

                string naziv_projekta = txtNazivProjekta.Text;
                string dodatna_pojasnjenja = txtDodatnaPojasnjenja.Text;


                //realizirano je po defaultu 0


                string izvor_financiranja = cboFundingSources.Text;





                //tak za sve

                Procuration nova_nabava = new Procuration();




                nova_nabava.Realizirano = 0;
                nova_nabava.ur_broj = ur_broj;

                nova_nabava.klasa = klasa;
                nova_nabava.Opis_predmeta_nabave = opis_predmeta_nabave;
                nova_nabava.p1_odabrano = p1_odabrano;
                float cijena_prvi;
                bool valid = float.TryParse(txtPonuda1Cijena.Text, out cijena_prvi);

                nova_nabava.p1_cijena = p1_cijena;
                nova_nabava.p1_ponuditelj = p1_ponuditelj;
                nova_nabava.p2_odabrano = p2_odabrano;
                nova_nabava.p2_cijena = p2_cijena;
                nova_nabava.p2_ponuditelj = p2_ponuditelj;
                nova_nabava.br_projekta = br_projekta;
                nova_nabava.naziv_projekta = naziv_projekta;
                nova_nabava.Datum = datum;

                nova_nabava.dodatna_pojasnjenja = dodatna_pojasnjenja;
                nova_nabava.FinanciranjeId = FundingSourceRepository.GetFundingSource(cboFundingSources.SelectedIndex+1);
                nova_nabava.ZaposlenikId = EmployeeRepository.GetEmployee(FrmLogin.LoggedEmployee.Id);





                //this.zaposlenik isti način ko na vježbama
                //svojstva preimenuj da pocnu velikim slovom


                ProcurationRepository.InsertProcuration(nova_nabava);

                MessageBox.Show("Uspješno ste unjeli zahtjev za nabavu");
            }


          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntUrediNabavu_Click(object sender, EventArgs e)
        {
            FrmChooseOperation frmUpdates = new FrmChooseOperation();
            Hide();
            frmUpdates.ShowDialog();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
