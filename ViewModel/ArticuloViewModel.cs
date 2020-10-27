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
        private IList<Articulo> _Articulos;

        public ArticuloViewModel()
        {
            _Articulos = new List<Articulo>
            {
                //new User{UserId = 1,FirstName="Raj",LastName="Beniwal",City="Delhi",State="DEL",Country="INDIA"},
                    
            
            };
        }

        public IList<Articulo> Users
        {
            get { return _Articulos; }
            set { _Articulos = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion

        }
    }
    }
