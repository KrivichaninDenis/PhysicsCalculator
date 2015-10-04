using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsCalculator
{
    public class PhysValue
    {
        public int Value;
        public string Measure;

        public PhysValue(int val, string mes)
        {
            Value = val;
            Measure = mes;
        }

        public static PhysValue operator +(PhysValue PV1, PhysValue PV2)
        {
            if (PV1.Measure != PV2.Measure)
            {
                throw new InvalidOperationException("Ошибка операции");                
            }
            return new PhysValue(PV1.Value + PV2.Value, PV1.Measure);            
        }


        public static PhysValue operator -(PhysValue PV1, PhysValue PV2)
        {
            if (PV1.Measure != PV2.Measure)
            {
                throw new InvalidOperationException("Ошибка операции");
            }
            return new PhysValue(PV1.Value - PV2.Value, PV1.Measure);
        }

        public static PhysValue operator /(PhysValue PV1, PhysValue PV2)
        {
            string NewMessure=null;
            if (PV1.Measure == PV2.Measure || PV1.Measure!=MeasurePr.Measures.Distance.ToString())
            {
                throw new InvalidOperationException("Ошибка операции");
            }

            if (PV1.Measure == MeasurePr.Measures.Distance.ToString() && PV2.Measure == MeasurePr.Measures.Speed.ToString())
            {
                NewMessure = MeasurePr.Measures.Time.ToString();
            }

            if (PV1.Measure == MeasurePr.Measures.Distance.ToString() && PV2.Measure == MeasurePr.Measures.Time.ToString())
            {
                NewMessure = MeasurePr.Measures.Speed.ToString();
            }
            return new PhysValue(PV1.Value / PV2.Value, NewMessure );
        }

        public static PhysValue operator *(PhysValue PV1, PhysValue PV2)
        {           
            if (
                (PV1.Measure != MeasurePr.Measures.Speed.ToString() || PV1.Measure != MeasurePr.Measures.Time.ToString())
                && (PV2.Measure != MeasurePr.Measures.Time.ToString() && PV2.Measure != MeasurePr.Measures.Speed.ToString())
                )
            {
                throw new InvalidOperationException("Ошибка операции");
            }
           
            return new PhysValue(PV1.Value * PV2.Value, MeasurePr.Measures.Distance.ToString());
        }
    }
}
