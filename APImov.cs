public class PilaMovimientos
{
    private Stack<string> movimientos = new Stack<string>();

    public void AgregarMovimiento(string movimiento)
    {
        movimientos.Push(movimiento);
    }

    public string ConsultarUltimoMovimiento()
    {
        if (movimientos.Count > 0)
        {
            return movimientos.Peek();
        }
        else
        {
            return "No hay movimientos.";
        }
    }
}
