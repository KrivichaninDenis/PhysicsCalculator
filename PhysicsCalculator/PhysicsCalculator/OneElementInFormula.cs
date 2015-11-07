using System;

namespace PhysicsCalculator
{
    public class OneElementInFormula
    {
        public readonly double Value;
        public readonly string Measure;
        public readonly int Degree;

        public OneElementInFormula(double v,string m, int d)
        {
            Value = v;
            Measure = m;
            Degree = d;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var p = (OneElementInFormula)obj;
            return (Math.Abs(p.Value) <0.001) && (Measure == p.Measure) && (Degree == p.Degree);
        }

       

        public override int GetHashCode()
        {
            return 12;
        }

        
    }
    
}
