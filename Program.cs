using IlletekKalkulator;
if (File.Exists("szobak.txt"))
{
    //vegiglepkedunk a fileban osszes beolvasott soron

    foreach (string aktsor in File.ReadAllLines("szobak.txt"))
    {
        List<Szoba> szobak = new List<Szoba>();
        string[] adatok = aktsor.Split(';');

        //hibakezeles!!!!!!

        int db = adatok.Count();

        if (db != 4) continue;

        if (int.TryParse(adatok[1], out int emelet) &&
            int.TryParse(adatok[2], out int ar) &&
            int.TryParse(adatok[3], out int ferohely))
        {
            if (!string.IsNullOrWhiteSpace(adatok[0]))
            {
                Szoba aktualis = new Szoba(adatok[0], emelet, ar, ferohely);
                szobak.Add(aktualis);
            }
        }

    }
} 
else
{
    Console.WriteLine("Hibakód 404 (A fájl nem található)");
}