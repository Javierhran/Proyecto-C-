public class TarjetaCredito
{
    public int NumeroTarjeta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public string Pin { get; set; }
    public bool Bloqueada { get; set; }
    // Puedes agregar más propiedades según sea necesario

    public TarjetaCredito(int numeroTarjeta, string titular, double saldo, string pin)
    {
        NumeroTarjeta = numeroTarjeta;
        Titular = titular;
        Saldo = saldo;
        Pin = pin;
        Bloqueada = false;
    }
}
