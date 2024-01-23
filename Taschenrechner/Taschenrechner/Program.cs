
while (true)
{
    Console.WriteLine("\tEinfacher Taschenrechner\n");

    Console.WriteLine("\t(1)\tAddition");
    Console.WriteLine("\t(2)\tSubtraktion");
    Console.WriteLine("\t(3)\tMultiplikation");
    Console.WriteLine("\t(4)\tDivision");
    Console.WriteLine("\t(5)\tEnde");
    Console.WriteLine();
    Console.WriteLine("\tBitte wähle eine Option (1-5): ");
    int auswahl = Convert.ToInt32(Console.ReadLine());

    if (auswahl > 5)
    {
        Console.WriteLine("\tUngültige Auswahl. Bitte wähle eine Option von 1 bis 5.\n\n");
        continue;
    }

    if (auswahl == 5)
    {
        Console.WriteLine("\tProgramm beendet\n");
        break;
    }

    Console.WriteLine("\tWähle deine 1. Zahl\n");
    int zahl1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\tWähle deine 2. Zahl\n");
    int zahl2 = Convert.ToInt32(Console.ReadLine());

    double ergebnis = 0.0;

    switch (auswahl)
    {

        case 1:
            Console.WriteLine("\tDu hast Addition ausgewählt.\n");
            ergebnis = zahl1 + zahl2;
            break;
        case 2:
            Console.WriteLine("\tDu hast Subtraktion ausgewählt.\n");
            ergebnis = zahl1 - zahl2;
            break;
        case 3:
            Console.WriteLine("\tDu hast Multiplikation ausgewählt.\n");
            ergebnis = zahl1 * zahl2;
            break;
        case 4:
            Console.WriteLine("\tDu hast Division ausgewählt.\n");
            if(zahl2 != 0)
            {
                ergebnis = zahl1 / zahl2;
            }
            else
            {
                Console.WriteLine("\tKann nicht geteil 0 gerechnet werden");
                continue;
            }

            break;
        default:
            Console.WriteLine("\tUngültige Auswahl. Bitte wähle eine Option von 1 bis 5.\n\n");
            continue;
    }

    Console.WriteLine($"\tDas ergebniss lautet {ergebnis}\n\n");
}

