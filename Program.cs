using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.tiposdejuegos;

using LaboratorioProgra1.Laboratorio;
using System;

namespace LaboratorioProgra1.tiposdejuegos
{
    class Program
    {
        static void Main(string[] args)
        {

            Shooter shoote = new Shooter();
            shoote.Titulo = "Valorant";
            shoote.Desarrolladora = "Riot Games";
            shoote.Calificacion = 8;
            shoote.AnioLanzamiento = 2020;
            shoote.realista = true;
            shoote.ModoDeJuego = "5v5";
            Console.WriteLine($"{shoote.MostrarDetallesShooter()}");
            Console.WriteLine(shoote.ElegirMapa());
            Console.WriteLine(shoote.comprararma());
            Console.WriteLine("");
            Aventura ave = new Aventura();
            ave.Titulo = "Shadows of the Tomb Raider";
            ave.Desarrolladora = "Eidos Montreal";
            ave.Calificacion = 9;
            ave.AnioLanzamiento = 2018;
            ave.personajepricipal = "Lara Croft";
            ave.Duracion = "De 15 a 24 horas";
            Console.WriteLine($"{ave.MostrarDetallesAventura()}");
            Console.WriteLine("Ingresa el numero para elegir la dificultad: \n1.Facil  \n2.Media  \n3.Dificil");
            Console.WriteLine(ave.Seleccionardifucultad());
            Console.WriteLine("Ingresa el numero para elegir el arma a equipar: \n1.Arco  \n2.Piolet  \n3.Machete");
            Console.WriteLine(ave.elegirarma());
            Console.WriteLine("");
            Deportes dep = new Deportes();
            dep.Titulo = "EAFC 2024";
            dep.Desarrolladora = "EA SPORTS";
            dep.Calificacion = 9;
            dep.AnioLanzamiento = 2023;
            dep.Deporte = "Futbol";
            dep.LicenciasOficiales = "La liga";
            Console.WriteLine($"{dep.MostrarDetallesDeporte()}");
            Console.WriteLine(dep.inipartido());
            Console.WriteLine(dep.falta());

            Console.ReadLine();
        }
    }
}

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

//static void Laboratorio()
//{
//    VideoJuego videoJuego = new VideoJuego();
//    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
//    videoJuego.Desarrolladora = "Nintendo";
//    videoJuego.Calificacion = 8;
//    videoJuego.AnioLanzamiento = 2017;
//    videoJuego.MostrarInformacion();
//}

//Shooter shoote = new Shooter();
//shoote.Titulo = "Valorant";
//shoote.Desarrolladora = "Riot Games";
//shoote.Calificacion = 8;
//shoote.AnioLanzamiento = 2020;
//shoote.MostrarDetallesShooter();
//shoote.ElegirMapa();
//shoote.comprararma();



//Console.ReadLine();

////Laboratorio();+
//// VideoJuego.listaDeJuegos();


