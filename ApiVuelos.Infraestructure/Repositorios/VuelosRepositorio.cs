using ApiVuelo.Core.Entidad;
using ApiVuelo.Core.Interfaz;
using ApiVuelo.Infraestructure.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiVuelo.Infraestructure.Repositorios
{
    public class VuelosRepositorio : IVuelosRepositorio
    {
        private readonly VuelosContext _context;

        public VuelosRepositorio(VuelosContext context)
        {
            _context = context;
        }


        public async Task<List<Vuelo>> MostrarVuelos()
        {
            return await _context.Vuelo.ToListAsync();

        }

        public async Task<Vuelo> Buscarvuelo(int id)
        {
            var vueloAsync = await _context.Vuelo.ToListAsync();
            Vuelo vuelo = vueloAsync.FirstOrDefault(vuelo => vuelo.Id == id);

            return vuelo;

        }

        

        public async  Task<Vuelo> BuscarCodigo(string Codigo)
        {
            var vueloAsync = await _context.Vuelo.ToListAsync();
            Vuelo vuelo = vueloAsync.FirstOrDefault(vuelo => vuelo.CodigoReserva  == Codigo);

            return vuelo;
        }


        public string CrearCodigo()
        {
            int longitud = 6;
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "");
            token = token.Substring(0, longitud);

            return token;

        }
        

        public async Task<string> AdicionarVuelo(Vuelo vuelo)
        {
            _context.Vuelo.Add(vuelo);
            await _context.SaveChangesAsync();

            return "Se a adicionado una nota";
        }

        public async Task<string> ActualizarVuelo(Vuelo vuelo)
        {
            _context.Vuelo.Update(vuelo);
            await _context.SaveChangesAsync();

            return "Su dato se a actalizado correctamente";
        }

        public async Task<string> EliminarVuelo(int id)
        {
            var vueloAsync = await _context.Vuelo.ToListAsync();
            Vuelo vuelo =vueloAsync.FirstOrDefault(vuelo => vuelo.Id == id);
            _context.Vuelo.Remove(vuelo);
            await _context.SaveChangesAsync();

            return "Se a eliminado correctamente";

        }



    }
}
