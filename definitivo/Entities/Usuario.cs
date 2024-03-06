namespace definitivo.Entities
{
    public class Usuario
    {
        public long Id_Usuario { get; set; }
        public string? correo { get; set; }
        public string? contrasena { get; set; }
        public string? nombre { get; set; }
        public bool Estado { get; set; }
        public string? Token { get; set; }
        public bool EsTemporal { get; set; }
    }

    public class UsuarioRespuesta
    {
        public string? Codigo { get; set; }
        public string? Mensaje { get; set; }
        public Usuario? Dato { get; set; }
        public List<Usuario>? Datos { get; set; }
    }
}
