public class ColaNotificaciones
{
    private Queue<string> colaNotificaciones = new Queue<string>();

    public void AgregarNotificacion(string notificacion)
    {
        colaNotificaciones.Enqueue(notificacion);
    }

    public string ObtenerSiguienteNotificacion()
    {
        if (colaNotificaciones.Count > 0)
        {
            return colaNotificaciones.Dequeue();
        }
        else
        {
            return "No hay notificaciones pendientes.";
        }
    }
}
