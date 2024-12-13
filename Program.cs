namespace PLZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe
            //Ein User soll seine Postleitzahl eingeben können.
            //Es wird geprüft, ob die PLZ fünf stellen hat.
            //Ist dies nicht der Fall, soll "Üngültige PLZ" in der Konsole ausgegeben werden.
            //Ist die PLZ korrekt, soll die zugehörige Region ermittel und in der Konsole ausgegeben werden.
            //Postleitzahlenregionen: Mit 0 oder 1 beginnend => Ostdeutschland

            //						  Mit 2 beginnend => Nordeutschland

            //						  Mit 3 beginnend => Mitteldeutschland

            //						  Mit 4 oder 5 beginnend => Westdeutschland

            //						  Mit 6,7,8 oder 9 beginnend => Süddeutschland


            string plz;
            int plzInt, plzLaenge;
            char plzErstesZeichen;
            bool plzOK;


            do
            {

                Console.WriteLine("Hallo User, bitte geben Sie Ihre *Postleitzahl ein:");
                int plzInt;
                string plz = Console.ReadLine();
                int plzLaenge = plz.Length;
                char plzErstesZeichen = plz[0];
                bool plzOK = Int32.TryParse(plz, out plzInt);

                if (plzLaenge == 5 && plzOK)
                {
                    if (plzOK)
                    {
                        switch (plzErstesZeichen)
                        {
                            case '0':
                            case '1':
                                Console.WriteLine("Ostdeutschland.");
                                break;
                            case '2':
                                Console.WriteLine("Norddeutschland");
                                break;
                            case '3';
                                Console.WriteLine("Mitteldeutschland");
                                break;
                            case '4':
                            case '5':
                                Console.WriteLine("Westdeutschland");
                                break;
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                Console.WriteLine("Süddeutschland");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Postleitzahl");
                    }
                }
                else
                {
                    Console.WriteLine(); ("Ungültige Postleitzahlz.");
                    plzOK = false;
                }
            }
            while (!plzOK);




            //User-Eingabe -> Check: plz = 5 Zahlen, plz nur Zahlen (keine Buchstaben)
            //plz korrekt  -> ja: check erste ziffer (zu

        }
    }
}
