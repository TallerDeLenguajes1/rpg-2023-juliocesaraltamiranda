using espacioPersonajes;
using System.Text.Json;

namespace espacioPersonajesJson;
class PersonajesJson {

    public PersonajesJson() {

    }

    public void GuardarPersonajes(List<Personajes> Personajes, string? nombreArchivo) {


        var json = JsonSerializer.Serialize(Personajes);
        if(nombreArchivo != null) {
            File.WriteAllText(nombreArchivo, json);
        }
        
    }

    public void ListarPersonajes(List<Personajes> Personajes, string? nombreArchivo) {

        if(nombreArchivo !=null) {

            /*
               
            Console.WriteLine("Velocidad: "+p.Velocidad);
            Console.WriteLine("Destreza: "+ p.Destreza);
            Console.WriteLine("Fuerza: "+ p.Fuerza);
            Console.WriteLine("Nivel: "+ p.Nivel);
            Console.WriteLine("Armadura: "+ p.Armadura);
            Console.WriteLine("Salud: "+ p.Salud);
            Console.WriteLine("Tipo: "+ p.Tipo);
            Console.WriteLine("Apodo: "+ p.Apodo);
            Console.WriteLine("FechaDeNacimiento: "+ p.FechaDeNacimiento);
            Console.WriteLine("Edad: "+ p.Edad);*/
        
            
        }
        
    }
}