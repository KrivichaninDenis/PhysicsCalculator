namespace PhysicsCalculator.Speed
{
   public class MeterPerSecond:PhysValue
    {
        

        public MeterPerSecond(double value) 
        {
            Value = value;
            Measure = "м/с";
        }
               

        public override string ToString()
        {
            return string.Format(Value + " " + Measure);
        }
    }
}
