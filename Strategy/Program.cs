using Strategy;

//Se crea la instancia del sistema de facturacion clientes Minoristas
var estrategiaCalculoPrecioMinorista = new SistemaCobranza(new EstrategiaCalculoPrecioMinoristas());


// Calcular el precio final para un producto con precio base de $200.000
double ventaMenorPrecioFinal = estrategiaCalculoPrecioMinorista.CalcularPrecioFinal(200000);
Console.WriteLine("El Precio Final del Producto para el cliente Minorista: $" + ventaMenorPrecioFinal);
Console.WriteLine("");

// Crear una instancia del sistema de facturación para clientes mayoristas
var estrategiaCalculoPrecioMayoristas = new SistemaCobranza(new EstrategiaCalculoPrecioMayoristas());

// Calcular el precio final para un producto con precio base de $200.000
double mayoristaPrecioFinal = estrategiaCalculoPrecioMayoristas.CalcularPrecioFinal(200000);
Console.WriteLine("El Precio Final del Producto para el cliente Mayorista: $" + mayoristaPrecioFinal);