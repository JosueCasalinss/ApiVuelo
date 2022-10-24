using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiVuelo.Core.Entidad
{
    public partial class Vuelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? Fecha { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public int? Valor { get; set; }
        public string  CodigoReserva { get; set; } 
        public int? CantidadPasajeros { get; set; }
    }
}
