using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGet.Models
{
    public class Procuration
    {
        public int Id { get; set; }

        public FundingSource FinanciranjeId { get; set; }


        public int Realizirano { get; set; }

        public string Datum { get; set; }

        public Employee ZaposlenikId { get; set; }

        public int klasa { get; set; }

        public int ur_broj { get; set; }

        public string Opis_predmeta_nabave { get; set; }

        public string p1_ponuditelj { get; set; }

        public float p1_cijena { get; set; }

        public int p1_odabrano { get; set; }

        public string p2_ponuditelj { get; set; }

        public float p2_cijena { get; set; }

        public int p2_odabrano { get; set; }

        public int br_projekta { get; set; }

        public string naziv_projekta { get; set; }

        public string dodatna_pojasnjenja { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }


    }
}
