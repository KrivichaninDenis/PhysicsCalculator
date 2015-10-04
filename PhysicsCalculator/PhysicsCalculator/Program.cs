using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MeasurePr MyMeasure = new MeasurePr();


            PhysValue Speed = new PhysValue(20,MeasurePr.Measures.Speed.ToString());
            PhysValue Time = new PhysValue(10, MeasurePr.Measures.Time.ToString());
            PhysValue Distance = new PhysValue(200, MeasurePr.Measures.Distance.ToString());
            PhysValue Distance1 = new PhysValue(100, MeasurePr.Measures.Distance.ToString());

            MyMeasure.Mes.Add("Speed", "м/c");
            MyMeasure.Mes.Add("Time", "c");
            MyMeasure.Mes.Add("Distance", "м");
           
           
            PhysValue qwe=Distance+Distance1;
            Console.WriteLine(qwe.Value + MyMeasure.SearchElement(qwe.Measure));

            PhysValue qwe1 = Distance - Distance1;
            Console.WriteLine(qwe1.Value + MyMeasure.SearchElement(qwe.Measure));

            PhysValue NewSpeed = Distance/ Speed;
            Console.WriteLine(NewSpeed.Value + MyMeasure.SearchElement(NewSpeed.Measure));

            PhysValue NewDistance = Speed * Time;
            Console.WriteLine(NewDistance.Value + MyMeasure.SearchElement(NewDistance.Measure));

            PhysValue NewDistance1 = Time * Speed;
            Console.WriteLine(NewDistance1.Value + MyMeasure.SearchElement(NewDistance1.Measure));
        }
    }
}
