namespace CodeAlong_emne3;
/*
Skriv et program som lar brukeren opprette og lagre informasjon om dyr.
Programmet skal be brukeren om å skrive inn navn, art og alder for et dyr og deretter lagre denne informasjonen.
Senere skal programmet kunne skrive ut informasjonen om dyrene i konsollen.
Brukeren skal da kunne velge “Vis alle” eller “Søk på art”.
Søk skal ta vare på brukerens input og så vise de dyrene av arten brukeren etterspør.
Om ingen har denne arten skal dette også gis beskjed om i console.
 */
class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();
        zoo.ShowMenu();
    }
}