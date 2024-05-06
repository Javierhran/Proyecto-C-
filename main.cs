using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        CargaInicial cargaInicial = new CargaInicial();
        List<TarjetaCredito> tarjetas = cargaInicial.CargarDesdeJSON("datos.json");

      
        ListaEnlazada listaSaldo = new ListaEnlazada();
        foreach (var tarjeta in tarjetas)
        {
            listaSaldo.AgregarTarjeta(tarjeta);
        }

      
        int numeroTarjetaConsulta = 123456789; 
        double saldo = listaSaldo.ConsultarSaldo(numeroTarjetaConsulta);
        Console.WriteLine($"Saldo de la tarjeta {numeroTarjetaConsulta}: {saldo}");

       
        ColaPagos colaPagos = new ColaPagos();
        colaPagos.AgregarPago(123456789, 100.0);
        colaPagos.AgregarPago(987654321, 50.0);


        colaPagos.ProcesarPagos(tarjetas);

       
        saldo = listaSaldo.ConsultarSaldo(numeroTarjetaConsulta);
        Console.WriteLine($"Nuevo saldo de la tarjeta {numeroTarjetaConsulta} después de pagos: {saldo}");

       
    }
}
