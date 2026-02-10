class Program
{
    static void Main()
    {
        Console.WriteLine ("Introduzca el ataque (Habilidad de ataque + resultado del dado)");
        int Ataquefinal = int.Parse(Console.ReadLine());
        Console.WriteLine ("Introduzca la defensa (Habilidad de esquiva o parada + resultado del dado)");
        int Defensafinal = int.Parse(Console.ReadLine());

        int Resultado = Ataquefinal - Defensafinal;

        if (Resultado <= 0)
        {
            Console.WriteLine ("El atacante a fallado el ataque, el defensor tiene derecho a un contraatacaque");
        }

        if (Resultado > 0)
        {
            Console.WriteLine ("El atacante a acertado el ataque. Ahora se calculara el daño recibido");
            Console.WriteLine ("Introduzca el TA del defensor (Recuerda diferenciar filo, contundente, penentrante, calor, frio, electrico y energia)");
            int TA = int.Parse(Console.ReadLine());
            
            Console.WriteLine ("Introduzca el daño del arma del Atacante");
            int dañopuro = int.Parse(Console.ReadLine());

            int Armadura = (TA *10) + 20;

            int Porredondear = Resultado - Armadura;

            double Redondeo = Porredondear;
            Console.WriteLine(Math.Floor(Redondeo));

            if (Redondeo == 10)
            {
                if (dañopuro == 10)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 20)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 30)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 40)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 50)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 60)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 70)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 80)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 90)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 100)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 105)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 110)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 115)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 120)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 125)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 130)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 135)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 140)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 145)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 150)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 155)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 160)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 165)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 170)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 175)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 180)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 185)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 190)
                {
                    int dañofinal = dañopuro/10;
                }
                if (dañopuro == 200)
                {
                    int dañofinal = dañopuro/10;
                }
            }
            Console.WriteLine ("El daño recibido por el objetivo del ataque es " + dañofinal);
        }

        Console.Write("¿Reiniciar programa? Escriba 'si', en caso de que asi sea.");
        string respuesta = Console.ReadLine()?.Trim().ToLower();

        if (respuesta == "si")
        {
            // Obtener la ruta del ejecutable actual
            string exePath = Assembly.GetExecutingAssembly().Location;

            // Iniciar un nuevo proceso
            Process.Start(exePath);

            // Cerrar el proceso actual
            Environment.Exit(0);
        }

        Console.WriteLine("Programa finalizado.");
    }
}







