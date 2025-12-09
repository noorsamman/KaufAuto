using KaufAuto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaufAuto.Models;

namespace KaufAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoManager manager = new AutoManager();
            SpeicherService speicher = new SpeicherService();

            // Autos beim Start laden

            var geladeneAutos = speicher.Laden();
            manager.SetAutos(geladeneAutos);

            if ( geladeneAutos.Count > 0 )
            {
                Console.WriteLine($"{geladeneAutos.Count} Autos wurden aus der JSON-Datei geladen.");

            }

            //Loop
            bool running = true;

            while (running) 
            {
                Console.WriteLine("===============================");
                Console.WriteLine("      AUTO VERWALTUNG");
                Console.WriteLine("===============================");
                Console.WriteLine("1 - Auto hinzufügen");
                Console.WriteLine("2 - Auto löschen");
                Console.WriteLine("3 - Auto bearbeiten");
                Console.WriteLine("4 - Alle Autos anzeigen");
                Console.WriteLine("5 - Suche nach Marke");
                Console.WriteLine("6 - Auswertungen anzeigen");
                Console.WriteLine("7 - Autos speichern");
                Console.WriteLine("8 - Autos laden");
                Console.WriteLine("0 - Programm beenden");
                Console.WriteLine("===============================");
                Console.Write("Auswahl eingeben: ");

                string auswahl = Console.ReadLine();
                Console.Clear();

                switch (auswahl) 
                {
                        case "1":
                        manager.Hinzufuegen();
                        break;

                        case "2":
                        Console.Write("ID eingeben zum Löschen: ");
                        int idLoeschen;
                        if (int.TryParse(Console.ReadLine(), out idLoeschen ))
                            manager.Loeschen(idLoeschen);
                        break;

                        case "3":
                        Console.Write("ID eingeben zum Bearbeiten: ");
                        int idBearbeiten;
                        if (int.TryParse(Console.ReadLine(), out idBearbeiten))
                            manager.Bearbeiten(idBearbeiten, null);
                        break;

                        case "4":
                        manager.AlleAutos();
                        break;

                        case "5":
                            Console.Write("Marke eingeben zum Suchen: ");
                            string marke = Console.ReadLine();
                             manager.SucheNachMarke(marke);
                             break;

                        case "6":


                            var adaten = manager.ErstelleAuswertungen();
                        Console.WriteLine("Auswertungen:");
                        Console.WriteLine($"Gesamtanzahl Autos: {adaten.gesamt}");
                        Console.WriteLine($"Anzahl Neuwagen: {adaten.neu}");
                        Console.WriteLine($"Anzahl Gebrauchtwagen: {adaten.gebraucht}");
                        Console.WriteLine($"Durchschnittliche Kilometer PKW: {adaten.kmPkw:F2}");
                        Console.WriteLine($"Durchschnittliche Kilometer Transporter: {adaten.kmTransporter:F2}");
                        break;

                        case "7":

                        speicher.Speichern(manager.AlleAutos());

                        break;


                        case "8":

                        geladeneAutos = speicher.Laden();
                        manager.SetAutos(geladeneAutos);
                        Console.WriteLine("Autos wurden aus der JSON-Datei neu geladen.");
                        break;

                        case "0":

                        running = false;
                        break;

                        default:

                        Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
                        break;
                }

                 Console.WriteLine("\nWeiter mit Enter...");
                 Console.ReadLine();
                Console.Clear();





            }

        }
    }
}
