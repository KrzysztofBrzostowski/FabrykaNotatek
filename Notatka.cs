using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabrykaNotatek
{
    public class Notatka
    {

        public string naglowek { get; set; }
        public string tresc { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public DateTime DataModyfikacji { get; set; }
        public override string ToString()
        {
            return naglowek + " : " + tresc;
        }

    }
}
