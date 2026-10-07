# KaufAuto – Autoverwaltung (Konsole)

Konsolenanwendung in **C# / .NET**, mit der ein Autohändler seinen Fahrzeugbestand verwaltet.
Der Bestand wird als **JSON** gespeichert und bleibt zwischen den Sitzungen erhalten.

> Weiterentwicklung mit grafischer Oberfläche (Windows Forms): [KaufAuto-OP](https://github.com/noorsamman/KaufAuto-OP)

## Funktionen

- Fahrzeuge (PKW, SUV, Transporter) **hinzufügen, bearbeiten, löschen**
- Alle Fahrzeuge anzeigen und **nach Marke suchen**
- **Sortieren** nach Preis, Baujahr und PS
- **Statistiken:** Gesamtanzahl, neu/gebraucht, Kilometer je Fahrzeugtyp
- **Speichern und Laden** des Bestands als JSON-Datei

## Aufbau

| Ordner | Inhalt |
|---|---|
| `Models` | `Auto` (abstrakte Basisklasse), `PKW`, `SUV`, `Transporter` |
| `Interfaces` | `IAutoService`, `ISpeicherService` |
| `Services` | `AutoManager` (Logik), `SpeicherService` (JSON), `MenueService` (Konsolenmenü) |
| `Program.cs` | Einstiegspunkt und Menüsteuerung |

**Verwendete Konzepte:** Vererbung und Polymorphie, Interfaces, Trennung von Logik und Speicherung, LINQ, JSON-Serialisierung mit Newtonsoft.Json.

## Starten

1. `KaufAuto.sln` in Visual Studio öffnen
2. **F5** drücken – NuGet-Pakete werden automatisch wiederhergestellt

## Kontext

Projekt aus meiner Umschulung zum Fachinformatiker für Systemintegration (IHK) bei der Lutz+Grub Academy, Nürnberg.

**Autor:** Noureddin AlSamman – [github.com/noorsamman](https://github.com/noorsamman)
