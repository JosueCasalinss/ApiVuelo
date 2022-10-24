using ApiVuelo.Core.Entidad;
using ApiVuelo.Core.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVuelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VuelosController : ControllerBase
    {


        private readonly IVuelosRepositorio _vueloRepositorio;

        public VuelosController(IVuelosRepositorio vueloRepositorio)
        {
            _vueloRepositorio = vueloRepositorio;
        }



        [HttpGet]

        public async Task<IActionResult> GetVuelos()
        {
            return Ok(await _vueloRepositorio.MostrarVuelos());
        }


        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetBuscar(int id)
        //{

        //    return Ok( await _vueloRepositorio.Buscarvuelo(id));
        //}


        [HttpGet("{codigo}")]

        public async Task<IActionResult> GetCodigo(string codigo)
        {
            return Ok(await _vueloRepositorio.BuscarCodigo(codigo));
        }





        [HttpPost]

        public async Task<IActionResult> PostVuelo(Vuelo vuelo)
        {
            return Ok(await _vueloRepositorio.AdicionarVuelo(vuelo));
        }

        [HttpPost("codigo")]
        public async Task<IActionResult> PostCodigo([FromBody] Vuelo vuelo)
        {

            vuelo.CodigoReserva = _vueloRepositorio.CrearCodigo();
            return Ok(await _vueloRepositorio.AdicionarVuelo(vuelo));
        }


        [HttpPut]
        public async Task<IActionResult> PutVuelo(Vuelo vuelo)
        {
            return Ok(await _vueloRepositorio.ActualizarVuelo(vuelo));
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteVuelo(int id)
        {
            return Ok(await _vueloRepositorio.EliminarVuelo(id));
        }







    }
}
