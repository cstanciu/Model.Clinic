using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
   public class NomSickLeaveIndemnizations:TemporalNomBaseDescription
    {
        public string IndemnizationGroup { get; set; }
        public int Percent { get; set; }
        public bool isTaxable { get; set; }
        public bool mustHaveStage { get; set; }
    
    }
}
