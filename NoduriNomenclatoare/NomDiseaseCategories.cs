using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
   public  class NomDiseaseCategories:TemporalNomBaseDescription
    {
        public bool IsChronicDisease { get; set; }
        public bool IsAuctioned { get; set; }
    }
}
