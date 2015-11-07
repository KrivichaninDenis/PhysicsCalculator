using System;
using System.Collections.Generic;
using System.Linq;

namespace PhysicsCalculator
{
    public class PhysValue
    {
        public double Value;
        public string Measure;

        
        
        public static PhysValue operator +(PhysValue pv1, PhysValue pv2)
        {
            if (pv1.Measure != pv2.Measure)
            {
                throw new InvalidOperationException("Ошибка операции");
            }
            var newPhysvalue = new PhysValue
            {
                Value = pv1.Value + pv2.Value,
                Measure = pv1.Measure
            };
            return  newPhysvalue;
        }


        public static PhysValue operator -(PhysValue pv1, PhysValue pv2)
        {
            if (pv1.Measure != pv2.Measure)
            {
                throw new InvalidOperationException("Ошибка операции");
            }
            var newPhysvalue = new PhysValue
            {
                Value = pv1.Value - pv2.Value,
                Measure = pv1.Measure
            };
            return newPhysvalue;
        }

        public static PhysValue operator /(PhysValue pv1, PhysValue pv2)
        {
            if (pv1.Value != null && pv1.Measure != null)
            {
                CalculateFormula.CalculationResult.Add(new OneElementInFormula(pv1.Value, pv1.Measure, 1));
            }            
                CalculateFormula.CalculationResult.Add(new OneElementInFormula(pv2.Value, pv2.Measure, -1));           
            Check();
            return SearchFormula(Program.Dict, CalculateFormula.CalculationResult); 
        }

        public static PhysValue operator *(PhysValue pv1, PhysValue pv2)
        {
            if (pv1.Value != null && pv1.Measure != null)
            {
                CalculateFormula.CalculationResult.Add(new OneElementInFormula(pv1.Value, pv1.Measure, 1));
            }            
                CalculateFormula.CalculationResult.Add(new OneElementInFormula(pv2.Value, pv2.Measure, 1));
            
            Check();
           
            return SearchFormula(Program.Dict, CalculateFormula.CalculationResult); 
        }

        public static void Check()
        {                     
            CalculateFormula.CalculationResult = new List<OneElementInFormula>(CalculateFormula.CalculationResult.Distinct());
        }

        public static PhysValue SearchFormula(Dictionary dictionary, List<OneElementInFormula> results)//поиск формулы
        {
            
            var newPhysValue = new PhysValue();
         
            foreach (var formula in dictionary.AllFormulas.Where(formula => CompareList(formula.Oneform, results)))
            {
                newPhysValue.Value = formula.Calculate(results);
                newPhysValue.Measure = formula.Measure;                                  
                return newPhysValue;
            }
            return newPhysValue;
        }

        public static bool CompareList(List<OneElementInFormula> f1, List<OneElementInFormula> f2)
        {
            if (f1.Count != f2.Count) return false; 
            var count = f1.Count(f2.Contains);
            return count == f1.Count;
        }
    }
}
