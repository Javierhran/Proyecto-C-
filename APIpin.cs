public class NodoPIN
{
    public TarjetaCredito Tarjeta { get; set; }
    public NodoPIN Siguiente { get; set; }

    public NodoPIN(TarjetaCredito tarjeta)
    {
        Tarjeta = tarjeta;
        Siguiente = null;
    }
}

public class ListaCambioPIN
{
    private NodoPIN cabeza;

    public void AgregarCambioPIN(TarjetaCredito tarjeta)
    {
        NodoPIN nuevoNodo = new NodoPIN(tarjeta);
        nuevoNodo.Siguiente = cabeza;
        cabeza = nuevoNodo;
    }

}
