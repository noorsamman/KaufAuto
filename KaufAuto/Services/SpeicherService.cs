using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaufAuto.Models;
using KaufAuto.Interfaces;
using Newtonsoft.Json;
using System.IO;




namespace KaufAuto.Services
{
    public class SpeicherService : ISpeicherService
    {
        private string dateiPfad = "autos.json";
        public void Speichern(List<Auto> autos)
        {
            string json = JsonConvert.SerializeObject(autos, Formatting.Indented);

            File.WriteAllText(dateiPfad, json);

            Console.WriteLine("Daten wurden erfolgreich gespeichert.");
        }
        public List<Auto> Laden()
        {
            return new List<Auto>();
        }
    }
}
