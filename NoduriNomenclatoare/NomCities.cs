using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
   public class NomCities:NomenclatureBaseName
    {
        public int CityType { get; set; }
        public string District { get; set; } //relationship
    }

}
