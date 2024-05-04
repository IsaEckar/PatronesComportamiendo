namespace Strategy
{
    public class SistemaCobranza
    {
        private IEstrategiaCalculoPrecios _estrategiaCalculoPrecios;

        // Constructor que recibe la estrategia de cálculo de precios a utilizar
        public SistemaCobranza(IEstrategiaCalculoPrecios estrategiaCalculoPrecios)
        {
            _estrategiaCalculoPrecios = estrategiaCalculoPrecios;

        }
        // Método para calcular el precio final utilizando la estrategia
        public double CalcularPrecioFinal(double precio)
        {
            return _estrategiaCalculoPrecios.Calcularprecio(precio);
        }
    }
}
