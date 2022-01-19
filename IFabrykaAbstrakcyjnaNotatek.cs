using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabrykaNotatek
{
    interface IFabrykaAbstrakcyjnaNotatek
    {

        Notatka WyprodukujNotatke(string tresc);
        void ZmienTresc(string tresc,Notatka notatkaDoZmiany);

    }
}
