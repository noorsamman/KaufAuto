using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaufAuto.Models;

namespace KaufAuto.Interfaces
{
    public interface ISpeicherService
    {
        void Speichern(List<Auto> autos);
        List<Auto> Laden();
    }
}
