using definitivo.Entities;

namespace definitivo.Services
{
    public interface IUsuarioModel
    {
        Respuesta? RegistrarUsuario(Usuario entidad);

        UsuarioRespuesta? IniciarSesion(Usuario entidad);

        UsuarioRespuesta? RecuperarAcceso(Usuario entidad);
    }
}
