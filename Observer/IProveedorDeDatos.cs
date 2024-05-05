namespace Observer
{
    public interface IProveedorDeDatos
    {
      void RegistrarObservador(IObservador observador);
      void EliminarObservador(IObservador observador);
      void NotificarObservadores();

    }
}
