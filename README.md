KaufAuto – Auto-Verwaltung
Projekt­informationen

Name: KaufAuto – Auto-Verwaltung
Art: Konsolenanwendung in C# (.NET)
Zielgruppe / Zweck: Verwaltung von Fahrzeugen (PKW, SUV, Transporter) für einen Autohändler

1. Einleitung

KaufAuto ist eine einfache C#-Konsolenanwendung, mit der ein Autohändler seinen Fahrzeugbestand verwalten kann. Fahrzeuge können hinzugefügt, bearbeitet, gelöscht, angezeigt und gesucht werden. Der Bestand wird in einer JSON-Datei gespeichert, sodass die Daten zwischen Sitzungen persistent bleiben.

2. Ziele & Features

Die Anwendung bietet folgende Funktionen:

Fahrzeuge erfassen (PKW, SUV, Transporter)

Fahrzeuge bearbeiten (z. B. Marke, Modell, Baujahr, Preis, Kilometerstand)

Fahrzeuge löschen

Alle Fahrzeuge anzeigen

Suche nach Marke

Sortierfunktionen: nach Preis, Baujahr, PS

Statistiken & Auswertungen: Gesamtanzahl, Anzahl neu/gebraucht, Kilometerstatistik je Fahrzeugtyp

Speichern und Laden von Fahrzeugdaten via JSON

3. Technische Umgebung

Programmiersprache: C#

Projektart: .NET Konsolenanwendung

Datenhaltung: JSON-Datei (serialisiert / deserialisiert mit JSON) 
Microsoft Learn
+1

Projektstruktur:

Models (Auto, PKW, SUV, Transporter)

Services (AutoManager, SpeicherService)

Interfaces (IAutoService, ISpeicherService)

Program (Main / Menüsteuerung)

4. Klassen- und Architekturübersicht

Auto (abstrakte Basisklasse): gemeinsame Eigenschaften aller Fahrzeuge (Id, Marke, Modell, PS, Preis, Zustand etc.)

PKW, SUV, Transporter: erben von Auto, implementieren unterschiedliche Fahrzeugtypen und eine Methode Info() für Konsolenausgabe

IAutoService / AutoManager: verwaltet die Fahrzeugliste — Hinzufügen, Löschen, Bearbeiten, Suche, Ausgabe, Statistiken

ISpeicherService / SpeicherService: Speichern und Laden der Fahrzeugliste in / aus JSON-Datei

5. Ablauf & Bedienung

Beim Start lädt die Anwendung vorhandene Fahrzeuge aus der JSON-Datei. Dann zeigt sie ein Menü mit Optionen:

Fahrzeug hinzufügen

Fahrzeug löschen

Fahrzeug bearbeiten

Alle Fahrzeuge anzeigen

Suche nach Marke

Auswertungen / Statistiken

Fahrzeuge speichern

Fahrzeuge laden

Sortieren nach Preis, Baujahr oder PS

Programm beenden

Der Nutzer wählt eine Option, gibt nötige Daten ein, und die Anwendung führt die gewählte Aktion durch.

6. Daten­speicherung & JSON

Fahrzeugdaten werden in einer Datei autos.json gespeichert. Beim Speichern werden die Objekte serialisiert, beim Laden wieder deserialisiert — so bleiben alle Eigenschaften wie ID, Marke, Modell, Zustand etc. erhalten. 
Microsoft Learn
+1

7. Mögliche Fehler & Verbesserungen

Mögliche Fehlerquellen:

JSON-Datei fehlt oder ist beschädigt → Anwendung sollte leere Liste nutzen und nicht abstürzen

Ungültige Eingaben beim Hinzufügen / Bearbeiten (z. B. Buchstaben statt Zahlen) → Eingabe validieren

Verbesserungen / Erweiterungen:

Filter oder Suche nach weiteren Kriterien (Preisbereich, Jahr, Zustand)

Export / Import (z. B. CSV, XML)

GUI (Windows Forms / WPF / Web-Frontend) statt Konsole

Mehr Fahrzeugtypen, bessere Fehlerbehandlung, Validierung

8. Kurzbeschreibung für Präsentation

KaufAuto ist eine C#-Konsolenanwendung, mit der ein Autohändler seinen Fahrzeugbestand effizient verwalten kann.
Sie ermöglicht das Hinzufügen, Bearbeiten, Löschen und Anzeigen von PKW, SUV und Transportern.
Zusätzlich unterstützt das Programm Such- und Sortierfunktionen sowie Statistiken zur Bestandspflege.
Alle Daten werden persistent in einer JSON-Datei gespeichert und beim Start automatisch geladen.
Technisch basiert das Projekt auf objektorientierter Programmierung mit klaren Klassen- und Service-Strukturen.
