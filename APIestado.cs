public class NodoArbol
{
    public TarjetaCredito Tarjeta { get; set; }
    public NodoArbol Izquierda { get; set; }
    public NodoArbol Derecha { get; set; }

    public NodoArbol(TarjetaCredito tarjeta)
    {
        Tarjeta = tarjeta;
        Izquierda = null;
        Derecha = null;
    }
}

public class ArbolBinarioBusqueda
{
    private NodoArbol raiz;

    public void Insertar(TarjetaCredito tarjeta)
    {
        raiz = InsertarRecursivo(raiz, tarjeta);
    }

    private NodoArbol InsertarRecursivo(NodoArbol nodo, TarjetaCredito tarjeta)
    {
        if (nodo == null)
        {
            return new NodoArbol(tarjeta);
        }

        if (tarjeta.NumeroTarjeta < nodo.Tarjeta.NumeroTarjeta)
        {
            nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, tarjeta);
        }
        else if (tarjeta.NumeroTarjeta > nodo.Tarjeta.NumeroTarjeta)
        {
            nodo.Derecha = InsertarRecursivo(nodo.Derecha, tarjeta);
        }

        return nodo;
    }

}
