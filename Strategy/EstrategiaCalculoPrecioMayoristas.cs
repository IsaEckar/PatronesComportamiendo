namespace Strategy
{
    public class EstrategiaCalculoPrecioMayoristas : IEstrategiaCalculoPrecios
    {
        public double Calcularprecio(double precio)
        {
            if(precio < 100000)
            {
                return (precio * 0.95); // Descuento del 5% para compras menores a $100000
            }
            else
            {
                return (precio * 0.90); // Descuento del 10% para compras de $100000 o más
            }
        }
    }
}
