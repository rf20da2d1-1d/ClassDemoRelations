using System;

namespace ClassDemoRelations
{
    class Bil
    {
        private string _model;

        // der kommer mere


        public string Model 
        {
            get {return _model;}
            set {_model = value;}
        }
        

        public Bil()
        {
            _model = "Tesla";
        }

        public Bil(string model)
        {
            _model = model;
        }

        public override string ToString()
        {
            return $"Bil  model={_model}";
        }


    }
}