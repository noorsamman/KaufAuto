using KaufAuto.Interfaces;
using KaufAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaufAuto.Services
{
    public class AutoManager : IAutoService
    {
        private List<Auto> autos = new List<Auto>();
        private int naechsteId = 1;

        public void Hinzufuegen()
        {
            // Fahrzeugtyp auswählen (PKW, SUV oder Transporter)

            Console.WriteLine("Bitte Fahrzeugtyp auswählen:");
            Console.WriteLine("1 = PKW ");
            Console.WriteLine("2 = SUV ");
            Console.WriteLine("3 = Transporter ");

            // Fahrzeugtyp auswählen (PKW, SUV oder Transporter)


            int auswahl;
            while(!int.TryParse(Console.ReadLine(), out auswahl) || (auswahl < 1 || auswahl > 3))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte 1, 2 oder 3 eingeben.");
            }
            Auto neuesAuto;

            switch (auswahl)
            {
                case 1:
                    neuesAuto = new PKW();
                    break;
                case 2:
                    neuesAuto = new SUV();
                    break;
                case 3:
                    neuesAuto = new Transporter();
                    break;
                default:
                    return;
            }

            // automatische ID & Typ setzen


            neuesAuto.Id = GeneriereId();
            neuesAuto.Fahrzeugtyp = neuesAuto.GetType().Name;

            // Marke und Modell abfragen

            Console.WriteLine("Marke eingeben:");
            neuesAuto.Marke = Console.ReadLine();
            
            Console.WriteLine("Modell eingeben:");
            neuesAuto.Modell = Console.ReadLine();

            // Motorleistung (PS) eingeben und prüfen, dass der Wert mindestens 1 ist

            int ps;
            Console.WriteLine(" PS eingeben:");
            while (!int.TryParse(Console.ReadLine(), out ps) || ps < 1)
            {
                Console.WriteLine("Ungültige Eingabe! PS muss mindestens 1 sein. ");
                Console.WriteLine(" PS erneut eingeben:");
            }
            neuesAuto.MotorleistungPS = ps;

            // Getriebe auswählen: 1 = Automatik, 2 = Schaltgetriebe

            Console.WriteLine("Getriebe auswählen: 1 = Automatik, 2 = Schaltgetriebe");
            int getriebeAuswahl;
            while (!int.TryParse(Console.ReadLine(), out getriebeAuswahl) || (getriebeAuswahl < 1 || getriebeAuswahl > 2))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte 1 oder 2 eingeben.");
            }
            if (getriebeAuswahl == 1)
            {
                neuesAuto.Getriebe = "Automatik";
            }
            else
            {
                neuesAuto.Getriebe = "Schaltgetriebe";
            }

            // Preis eingeben und prüfen, dass der Wert größer als 0 ist

            double preis;
            
            Console.WriteLine("Preis eingeben:");
            while (!double.TryParse(Console.ReadLine(), out preis) || preis <= 0)
            {
                Console.WriteLine("Ungültige Eingabe! Preis muss größer als 0 sein. ");
                Console.WriteLine("Preis erneut eingeben:");
            }
            neuesAuto.Preis = preis;

            // Zustand auswählen: Neu oder Gebraucht

            Console.WriteLine("zustand auswählen: 1 = Neu, 2 = Gebraucht");
            int zustandAuswahl;
            while (!int.TryParse(Console.ReadLine(), out zustandAuswahl) || (zustandAuswahl < 1 || zustandAuswahl > 2))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte 1 oder 2 eingeben.");
            }

            // Zustand setzen

            if ( zustandAuswahl == 1)
            {
                neuesAuto.Zustand = "Neu";
                neuesAuto.Kilometerstand = 0;
                Console.WriteLine("Kilometerstand wird auf 0 gesetzt (Neuwagen).");

            }
            else
            {
                neuesAuto.Zustand = "Gebraucht";
                int km;
                Console.WriteLine("Kilometerstand eingeben:");
                while (!int.TryParse(Console.ReadLine(), out km) || km < 0)
                {
                    Console.WriteLine("Ungültige Eingabe! Kilometerstand muss mindestens 0 sein. ");
                    Console.WriteLine("Kilometerstand erneut eingeben:");
                }
                neuesAuto.Kilometerstand = km;
            }

            // Anzahl der Türen eingeben (z. B. 2, 3, 4 oder 5)

            int tueren;
            Console.WriteLine("Anzahl der Türen eingeben (z. B. 2, 3, 4 oder 5):");
            while (!int.TryParse(Console.ReadLine(), out tueren) || (tueren < 2 || tueren > 5))
            {
                Console.WriteLine("Ungültige Eingabe! Anzahl der Türen muss zwischen 2 und 5 liegen. ");
                Console.WriteLine("Anzahl der Türen erneut eingeben:");
            }
            neuesAuto.Türenanzahl = tueren;

            // Auto in die Liste speichern
            autos.Add(neuesAuto);
            Console.WriteLine("Fahrzeug erfolgreich hinzugefügt!");
            Console.WriteLine("ID des Fahrzeugs: " + neuesAuto.Id);
            Console.WriteLine("Fahrzeugtyp: " + neuesAuto.Fahrzeugtyp);
            Console.WriteLine("Marke: " + neuesAuto.Marke);
            Console.WriteLine("Modell: " + neuesAuto.Modell);
            Console.WriteLine("Motorleistung (PS): " + neuesAuto.MotorleistungPS);
            Console.WriteLine("Getriebe: " + neuesAuto.Getriebe);
            Console.WriteLine("Preis: " + neuesAuto.Preis);
            Console.WriteLine("Zustand: " + neuesAuto.Zustand);
            Console.WriteLine("Kilometerstand: " + neuesAuto.Kilometerstand);
            Console.WriteLine("Anzahl der Türen: " + neuesAuto.Türenanzahl);
            Console.WriteLine("-------------------------------------");

        }

        public bool Loeschen(int id)
        {
            Auto gefundenesAuto = null;

            // Auto in der Liste suchen 

            foreach (var a in autos)
            {
                if (a.Id == id)
                {
                    gefundenesAuto = a;
                    break;
                }
            }
            // Wenn nichts gefunden → false zurück

            if (gefundenesAuto == null)
            {
                Console.WriteLine("Keine Auto mit dieser ID gefunden.");
                return false;
            }
            string[] details = new string[]
            {
                "ID : " + gefundenesAuto.Id,
                "Typ : " + gefundenesAuto.Fahrzeugtyp,
                "Marke : " + gefundenesAuto.Marke,
                "Modell : " + gefundenesAuto.Modell,
                "(PS) : " + gefundenesAuto.MotorleistungPS,
                "Getriebe : " + gefundenesAuto.Getriebe,
                "Preis : " + gefundenesAuto.Preis,
                "Zustand : " + gefundenesAuto.Zustand,
                "Kilometerstand : " + gefundenesAuto.Kilometerstand,
                "Türen : " + gefundenesAuto.Türenanzahl
            };
            Console.WriteLine("Auto gefunden:");
            foreach (var detail in details)
            {
                Console.WriteLine(detail);
            }
            Console.WriteLine("--------------------------------------");


            autos.Remove(gefundenesAuto);

            Console.WriteLine("Auto erfolgreich gelöscht.");
            Console.WriteLine("-------------------------------------");

            return true;
        }

        public void Bearbeiten(int id, Auto neueDaten)
        {
           
        }

        public List<Auto> AlleAutos()
        {
           
            return new List<Auto>();
        }

        public List<Auto> SucheNachMarke(string marke)
        {
            
            return new List<Auto>();
        }

        public (int gesamt, int neu, int gebraucht, double kmPkw, double kmTransporter) ErstelleAuswertungen()
        {
            
            return (0, 0, 0, 0, 0);
        }

        private int GeneriereId()
        {
            return naechsteId++;
        }
    }
}
