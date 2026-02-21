using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/salud")]
    [ApiController]
    public class ImcController : ControllerBase
    {
        [HttpGet("imc")]
        public IActionResult CalcularIMC(double peso, double altura)
        {
            // valido si son numeros positvos
            if (peso <= 0)
                return BadRequest(new { Message = "El peso debe ser mayor a 0"});
            
            if (altura <= 0) 
                 return BadRequest(new {Message = "La altura debe ser mayor a 0"});
                  
            
       
            double imc = peso / (altura * altura);
            
        
            string clasificacion;
            
            if (imc < 18.5)
                clasificacion = "Bajo peso";
            else if (imc >= 18.5 && imc < 25)
                clasificacion = "Normal";
            else if (imc >= 25 && imc < 30)
                clasificacion = "Sobrepeso";
            else
                clasificacion = "Obesidad";
            
            // redonde a dos decimales para que no aparescas muchos.
            imc = Math.Round(imc, 2);
            
            // creo un objeto para ponerlo como resultado.
            var resultado = new ImcEntity
            {
                peso = peso,
                altura = altura,
                imc = imc,
                clasificacion = clasificacion
            };
            
            return Ok(resultado);
        }
    }
}