using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp
{
    public class WetterModel
    {
        [Index(0)]
        public long Id { get; set; }

        [Index(1)]
        public DateTime Tag { get; set; }
        
        [Index(2)]
        public int Stunde { get; set; }

        [Index(3)]
        public char Zr { get; set; }

        [Index(4)]
        public char Typ { get; set; }

        [Index(5)]
        public double L_temp_30 { get; set; }

        [Index(6)]
        public double L_temp_200 { get; set; }

        [Index(7)]
        public double? Taupunkt { get; set; }

        [Index(8)]
        public double? L_feucht_30 { get; set; }

        [Index(9)]
        public double? L_feucht_200 { get; set; }

        [Index(10)]
        public double B_temp_5 { get; set; }

        [Index(11)]
        public double B_temp_20 { get; set; }

        [Index(12)]
        public double? Ns { get; set; }

        [Index(13)]
        public int Benetzung { get; set; }

        [Index(14)]
        public double? Verdunstung { get; set; }
    }
}
