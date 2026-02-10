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
                    int dañofinal = Math.Round(dañopuro*10/100);
                    Console.WriteLine ("El daño final recibido por el defensor es " + dañofinal);
                }    
                if (dañopuro == 20)
                {
                    int dañofinal = dañopuro*20/100;
                }    
                if (dañopuro == 30)
                {
                    int dañofinal = dañopuro*30/100;
                }    
                if (dañopuro == 40)
                {
                    int dañofinal = dañopuro*40/100;
                }    
                if (dañopuro == 50)
                {
                    int dañofinal = dañopuro*50/100;
                }    
                if (dañopuro == 60)
                {
                    int dañofinal = dañopuro*60/100;
                }    
                if (dañopuro == 70)
                {
                    int dañofinal = dañopuro*70/100;
                }    
                if (dañopuro == 80)
                {
                    int dañofinal = dañopuro*80/100;
                }    
                if (dañopuro == 90)
                {
                    int dañofinal = dañopuro*90/100;
                }    
                if (dañopuro == 100)
                {
                    int dañofinal = dañopuro*100/100;
                }    
                if (dañopuro == 105)
                {
                    int dañofinal = dañopuro*105/100;
                }    
                if (dañopuro == 70)
                {
                    int dañofinal = dañopuro*110/100;
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







