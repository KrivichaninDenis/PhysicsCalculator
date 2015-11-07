using System.Collections.Generic;

namespace PhysicsCalculator
{
    public class Formula
    {
        public string Name;
        public string Measure;
        public List<OneElementInFormula> Oneform=new List<OneElementInFormula>();

        public double Calculate(List<OneElementInFormula> res)
        {
            double result = 1;
            foreach (var element in res)
            {
               
                if (element.Degree == 1)
                {
                    result *= element.Value;
                }
                else
                {
                    result /= element.Value;
                }
            }
            
            return result;
        }
    }
}
