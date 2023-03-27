static void contrasena()
{
    byte oportunidades = 0;
    bool tienePermiso = false;
    string clave;

    do
    {
        Console.Write("                                                     DIGITE LA CLAVE: ");
        clave = HideCharacter().Replace("\r", "");
        Console.WriteLine();

        if (clave.ToUpper() == "ANDER56")
        {
            tienePermiso = true;
        }
        else
        {
            oportunidades++;
        }
    } while (oportunidades < 3 && !tienePermiso);

    if (tienePermiso)
    {
        Console.WriteLine("                                               BIENVENIDO AL CAJERO AUTOMATICO");
        desglose();
    }
    else
    {
        Console.WriteLine("                                                  OPORTUNIDADES TERMINADAS");
    }
}

static string HideCharacter()
{
    ConsoleKeyInfo key;
    string code = "";
    do
    {
        key = Console.ReadKey(true);

        if (char.IsLetterOrDigit(key.KeyChar))
        {
            Console.Write("*");
        }
        code += key.KeyChar;
    } while (key.Key != ConsoleKey.Enter);

    return code;
}


static void desglose()
{
    double dolar_a_quetzal = 7.75;
    double euro_a_quetzal = 9.25;
    double quetzal = 1;

    Console.WriteLine("                                                     elija una opción");
    Console.WriteLine("                                                     1. Dólar");
    Console.WriteLine("                                                     2. Euro");
    Console.WriteLine("                                                     3. Quetzales");
    Console.WriteLine("                                                     4. Salir");

    string moneda = Console.ReadLine();

    if (moneda == "4")
    {
        return;
    }

    Console.WriteLine("                                         Ingresa la cantidad que desea retirar");
    double cantidad;

    while (!double.TryParse(Console.ReadLine(), out cantidad)) ;

    double resultado = 0;

    if (moneda == "1")
    {
        resultado = cantidad * dolar_a_quetzal;
        Console.WriteLine("                                         {0} dólar(es) equivalen a {1} quetzales", cantidad, resultado);
    }
    else if (moneda == "2")
    {
        resultado = cantidad * euro_a_quetzal;
        Console.WriteLine("                                         {0} euro(s) equivalen a {1} quetzales", cantidad, resultado);
    }
    else if (moneda == "3")
    {
        resultado = cantidad * quetzal;
        Console.WriteLine("                                                 {0} quetzal(es)", cantidad, resultado);
    }

    int CAN = (int)resultado;
    int CAND = (int)((resultado - CAN) * 100);


    int c200, c100, c50, c20, c10, c5, c1;
    int m50, m25, m10, m5, m1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;
    m50 = m25 = m10 = m5 = m1 = 0;

    //Billetes
    if (CAN >= 200)
    {
        c200 = (CAN / 200);
        CAN -= (c200 * 200);
    }
    if (CAN >= 100)
    {
        c100 = (CAN / 100);
        CAN -= (c100 * 100);
    }
    if (CAN >= 50)
    {
        c50 = (CAN / 50);
        CAN -= (c50 * 50);
    }
    if (CAN >= 20)
    {
        c20 = (CAN / 20);
        CAN -= (c20 * 20);
    }
    if (CAN >= 10)
    {
        c10 = (CAN / 10);
        CAN -= (c10 * 10);
    }
    if (CAN >= 5)
    {
        c5 = (CAN / 5);
        CAN -= (c5 * 5);
    }
    if (CAN >= 1)
    {
        c1 = (CAN / 1);
        CAN -= (c1 * 1);
    }
    // monedas
    if (CAND >= 50)
    {
        m50 = (CAND / 50);
        CAND -= (m50 * 50);
    }
    if (CAND >= 25)
    {
        m25 = (CAND / 25);
        CAND -= (m25 * 25);
    }
    if (CAND >= 10)
    {
        m10 = (CAND / 10);
        CAND -= (m10 * 10);
    }
    if (CAND >= 5)
    {
        m5 = (CAND / 5);
        CAND -= (m5 * 5);
    }
    if (CAND >= 1)
    {
        m1 = (CAND / 1);
        CAND -= (m1 * 1);
    }

    Console.WriteLine($"                                            Estos son sus billetes");
    Console.WriteLine($"                            Billetes de a 200:                          {c200}");
    Console.WriteLine($"                            Billetes de a 100:                          {c100}");
    Console.WriteLine($"                            Billetes de a 50 :                          {c50}");
    Console.WriteLine($"                            Billetes de a 20 :                          {c20}");
    Console.WriteLine($"                            Billetes de a 10 :                          {c10}");
    Console.WriteLine($"                            Billetes de a 5  :                          {c5}");
    Console.WriteLine($"                            Billetes de a 1  :                          {c1}");
    Console.WriteLine("");

    Console.WriteLine("                                             Estas son sus Monedas");
    Console.WriteLine($"                            Monedas de 50c =                            {m50}");
    Console.WriteLine($"                            Monedas de 25c =                            {m25}");
    Console.WriteLine($"                            Monedas de 10c =                            {m10}");
    Console.WriteLine($"                            Monedas de 5c  =                            {m5}");
    Console.WriteLine($"                            Monedas de 1c  =                            {m1}");

}
//desglose();
contrasena();