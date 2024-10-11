using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CN__Transpaso
    {
        private CD_Transpaso objcd_Transpaso = new CD_Transpaso();

        public DataTable ListarTranspasos()
        {
            return objcd_Transpaso.ListarTranspasos();
        }
        public int RegistrarTranspaso(Transpasos transpaso, out string mensaje)
        {
            return objcd_Transpaso.RegistrarTranspaso(transpaso, out mensaje);
        }
        // Método para verificar si el traspaso ya existe
        public bool ExisteTranspaso(string folio)
        {
            return objcd_Transpaso.ExisteTranspaso(folio);
        }
    }
}
