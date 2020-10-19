using System;

namespace ClassDemoRelations
{
    public class RelationWorker
    {
        public RelationWorker()
        {
        }
        public void MyCode()
        {
            // here comes the code

            // making an object of each class
            Hjul hjul = new Hjul(18, 2700);
            TraekKrog traek = new TraekKrog(780, 7800);
            Ejer ejer = new Ejer("Peter", "Roskilde");
            Bil bil = new Bil("VW");






            // udskriver de 4 objekter
            System.Console.WriteLine(hjul);
            System.Console.WriteLine(traek);
            System.Console.WriteLine(ejer);
            System.Console.WriteLine(bil);
        }

    }
}