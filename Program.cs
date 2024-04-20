using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.tiposdejuegos;

//static void EjemploPolimorfismo()
//{
//    Animal[] animales = new Animal[3];
//    animales[0] = new Tortuga();
//    animales[1] = new Gato();
//    animales[2] = new Perro();
//    foreach (Animal animal in animales)
//    {
//        animal.HacerSonido();
//    }
//}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 8;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

Valorant valo = new Valorant();
valo.Titulo = "Valorant";
valo.Desarrolladora = "Riot Games";
valo.Calificacion = 8;
valo.AnioLanzamiento = 2020;
valo.MostrarInformacion();
valo.ElegirMapa();
valo.comprararma();



Console.ReadLine();

//Laboratorio();+
// VideoJuego.listaDeJuegos();



