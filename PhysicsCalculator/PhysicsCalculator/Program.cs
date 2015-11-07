using System;
using PhysicsCalculator.Speed;
using PhysicsCalculator.Time;

namespace PhysicsCalculator
{

    class Program
    {
        public static Dictionary Dict = new Dictionary();//Список всех формул 
        static void Main()
        {

            var f = new Formula//создание одной формулы
            {
                Name = "Acceleration",
                Measure = "м/с^2"
            }; 
            //(для примера-формула ускорения)
            //составляющие формулы.
            f.Oneform.Add(new OneElementInFormula(0,"м/с",1));
            f.Oneform.Add(new OneElementInFormula(0,"с",-1));
            f.Oneform.Add(new OneElementInFormula(0, "с", -1));
            Dict.AllFormulas.Add(f);

            var v=new MeterPerSecond(60);                     
            var t1=new Seconds(2);       
            var t2=new Seconds(3);          

            var q = v/t1/t2;     
            
            Console.WriteLine(q.Value+" "+q.Measure);  
      
         
        }
    }
}
