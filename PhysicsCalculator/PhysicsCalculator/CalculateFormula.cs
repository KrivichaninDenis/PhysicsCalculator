using System;
using System.Collections.Generic;

namespace PhysicsCalculator
{
    static class CalculateFormula
    {
        public static List<OneElementInFormula> CalculationResult=new List<OneElementInFormula>();

        public static void ClearResult()
        {
            CalculationResult.Clear();
        }

        public static void Out(List<OneElementInFormula> fr)//вывод элементов формулы
        {
            foreach (var oneEl in fr)
            {
                Console.WriteLine(oneEl.Value+" "+oneEl.Measure+" "+oneEl.Degree);
            }
        }

        

    }
}
