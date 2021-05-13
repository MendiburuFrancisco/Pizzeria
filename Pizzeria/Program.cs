using System;
using Producto;
using BuilderConcreto;
using Director;
using Builder;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            var cocina = new Cocina();

            // un cliente pide una Pizza cuatro quesos familiar
            cocina.RecepcionarProximaPizza(new CuatroQuesosBuilder("Familiar"));
            cocina.CocinarPizzaPasoAPaso();
            var pizzaCuatroQuesos = cocina.PizzaPreparada;


            // otro cliente pide una Hawaiana
            cocina.RecepcionarProximaPizza(new HawaianaBuilder("Mediana"));
            cocina.CocinarPizzaPasoAPaso();
            var pizzaHawaiana = cocina.PizzaPreparada;
 
        }
 
    }
}
