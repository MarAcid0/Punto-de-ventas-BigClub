public class Cliente
{
    public int IdCliente { get; set; }
    public string Documento { get; set; }
    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public bool Estado { get; set; }
    public string FechaRegistro { get; set; } // Considera usar DateTime
    public string Puntos { get; set; } // Nueva propiedad agregada
}
