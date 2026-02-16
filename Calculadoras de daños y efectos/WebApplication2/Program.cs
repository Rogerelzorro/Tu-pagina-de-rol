Console.WriteLine ("Introduzca el ataque (Habilidad de ataque + resultado del dado)");
int Ataquefinal = int.Parse(Console.ReadLine());
Console.WriteLine ("Introduzca la defensa (Habilidad de esquiva o parada + resultado del dado)");
int Defensafinal = int.Parse(Console.ReadLine());
double Resultado = Ataquefinal - Defensafinal;
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
    Math.Floor(Resultado);
    double Redondeo = dañopuro*Resultado/100;
    Math.Floor(Redondeo);
    double dañofinal = Redondeo - Armadura;
    Console.WriteLine ("El daño final recibido por el defensor es " + dañofinal);
}