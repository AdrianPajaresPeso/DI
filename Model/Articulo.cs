using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoVentas.Model
{
    class Articulo
    {
        #region Atrubutos

        private string name;
        private int code;
        private string description;
        private DateTime lastModified;
        private Boolean isDown;

        #endregion

        #region Getters Y setters
        public string Name {
            get {
                return name;
            } 
            set {
                name = value;
            }
        }

        public int Code {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Description {
            get {
                return description;            
            }
            set
            {
                description = value;
            }
        }
        public DateTime LastModified {
            get
            {
                return lastModified;
            }
            set
            {
                lastModified = value;
            }
            
        }
        public Boolean IsDown
        {
            get
            {
                return isDown;
            }
            set
            {
                if (isDown) { 
                }
            }
        }
        #endregion
    }


}
