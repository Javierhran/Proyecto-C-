public class ColaPagos
{
    private Queue<(int NumeroTarjeta, double Monto)> colaPagos = new Queue<(int, double)>();

    public void AgregarPago(int numeroTarjeta, double monto)
    {
        colaPagos.Enqueue((numeroTarjeta, monto));
    }

    public void ProcesarPagos(List<TarjetaCredito> tarjetas)
    {
        while (colaPagos.Count > 0)
        {
            var pago = colaPagos.Dequeue();
            foreach (var tarjeta in tarjetas)
            {
                if (tarjeta.NumeroTarjeta == pago.NumeroTarjeta)
                {
                    tarjeta.Saldo -= pago.Monto;
                   
                    break;
                }
            }
        }
    }
}
