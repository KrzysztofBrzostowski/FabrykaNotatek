using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabrykaNotatek.Fabryki
{
    public class FabrykaZNazwaUzytkownika : IFabrykaAbstrakcyjnaNotatek
    {
        public Notatka WyprodukujNotatke(string tresc)
        {

            var n = new Notatka();
            n.naglowek = string.Format("{0}: {1}...", Environment.UserName , tresc.Substring(0, 5));
            n.DataUtworzenia = n.DataModyfikacji = DateTime.Now;
            n.tresc = tresc.ToLower();
            return n;

        }

        public void ZmienTresc(string tresc, Notatka notatkaDoZmiany)
        {
            //throw new NotImplementedException();
        }
    }
}
