using System;

namespace ClassDemoRelations
{
    public class Hjul
    {
        private int _tommer;
        private double _pris;


        public int Tommer{
            get { return _tommer;}
            set { _tommer = value; }
        }
        public double Pris{
            get { return _pris;}
            set { _pris = value; }
        }

        public Hjul(){
            _tommer = 16;
            _pris = 2000;
        }

        public Hjul(int tommer, double pris){
            _tommer = tommer;
            _pris = pris;
        }

        public override string ToString()
        {
            return $"Hjul tommer={_tommer} prisen er {_pris}";
        }

    }
}