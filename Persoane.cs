using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_TEST
{
    public class Persoane
    {
        public int id { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }


      

        public string FullInfo
        {
            get
            {
                return $"{Nume} {Prenume} {Email} {Telefon}";

            }
            
        }


    }
}
