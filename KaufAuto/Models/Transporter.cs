using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaufAuto.Models;


namespace KaufAuto.Models
{
    public class Transporter : Auto
    {
        public override void Info()
        {
            Console.WriteLine(
                $"[Transporter] ID {Id} – {Marke} {Modell}, {MotorleistungPS} PS, {Getriebe}, Zustand: {Zustand}, " +
                $"{Kilometerstand} km, {Türenanzahl} Türen, Baujahr {Baujahr}"
            );

        }
    }
}
