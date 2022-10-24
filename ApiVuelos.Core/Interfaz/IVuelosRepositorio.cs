using ApiVuelo.Core.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVuelo.Core.Interfaz
{
    public interface IVuelosRepositorio
    {

        Task<List<Vuelo>> MostrarVuelos();

        Task<Vuelo> Buscarvuelo(int id);

        Task<string> AdicionarVuelo(Vuelo vuelo);

        Task<string> ActualizarVuelo(Vuelo vuelo);

        Task<string> EliminarVuelo(int id);

        Task<Vuelo> BuscarCodigo(string Codigo);

        string CrearCodigo();

    }
}
