
namespace Strategy
{
    public class EstrategiaCalculoPrecioMinoristas : IEstrategiaCalculoPrecios
    {
        public double Calcularprecio(double precio)
        {
           return (precio * 0.95);
        }
    }
}
