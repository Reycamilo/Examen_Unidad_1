using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/matematicas")]
    [ApiController]
    public class MatematicasController : ControllerBase
    {
    
        [HttpGet("tabla/{numero}")]
        public IActionResult GenerarTabla(int numero, int hasta = 10)
        {
            
            // hago las validaciones
            if (numero <= 0)
                return BadRequest(new { Message = "El número debe ser mayor a 0" });
            
            
            
            // genero una tabla con
            var tabla = new List<string>();
            

            // genero las multiplicaciones y las guardo en un string
            for (int i = 1; i <= hasta; i++)
            {
                int resultado = numero * i;   
                string linea = $"{numero} x {i} = {resultado}";
                tabla.Add(linea);
            }
            
            
            var respuesta = new TablaEntity
            {
                numero = numero,
                hasta = hasta,
                tabla = tabla
            };
            
            return Ok(respuesta);
        }
    }
}