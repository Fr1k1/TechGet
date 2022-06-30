using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGet.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Korisnicko_ime { get; set; }

        public string Lozinka { get; set; }

        public string UlogeId { get; set; } //tu bu se moralo promijeniti na uloge da je tip




        public override string ToString()
        {
            return FirstName+" "+ LastName;
        }

        public bool CheckPassword(string password)
        {
            return Lozinka == password;
        }
    }
}
