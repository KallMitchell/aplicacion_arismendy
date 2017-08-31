using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion_arismendy

{

    class Productos
    {
        private String _Nombre;
        private String _Precio;
        private String _Cantidad;
        private String _Total;
        private String _No;

        public Productos(String nombre,String precio,String cantidad, String total,String no) {
                 this._Nombre = nombre;
                this._Precio = precio;
                this._Cantidad = cantidad;
                this._Total = total;
                this._No = no;
        }

        public String Nombre {
            set { this._Nombre = value; }
            get { return this._Nombre; }
        }
        public String Precio
        {
            set { this._Precio = value; }
            get { return this._Precio; }
        }
        public String Cantidad
        {
            set { this._Cantidad = value; }
            get { return this._Cantidad; }
        }
        public String Total
        {
            set { this._Total = value; }
            get { return this._Total; }
        }
        public String No
        {
            set { this._No = value; }
            get { return this._No; }
        }

    }
}
