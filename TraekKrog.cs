using System;

namespace ClassDemoRelations
{
    public class TraekKrog
    {
        private int _traekVaegt;
        private double _pris;


        public int TraekVaegt
        {
            get { return _traekVaegt;}
            set { _traekVaegt = value; }
        }
        public double Pris{
            get { return _pris;}
            set { _pris = value; }
        }

        public TraekKrog(){
            _traekVaegt = 560;
            _pris = 3400;
        }

        public TraekKrog(int traekVaegt, double pris){
            _traekVaegt = traekVaegt;
            _pris = pris;
        }

        public override string ToString()
        {
            return $"TrækKrog trækvægt={_traekVaegt} prisen er {_pris}";
        }

    }
}