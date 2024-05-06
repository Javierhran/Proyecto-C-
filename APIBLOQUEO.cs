public class ArbolBloqueo
{
    private NodoArbol raiz;

    public void InsertarBloqueo(TarjetaCredito tarjeta)
    {
        raiz = InsertarBloqueoRecursivo(raiz, tarjeta);
    }

    private NodoArbol InsertarBloqueoRecursivo(NodoArbol nodo, TarjetaCredito tarjeta)
    {
        if (nodo == null)
        {
            return new NodoArbol(tarjeta);
        }

        if (tarjeta.NumeroTarjeta < nodo.Tarjeta.NumeroTarjeta)
        {
            nodo.Izquierda = InsertarBloqueoRecursivo(nodo.Izquierda, tarjeta);
        }
        else if (tarjeta.NumeroTarjeta > nodo.Tarjeta.NumeroTarjeta)
        {
            nodo.Derecha = InsertarBloqueoRecursivo(nodo.Derecha, tarjeta);
        }

        return nodo;
    }

   
}
