using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaufAuto.Models;
using KaufAuto.Interfaces;


namespace KaufAuto.Services
{
    public class SpeicherService : ISpeicherService
    {
        private string dateiPfad = "autos.json";
        public void Speichern(List<Auto> autos)
        {


        }
        public List<Auto> Laden()
        {
            return new List<Auto>();
        }
    }
}
