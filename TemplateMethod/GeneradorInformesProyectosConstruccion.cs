namespace TemplateMethod
{
    public class GeneradorInformesProyectosConstruccion : GeneradorInformesProyecto
    {
        protected override void GenerarContenidoEspecificoProyecto()
        {
            Console.WriteLine("Detalles de la Construcción: "); 
            Console.WriteLine("Material Utilizado: Cemento, Varilla, Piedra, Arena.. Hormigón"); 
            Console.WriteLine("Área: 1000 Metros Cuadrados");
        }
    }
}
