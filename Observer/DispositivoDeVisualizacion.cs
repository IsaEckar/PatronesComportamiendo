namespace Observer
{
    public class DispositivoDeVisualizacion : IObservador
    {
        public void Actualizar(string datosMeteorologicos)
        {
          
            Console.WriteLine("Nuevo reporte Meteorológico: " + datosMeteorologicos);
        }
    }
}
