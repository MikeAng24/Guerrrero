using System;

class JuegoRPG
{
    // Variables del personaje
    static int energia = 100;
    static int fuerza = 10;
    static int resistencia = 10;
    static int nivel = 1;
    static int experiencia = 0;
    static bool salir = false;

    static void Main()
    {
        Console.WriteLine("¡Bienvenido al Entrenador RPG!");
        
        while (!salir)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    MostrarEstado();
                    break;
                case "2":
                    EntrenarFuerza();
                    break;
                case "3":
                    EntrenarResistencia();
                    break;
                case "4":
                    PelearEnemigo();
                    break;
                case "5":
                    Dormir();
                    break;
                case "6":
                    salir = true;
                    Console.WriteLine("¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n----- MENÚ -----");
        Console.WriteLine("1. Ver estado");
        Console.WriteLine("2. Entrenar fuerza");
        Console.WriteLine("3. Entrenar resistencia");
        Console.WriteLine("4. Pelear con enemigo");
        Console.WriteLine("5. Dormir");
        Console.WriteLine("6. Salir");
        Console.Write("Elige una opción: ");
    }

    static void MostrarEstado()
    {
        Console.WriteLine("\n--- ESTADO ---");
        Console.WriteLine($"Nivel: {nivel}");
        Console.WriteLine($"Energía: {energia}/100");
        Console.WriteLine($"Fuerza: {fuerza}");
        Console.WriteLine($"Resistencia: {resistencia}");
        Console.WriteLine($"Experiencia: {experiencia}/{nivel * 50}");
    }

    static void EntrenarFuerza()
    {
        int maxHoras = energia / 5;
        if (maxHoras < 1)
        {
            Console.WriteLine("No tienes suficiente energía (mínimo 5)");
            return;
        }

        Console.Write($"¿Cuántas horas entrenarás? (Máx {Math.Min(maxHoras, 6)}): ");
        if (int.TryParse(Console.ReadLine(), out int horas) && horas > 0 && horas <= maxHoras && horas <= 6)
        {
            fuerza += horas * 6;
            energia -= horas * 5;
            experiencia += horas * 2 + 5;
            Console.WriteLine($"¡Ganaste {horas * 6} de fuerza!");
            VerificarNivel();
        }
        else
        {
            Console.WriteLine("Horas no válidas");
        }
    }

    static void EntrenarResistencia()
    {
        int maxHoras = energia / 4;
        if (maxHoras < 1)
        {
            Console.WriteLine("No tienes suficiente energía (mínimo 4)");
            return;
        }

        Console.Write($"¿Cuántas horas entrenarás? (Máx {Math.Min(maxHoras, 6)}): ");
        if (int.TryParse(Console.ReadLine(), out int horas) && horas > 0 && horas <= maxHoras && horas <= 6)
        {
            resistencia += horas * 5;
            energia -= horas * 4;
            experiencia += horas * 2 + 5;
            Console.WriteLine($"¡Ganaste {horas * 5} de resistencia!");
            VerificarNivel();
        }
        else
        {
            Console.WriteLine("Horas no válidas");
        }
    }

    static void PelearEnemigo()
    {
        if (energia < 20)
        {
            Console.WriteLine("Necesitas al menos 20 de energía");
            return;
        }

        Random rnd = new Random();
        int poderEnemigo = nivel * 10 + rnd.Next(5, 15);
        int miPoder = (fuerza + resistencia) / 2;
        
        energia -= 20;
        
        if (miPoder > poderEnemigo)
        {
            experiencia += 40;
            Console.WriteLine("¡Ganaste la pelea! +40 EXP");
        }
        else
        {
            experiencia += 15;
            Console.WriteLine("Perdiste... pero ganaste 15 EXP");
        }
        
        VerificarNivel();
    }

    static void Dormir()
    {
        energia = 100;
        Console.WriteLine("Energía recuperada al 100%");
    }

    static void VerificarNivel()
    {
        while (experiencia >= nivel * 50)
        {
            experiencia -= nivel * 50;
            nivel++;
            Console.WriteLine($"¡SUBISTE AL NIVEL {nivel}!");
        }
    }
}