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

        private String name;
        private int code;
        private String description;
        private String lastModified;
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
        public String LastModified {
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
                if (isDown)
                {
                    isDown = false;
                }
                else {
                    isDown = true;
                }
            }
        }
        #endregion



    }


}
