using PrototipoVentas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrototipoVentas.ViewModel
{
    class ArticuloViewModel 
    {

        public ObservableCollection<Articulo> Articulos {
            get;
            set;
        }

        public void LoadArticulos() { 
        ObservableCollection<Articulo> articulo = new ObservableCollection<Articulo>();
            
            Articulos = articulo;
        }
    }
}
