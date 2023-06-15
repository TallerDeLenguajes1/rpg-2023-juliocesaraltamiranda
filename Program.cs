using espacioFabricaDePersonajes;
using espacioPersonajesJson;

class Program {
    public static void Main(string[] args) {
        var fp = new FabricaDePersonajes();
        var pj = new PersonajesJson();
        var listaP = fp.listaPersonajes(3);
        pj.GuardarPersonajes(listaP, "hola.json");
        pj.ListarPersonajes(listaP, "hola.json");
    }
}