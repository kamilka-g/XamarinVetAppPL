using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinWeterynarz
{
    public class VisitFormatter
    {
        public string FormatVisit(string name, string species, string age, string purpose, string time)
        {
            return $"Imie i nazwisko: {name}, Gatunek: {species}, Wiek: {age}, Cel wizyty: {purpose}, Godzina: {time}";
        }
    }

}
