using Observer;

DatosMeteorologicos datosMeteorologicos = new DatosMeteorologicos();


DispositivoDeVisualizacion dispositivo1 = new DispositivoDeVisualizacion();
DispositivoDeVisualizacion dispositivo2 = new DispositivoDeVisualizacion();


datosMeteorologicos.RegistrarObservador(dispositivo1);
datosMeteorologicos.RegistrarObservador(dispositivo2);

Console.WriteLine("Dispositivo 1 y dispositivo 2");
Console.WriteLine("");
Console.WriteLine("Primer Reporte a los dispositivos:");
datosMeteorologicos.ActualizarClima("Dia Soleado");
Console.WriteLine("");
//Cambio de clima, se debe actualizar y notificar a los demas dospositivos
Console.WriteLine("Segundo Reporte actualizado a los dispositivos:");
datosMeteorologicos.ActualizarClima("Tormenta Electriaca");
