using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGet.Repositories;

namespace TechGet
{
    public partial class FrmProcurations : Form
    {
        public FrmProcurations()
        {
            InitializeComponent();
        }

        private void FrmProcurations_Load(object sender, EventArgs e)
        {
            ShowProcurations();
        }

        private void ShowProcurations()
        {
            var procurations = ProcurationRepository.GetProcurations();
            dgvProcurations.DataSource = procurations;

            dgvProcurations.Columns["Id"].DisplayIndex = 0;
            dgvProcurations.Columns["FinanciranjeId"].DisplayIndex = 1;
            dgvProcurations.Columns["Realizirano"].DisplayIndex = 2;
            dgvProcurations.Columns["Datum"].DisplayIndex = 3;
            dgvProcurations.Columns["ZaposlenikId"].DisplayIndex = 4; //koji stupac je za kaj
            dgvProcurations.Columns["Klasa"].DisplayIndex = 5;
            dgvProcurations.Columns["Ur_broj"].DisplayIndex = 6;
            dgvProcurations.Columns["Opis_predmeta_nabave"].DisplayIndex = 7;
            dgvProcurations.Columns["p1_ponuditelj"].DisplayIndex = 8;
            dgvProcurations.Columns["p1_cijena"].DisplayIndex = 9;
            dgvProcurations.Columns["p1_odabrano"].DisplayIndex = 10;
            dgvProcurations.Columns["p2_ponuditelj"].DisplayIndex = 11;
            dgvProcurations.Columns["p2_cijena"].DisplayIndex = 12;
            dgvProcurations.Columns["p2_odabrano"].DisplayIndex = 13;
            dgvProcurations.Columns["Br_projekta"].DisplayIndex = 14;
            dgvProcurations.Columns["Naziv_projekta"].DisplayIndex = 15;
            dgvProcurations.Columns["Dodatna_pojasnjenja"].DisplayIndex = 16;


        }

        private void dgvProcurations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGotoInput_Click(object sender, EventArgs e)
        {
            FrmInput frmUnesi = new FrmInput();
            Hide();
            frmUnesi.ShowDialog();
            Close();
        }
    }
}
