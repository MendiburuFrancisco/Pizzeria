using System;

namespace Producto
{
    // Producto final
    public class Pizza
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamaño { get; set; }
        public bool EstaDoblada { get; set; }

        public Pizza()
        {

        }
 
        public Pizza(string tamaño, string masa, string salsa, string relleno, bool doblar) : this()
        {
            Tamaño = tamaño;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
            EstaDoblada = doblar;
        }
    }

}
