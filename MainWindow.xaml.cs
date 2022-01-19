using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace FabrykaNotatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IFabrykaAbstrakcyjnaNotatek m_fabryka;
        public ObservableCollection<Notatka> m_KolekcjaNotatek; //{get; set;} // = new ObservableCollection<Notatka>();

        DBHelper m_DBHelper = new DBHelper();

        public MainWindow()
        {
            InitializeComponent();
            listBox1.ItemsSource = m_KolekcjaNotatek;

            m_KolekcjaNotatek = (ObservableCollection<Notatka>)m_DBHelper.WczytajKolekcje() ?? new ObservableCollection<Notatka>();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked.Value)
            {
                m_fabryka = new Fabryki.FabrykaZDataICzasem();
            }
            else
            {
                m_fabryka = new Fabryki.FabrykaZNazwaUzytkownika();
            }

            var nowaNotatka = m_fabryka.WyprodukujNotatke(textBox1.Text);
            m_KolekcjaNotatek.Add(nowaNotatka);


        }

        private void Window_Closed(object sender, EventArgs e)
        {
            m_DBHelper.zapiszKolekcjeNotatek(m_KolekcjaNotatek);
        }


    }
}
