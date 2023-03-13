using Microsoft.AspNetCore.Mvc;
using Test.API.Models;

namespace Test.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
     public TestController() { }
     [HttpGet]
     [Route("saludar")]
      public IActionResult GetSaludar([FromQuery] string nombre) {
       
        string texto;      
        IActionResult resultado;
        if (nombre.Length>2)
        {
          texto = "hola " + nombre;
          resultado = Ok(texto);
         
        }
        else
        {
            resultado = BadRequest() ;
        }
         return resultado;
}
 [HttpGet]
 [Route("persona/{id}")]
 public IActionResult GetPersona([FromRoute] int id)
  {     
    Persona persona = new Persona();
     IActionResult resultado;
     if (id>0)
     {
         persona.Id = id;
         persona.Nombre = "Guillermo Wonka";  
         persona.TarjetaDeCredito = "4556815182996489";
         persona.Casado = false;   
         persona.FechaNacimiento = new DateTime(2003, 07, 13);
         resultado=Ok(persona);
          }
         else
         {
             resultado=BadRequest();
         }
    
      //http://localhost:5239/test/persona/3
         
        
        return resultado;
 }
}