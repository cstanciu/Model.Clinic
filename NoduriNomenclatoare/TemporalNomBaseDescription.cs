using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
    public class TemporalNomBaseDescription : NomenclatureBaseDescription
    {
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
