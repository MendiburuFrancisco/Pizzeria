using System;
using Builder;
using Producto;
using BuilderConcreto;

namespace Director
{
    // Director
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void CocinarPizzaPasoAPaso()
        {
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAñadirSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
        }

        public Pizza PizzaPreparada
        {
            get { return _pizzaBuilder.ObtenerPizza(); }

        }
    }
}
 //}
