namespace espacioPersonajes;

class Personajes {

    private int velocidad;//1 a 10
    private int destreza;//1 a 5
    private int fuerza;//1 a 10
    private int nivel;//1 a 10
    private int armadura;//1 a 10
    private int salud;//100
    


    private string? tipo;
    private string? apodo;
    private DateTime fechaDeNacimiento;
    private int edad;
    private string[] tiposPersonaje;
    private string[] apodosPersonaje;

   

    public Personajes(int velocidad, int destreza, int fuerza, int nivel, int armadura, string? tipo, string? apodo, DateTime fechaDeNacimiento)
    {
        this.velocidad = velocidad;
        this.destreza = destreza;
        this.fuerza = fuerza;
        this.nivel = nivel;
        this.armadura = armadura;
        this.salud = 100;
        this.tipo = tipo;
        this.apodo = apodo;
        this.fechaDeNacimiento = fechaDeNacimiento;
        string[] tipos = {"Mago", "Tanque", "Tirador", "Soporte", "Combatiente"};
        string[] apodos = {"Goku", "Vegeta", "Julio", "Otro", "Otro 2"};
        this.tiposPersonaje = tipos;
        this.apodosPersonaje = apodos;
        this.edad = Edad;
        
    }

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => fuerza; set => fuerza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armadura { get => armadura; set => armadura = value; }
    public int Salud { get => salud; set => salud = value; }
    public string? Tipo { get => tipo; set => tipo = value; }
    public string? Apodo { get => apodo; set => apodo = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public int Edad { 
        get {

            var now = DateTime.Now;
            int edad = now.Year - FechaDeNacimiento.Year - 1;

            if(now.Month > FechaDeNacimiento.Month) {
                edad+=1;
            } else if(now.Month == FechaDeNacimiento.Month && now.Day == FechaDeNacimiento.Day) {
                edad+=1;
            }

            return edad;
        }
    }

}
/*
  enum TipoPersonaje {
        
    };

    enum ApodoPersonaje {
       Jorge,
       Ale,
       Raul,
       Julio,
       Vegeta,
       Goku
    };
    */