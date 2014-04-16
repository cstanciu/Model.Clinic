using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
    public class NomClinicServices:TemporalNomBaseName
    {
        public string serviceGroup { get; set; }
        public bool isExam { get; set; }
        public bool opRoom { get; set; }
        public bool isConnectedService { get; set; }
    }
}
