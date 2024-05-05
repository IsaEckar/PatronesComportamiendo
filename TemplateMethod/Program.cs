using TemplateMethod;

GeneradorInformesProyecto generadorInformesConstruccion = new GeneradorInformesProyectosConstruccion();
generadorInformesConstruccion.GenerarInforme();

Console.WriteLine();

GeneradorInformesProyecto softwareGeneradorInformes = new GeneradorInformesProyectosSoftware();
softwareGeneradorInformes.GenerarInforme();