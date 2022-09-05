using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Producto
    {
        private string _codigoDeBarras;
        private string _marca;
        private float _precio;

        #region get set
        public float Precio
        {
            get { return this._precio; }
            set
            {
                this._precio = Precio;
            }
        }
        public string CodigoDeBarras
        {
            get { return this._codigoDeBarras; }
            set
            {
                this._codigoDeBarras = CodigoDeBarras;
            }
        }
        public string Marca
        {
            get { return this._marca; }
            set
            {
                this._marca = Marca;
            }
        }
        #endregion get set

        #region metodos
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CODIGO DE BARRAS");
            sb.Append("\t");
            sb.Append("MARCA");
            sb.Append("\t");
            sb.Append("Precio");
            sb.Append("\t");
            Console.WriteLine(sb.ToString());
        }
        public void Mostrar(ConsoleColor backColor)
        {
            Console.BackgroundColor = backColor;

            Mostrar();
        }
        public void Mostrar(ConsoleColor backColor, ConsoleColor letra)
        {
            Console.ForegroundColor = letra;
            Mostrar(backColor);
        }
        #endregion metodos

        public static explicit operator string(Producto p1)
        {
            return p1.CodigoDeBarras;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return ((p1.Marca == p2.Marca) && (p1.CodigoDeBarras == p2.CodigoDeBarras));
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string marca)
        {
            return p1.Marca == marca;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }

        #region constructores
        public Producto(String codigoDeBarras)
        {
            _codigoDeBarras = codigoDeBarras;
            _marca = "";
            _precio = 0;
        }
        public Producto(string codigoDeBarras, string marca) : this(codigoDeBarras)
        {
            _marca = marca;
            _precio = 0;
        }

        public Producto(string codigoDeBarras, string marca, float precio) : this(codigoDeBarras, marca)
        {
            _precio = precio;
        }
        #endregion constructores


    }
    internal class Class1
    {
        

    }
}
