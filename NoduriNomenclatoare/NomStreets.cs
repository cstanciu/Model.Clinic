using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
   public class NomStreets:NomenclatureBaseName
    {
        public int CityCode { get; set; } //relationship-cities
        public string StreetType { get; set; } //relationship-street type
    }
}
