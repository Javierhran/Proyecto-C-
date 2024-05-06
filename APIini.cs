using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

public class CargaInicial
{
    public List<TarjetaCredito> CargarDesdeJSON(string path)
    {
        List<TarjetaCredito> tarjetas = new List<TarjetaCredito>();
        string json = File.ReadAllText(path);
        tarjetas = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);
        return tarjetas;
    }
}
