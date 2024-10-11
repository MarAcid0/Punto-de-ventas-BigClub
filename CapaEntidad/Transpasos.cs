using System;

namespace CapaEntidad
{
    public class Transpasos
    {
        public int idStokSucursal { get; set; }
        public int idProducto { get; set; }
        public int stok { get; set; }
        public int idSucursal { get; set; }
        public int procesado { get; set; }
        public string FOLIO { get; set; }
        public int idSucursalEnvio { get; set; }
        public string NombreProducto { get; set; }
    }
}
