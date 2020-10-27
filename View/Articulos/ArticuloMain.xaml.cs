using PrototipoVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrototipoVentas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object Depentiente { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            
        }
        #region BTN
        /**
         * Permite ver el listado de los articulos
         */
        private void btn_listar(object sender, RoutedEventArgs e)
        {
            if (!listadoArticulos.IsVisible) {
                listadoArticulos.Visibility = System.Windows.Visibility.Visible;
                AddArticulo.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
        /**
         *Permite ver la vista de añadir un articulo
         */
        private void btn_aniadir(object sender, RoutedEventArgs e)
        {
            if (!AddArticulo.IsVisible) {
                listadoArticulos.Visibility = System.Windows.Visibility.Collapsed;
                AddArticulo.Visibility = System.Windows.Visibility.Visible;
            }
        }
        /**
         * Cierra la ventana cuando se da click al boton de cerrar sesión
         * 
         */
        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
        private void SearchArticles(object sender, RoutedEventArgs e)
        {
            
            bool iva4, iva10, iva21, baja;
            if (Iva4.IsChecked ?? true){
                iva4 = true;
                Console.WriteLine(iva4);
            }
            if (Iva10.IsChecked ?? true)
            {
                iva10 = true;
                Console.WriteLine(iva10);
            }
            if (Iva21.IsChecked ?? true)
            {
                iva21 = true;
                Console.WriteLine(iva21);
            }
            if (bajaSearch.IsChecked ?? true) {
                baja = true;
                Console.WriteLine(baja);
            }
           
        }


        

        
    }
}
