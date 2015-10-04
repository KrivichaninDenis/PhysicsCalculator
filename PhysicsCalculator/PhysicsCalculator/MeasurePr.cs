using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsCalculator
{
   public class MeasurePr
    {
        public enum  Measures
        {
            Speed,
            Time,
            Distance
        }
       public Dictionary<string, string> Mes = new Dictionary<string, string>();
       
       public string SearchElement(string SomeValue)
       {
           string ReturnString = null;
           foreach (KeyValuePair<string, string> kvp in Mes)
           {
               if (kvp.Key == SomeValue)
               {
                   ReturnString = kvp.Value;
               }
           }
           return ReturnString;
       }
    }
    
}
