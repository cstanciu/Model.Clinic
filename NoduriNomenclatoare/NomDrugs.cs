using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
   public class Drugs:TemporalNomBaseName
    {
        public string presentationMode { get; set; }
        public short isNarcotic { get; set; }
        public bool isFractional { get; set; }
        public bool isSpecial { get; set; }
        public bool isBrand { get; set; }
        public bool hasBioEchiv { get; set; }
        public int qtyPerPackage { get; set; }
        public float pricePerPackage { get; set; }
        public float wholeSalePricePerPackage { get; set; }
        public string prescriptionMode { get; set; }
        public string activeSubstance { get; set; }
        public string concentration { get; set; }
        public string pharmaceuticalForm { get; set; }
        public string company { get; set; }
        public string country { get; set; }
        public string atc { get; set; }
   }
}


