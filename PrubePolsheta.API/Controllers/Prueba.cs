using Microsoft.AspNetCore.Mvc; 
using PrubePolsheta.API.Models;

namespace PrubePolsheta.API.Controllers; 

    [ApiController] [Route("[controller]")] 

    public class Prueba : ControllerBase 
    {    
        [HttpGet]    [Route("hora")]    
        public DateTime GetHora(){        
            return DateTime.Now;    
        }
        
        [HttpGet]   [Route("Saludar")]
        public IActionResult GetSaludar([FromQuery] string nombre){
            string texto;
            IActionResult resultado;
            if (nombre.Length > 2){
                texto = "Shabat Shalom " + nombre;
                resultado = Ok(texto);
            }else{
                resultado = BadRequest();
            }
            return resultado;
        }

        [HttpGet]   [Route("sumar/{num1}/{num2}")]
        public IActionResult GetSumar([FromRoute] int num1, [FromRoute] int num2){
            int total; 
            IActionResult resultado;
            if (num1 > 0 && num2 > 0){
                total = num1 + num2 + 1;
                resultado = Ok(total);
            }else{
                resultado = BadRequest();
            }
            return resultado;
        }

        [HttpGet]   [Route("persona/{id}")]
        public Persona GetPersona([FromRoute] int id){
            Persona persona = new Persona();
            persona.Id = id;
            persona.Nombre = "Papanamericano";
            persona.TarjetaDeCredito = "0800-0912-6969";
            persona.Casado = false;
            persona.FechaNacimiento = new DateTime(2018, 12, 09);
            return persona;
        }

     
    }