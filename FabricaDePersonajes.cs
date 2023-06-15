namespace espacioFabricaDePersonajes;
using espacioPersonajes;

class FabricaDePersonajes {

    public FabricaDePersonajes() {

    }

    public Personajes crearPersonajes() {

        var random = new Random();

        var Personaje = new Personajes(2, 4, 9, 10, 10, "Asesino", "Goku", new DateTime(2020, 03,12));

        return Personaje;
    }

    public List<Personajes> listaPersonajes(int n) {

        List<Personajes> personajes = new List<Personajes>();

        for(int i=0; i<n; i++) {
            personajes.Add(this.crearPersonajes());
        }

        return personajes;
    }
}
