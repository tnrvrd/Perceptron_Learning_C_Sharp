using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Melez_Sistemler_Proje_2
{
    public class DataPoint
    {
        public List<double> ListInputs { get; set; }
        public double Output { get; set; }

        public DataPoint()
        {
            ListInputs = new List<double>();
        }
    }
}
