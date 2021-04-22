using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolProjekt
{
    public struct StructKlasse
    {
        DateTime afslutDato;
        public StructKlasse(DateTime dato)
        {
            afslutDato = dato;
        }
        public int BeregnAfslutDato()
        {
            var now = DateTime.Now;

            var remainingTime = (afslutDato - now).Days;
            return remainingTime;
        }
    }

    public record KontaktInfo(string fornavn, string efternavn, string telefon, DateTime fødselsdato, char køn)
    {
        public string FName { get; init; }
    }
}
