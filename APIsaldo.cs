public class Nodo
{
    public TarjetaCredito Tarjeta { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(TarjetaCredito tarjeta)
    {
        Tarjeta = tarjeta;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo cabeza;

    public void AgregarTarjeta(TarjetaCredito tarjeta)
    {
        Nodo nuevoNodo = new Nodo(tarjeta);
        nuevoNodo.Siguiente = cabeza;
        cabeza = nuevoNodo;
    }

    public double ConsultarSaldo(int numeroTarjeta)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Tarjeta.NumeroTarjeta == numeroTarjeta)
                return actual.Tarjeta.Saldo;
            actual = actual.Siguiente;
        }
        return -1; // Si no se encuentra la tarjeta
    }
}
