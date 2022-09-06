using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class1;

namespace Class2
{
    public class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        #region get set
        public Producto[] Productos
        {
            get { return this._productos; }            
        }        
        #endregion get set

        #region metodos
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("PRODUCTO");
            sb.Append("\t");
            sb.Append("UBICACION");
            sb.Append("\t");
            for (int i = 0; i < this.Productos.Length; i++) 
            {
                sb.Append(this.Productos[i].ToString());
            }
        }        
        #endregion metodos        
        public static bool operator == (Estante estante, Producto p1)
        {
            bool flag = false;
            if (estante is not null)
            {
                for (int i = 0; i < estante._productos.Length; i++)
                {                
                    if (estante.Productos[i] == p1)
                    {
                     flag = true;
                     break;
                    }
                }
            }
            return flag;            
        }
        public static bool operator !=(Estante estante, Producto p1)
        {
            return !(estante == p1);
        }

        public static bool operator +(Estante estante, Producto p1)
        {
            bool flag = false;
            if (estante != p1)
            {
                for (int i = 0; i < estante._productos.Length; i++)
                {
                    if (estante.Productos[i] is null)
                    {
                        estante.Productos[i] = p1;
                        flag = true;
                        break;
                    }
                }
            }            
            return flag;
        }
        public static bool operator -(Estante estante, Producto p1)
        {
            return !(p1 == marca);
        }

        #region constructores
        public Estante(int cantProducto, int ubicacion)
        {
            _productos = new Producto[cantProducto];
            _ubicacionEstante = ubicacion;
            for (int i = 0; i < cantProducto; i++)
            {
                _productos[i] = null;
            }
        }
        #endregion constructores


    }




}
