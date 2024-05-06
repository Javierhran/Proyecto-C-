using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancia de CargaInicial y cargar datos desde un archivo JSON
        CargaInicial cargaInicial = new CargaInicial();
        List<TarjetaCredito> tarjetas = cargaInicial.CargarDesdeJSON("datos.json");

        // Crear instancia de ListaEnlazada y agregar tarjetas para probar la consulta de saldo
        ListaEnlazada listaSaldo = new ListaEnlazada();
        foreach (var tarjeta in tarjetas)
        {
            listaSaldo.AgregarTarjeta(tarjeta);
        }

        // Consultar saldo de una tarjeta específica
        int numeroTarjetaConsulta = 123456789; // Número de tarjeta a consultar
        double saldo = listaSaldo.ConsultarSaldo(numeroTarjetaConsulta);
        Console.WriteLine($"Saldo de la tarjeta {numeroTarjetaConsulta}: {saldo}");

        // Crear instancia de ColaPagos y agregar pagos para procesar
        ColaPagos colaPagos = new ColaPagos();
        colaPagos.AgregarPago(123456789, 100.0);
        colaPagos.AgregarPago(987654321, 50.0);

        // Procesar pagos
        colaPagos.ProcesarPagos(tarjetas);

        // Consultar saldo nuevamente después de procesar pagos
        saldo = listaSaldo.ConsultarSaldo(numeroTarjetaConsulta);
        Console.WriteLine($"Nuevo saldo de la tarjeta {numeroTarjetaConsulta} después de pagos: {saldo}");

        // Continuar con más pruebas de las APIs según sea necesario...
    }
}
