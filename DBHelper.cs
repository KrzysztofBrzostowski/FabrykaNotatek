using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace FabrykaNotatek
{
    public class DBHelper
    {
        
        DBNotatkiEntities5 m_DBNotatki = new DBNotatkiEntities5();

        public DBHelper()
        {

        }

        public void zapiszKolekcjeNotatek(IList<Notatka> kolekcja)
        {

            //m_DBNotatki.DeleteDatabase();


            foreach (var item in kolekcja)
            {
                NotatkaEncja ne = new NotatkaEncja();
                ne.id = Guid.NewGuid();
                ne.notatka = item.tresc;
                ne.dataUtworzenia = item.DataUtworzenia;
                ne.dataModyfikacji = item.DataModyfikacji;

                m_DBNotatki.NotatkaEncjas.AddObject(ne);

                m_DBNotatki.SaveChanges();

            }


        }

        public IList<Notatka> WczytajKolekcje()
        {
            ObservableCollection<Notatka> retList = new ObservableCollection<Notatka>();

            foreach (var item in m_DBNotatki.NotatkaEncjas)
            {
                var n = new Notatka()
                {
                    DataUtworzenia = item.dataUtworzenia.Value,
                    tresc = item.notatka,
                    DataModyfikacji = item.dataModyfikacji.Value,
                    naglowek = item.notatka.Substring(0, 6) + "..."
                };

                retList.Add(n);

            }
            
            return retList;
        }


    }
}
