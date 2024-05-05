namespace TemplateMethod
{
    public class GeneradorInformesProyectosSoftware : GeneradorInformesProyecto
    {
        protected override void GenerarContenidoEspecificoProyecto()
        {
            Console.WriteLine("Detalles del Software: ");
            Console.WriteLine("Lenguajes de Programación: C#, Java, Python");
            Console.WriteLine("Frameworks Utilizados: .NET Core, Spring, React, Angular");
        }
    }
}
