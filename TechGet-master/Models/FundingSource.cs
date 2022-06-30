using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGet.Models
{
    public class FundingSource
    {
        public int Id { get; set; }
        public float Iznos { get; set; }

        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }


    }


}
