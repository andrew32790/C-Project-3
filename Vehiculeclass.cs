using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_TEST
{
   public class Vehiculeclass
    {
        public int id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string An { get; set; }


        public string Numar { get; set; }



        public string FullInfo
        {
            get
            {
                return $"{Brand} {Model} {An} {Numar} ";

            }

        }

    }
}
