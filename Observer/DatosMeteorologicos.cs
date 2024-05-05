
namespace Observer
{
    public class DatosMeteorologicos : IProveedorDeDatos
    {
        private List<IObservador> observadores;
        private string climaActual;

        public DatosMeteorologicos()
        {
            observadores = new List<IObservador>();
        }
        public void RegistrarObservador(IObservador observador)
        {
          
           observadores.Add(observador);
           
        }
        public void EliminarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }
        public void NotificarObservadores()
        {
          foreach(var observador in observadores)
            {
                observador.Actualizar(climaActual);
            }
        }
       
        public void ActualizarClima(string nuevoClima)
        {
            climaActual = nuevoClima;
            NotificarObservadores();
        }

    

   
    }
}
