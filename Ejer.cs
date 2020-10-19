using System;

namespace ClassDemoRelations
{
    public class Ejer
    {
        private string _navn;
        private string _adr;

        public string Navn 
        {
            get {return _navn;}
            set {_navn = value;}
        }
        public string Adresse 
        {
            get {return _adr;}
            set {_adr = value;}
        }

        public Ejer()
        {
            _navn = "dummy";
            _adr = "dummyAdr";
        }

        public Ejer(string navn, string adresse)
        {
            _navn = navn;
            _adr = adresse;
        }

        public override string ToString()
        {
            return $"Ejer navn={_navn} bor på adressen  {_adr}";
        }


    }
}