
namespace TemplateMethod
{
    public abstract class  GeneradorInformesProyecto
    {
        public void GenerarInforme()
        {
            Console.WriteLine("--- Generando Informe para el Proyecto ---");
            GenerarContenidoEspecificoProyecto();
            Console.WriteLine("Informe Generado Exitosamente.");

        }

        //Metodo abastracto que sera implementado en las subclases
        protected abstract void GenerarContenidoEspecificoProyecto();
    }
}
