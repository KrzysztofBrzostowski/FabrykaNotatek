using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabrykaNotatek.Fabryki
{
    public class FabrykaZDataICzasem : IFabrykaAbstrakcyjnaNotatek
    {
        Notatka IFabrykaAbstrakcyjnaNotatek.WyprodukujNotatke(string tresc)
        {
            var n = new Notatka();
            n.naglowek = string.Format("{0}: {1}...", DateTime.Now, tresc.Substring(0, 5));
            n.DataUtworzenia = n.DataModyfikacji = DateTime.Now;
            n.tresc = tresc.ToUpper();
            return n;

            //throw new NotImplementedException();
        }

        void IFabrykaAbstrakcyjnaNotatek.ZmienTresc(string tresc, Notatka notatkaDoZmiany)
        {
            //throw new NotImplementedException();
        }
    }
}
