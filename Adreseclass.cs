using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_TEST
{
    public class Adreseclass
    {
        public int id { get; set; }

        public string Strada { get; set; }

        public string Numar { get; set; }



        public string FullInfo
        {
            get
            {
                return $"{Strada} {Numar} ";

            }

        }
    }
}
