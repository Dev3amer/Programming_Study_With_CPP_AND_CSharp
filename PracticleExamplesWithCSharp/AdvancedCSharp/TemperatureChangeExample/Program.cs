namespace TemperatureChangeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat1 = new Thermostat(10);
            Display display1 = new Display();

            display1.SubscribeThermostat(thermostat1);

            thermostat1.UpdateTemprature(35);
            thermostat1.UpdateTemprature(50);
        }
    }
    public class TempratureEventArgs : EventArgs
    {
        public float OldTemprature { get; set; }
        public float NewTemprature { get; set; }
        public float Differance { get; set; }
        public TempratureEventArgs(float oldTemprature, float newTemprature)
        {
            this.OldTemprature = oldTemprature;
            this.NewTemprature = newTemprature;
            this.Differance = newTemprature - oldTemprature;
        }
    }
    public class Thermostat
    {
        private float _CurrentTemprature;
        private float _OldTemprature;

        public event EventHandler<TempratureEventArgs> OnCalculateTemprature;
        public Thermostat(float currentTemprature)
        {
            this._CurrentTemprature = currentTemprature;
        }

        public void UpdateTemprature(float newTemprature)
        {
            if (newTemprature != _CurrentTemprature)
            {
                _OldTemprature = _CurrentTemprature;
                _CurrentTemprature = newTemprature;

                OnCalculateTemprature?.Invoke(this, new TempratureEventArgs(_OldTemprature, newTemprature));
            }
        }
    }
    public class Display
    {
        public void SubscribeThermostat(Thermostat thermostat)
        {
            thermostat.OnCalculateTemprature += DisplayTempratureChangedOnScreen;
        }
        public void DisplayTempratureChangedOnScreen(object sender, TempratureEventArgs e)
        {
            Console.WriteLine("Temprature Changed:");
            Console.WriteLine($"New Temprature = {e.NewTemprature}");
            Console.WriteLine($"Old Temprature = {e.OldTemprature}");
            Console.WriteLine($"Differance = {e.Differance}");
        }
    }

}