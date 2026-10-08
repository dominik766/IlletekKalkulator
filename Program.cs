using IlletekKalkulator;
if (File.Exists("szobak.txt"))
{
    //vegiglepkedunk a fileban osszes beolvasott soron
    foreach (string aktsor in File.ReadAllLines("szobak.txt"))
    {

    }
} 
else
{
    Console.WriteLine("Hibakód 404 (A fájl nem található)");
}