using System.Text.Json.Serialization; 
//using PrubePolsheta.API.Models;

namespace PrubePolsheta.API.Models;   

public class Persona { 
    
    public int Id { get; set; } 

    public string Nombre { get; set; } = ""; 

    [JsonIgnore] 

    public string TarjetaDeCredito { get; set; } = ""; 
    
    public bool Casado { get; set; } 

    public DateTime FechaNacimiento { get; set; } 

    public int Edad { 
        get { 
            int edad; 
            DateTime hoy = DateTime.Today;  
            edad = hoy.Year - FechaNacimiento.Year; 
            return edad;        
        }    
    } 
}