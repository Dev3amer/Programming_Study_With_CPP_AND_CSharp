namespace CalculatorWithOperations
{
    class clsCalculator
    {
        public delegate void delPrintResultMethod(string LastOperation, float LastNumber, float Result);

        private float _Result = 0;
        private float _LastNumber = 0;
        private string _LastOperation = "Clear";

        private bool _IsZero(float Number)
        {
            return (Number == 0);
        }

        public void Add(float Number)
        {
            _LastNumber = Number;
            _LastOperation = "Adding";
            _Result += Number;
        }

        public void Subtract(float Number)
        {
            _LastNumber = Number;
            _LastOperation = "Subtracting";

            _Result -= Number;
        }

        public bool Divide(float Number)
        {

            bool Succeeded = true;
            _LastOperation = "Dividing";

            if (_IsZero(Number))
            {
                _LastNumber = Number;
                _Result /= 1;
                Succeeded = false;
            }
            else
            {
                _LastNumber = Number;
                _Result /= Number;
            }

            return Succeeded;
        }

        public void Multiply(float Number)
        {
            _LastNumber = Number;
            _LastOperation = "Multiplying";
            _Result *= Number;
        }

        public float GetFinalResults()
        {
            return _Result;
        }

        public void Clear()
        {
            _LastNumber = 0;
            _LastOperation = "Clear";
            _Result = 0;
        }

        public void PrintResult(delPrintResultMethod PrintResultMethod)
        {
            PrintResultMethod(_LastOperation, _LastNumber, _Result);
        }
        
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintOnScreen(string LastOperation, float LastNumber, float Result)
            {
                Console.WriteLine("Result After {0} {1} is : {2}", LastOperation, LastNumber, Result);
            }

            static void PrintOnFile(string LastOperation, float LastNumber, float Result)
            {
                using (StreamWriter writer = new StreamWriter("Calculations.txt",true))
                {
                    writer.WriteLine("Result After {0} {1} is : {2}", LastOperation, LastNumber, Result);
                }
            }

            static void SaveInMemory(string LastOperation, float LastNumber, float Result)
            {
               string s = $"Result After {LastOperation} {LastNumber} is : {Result}";
                Console.WriteLine($"Result Saved In VAR (s) In Memeory With Value: {s}");
            }

            clsCalculator Calculator1 = new clsCalculator();


            Calculator1.Clear();

            Calculator1.Add(10);
            Calculator1.PrintResult(PrintOnScreen);

            Calculator1.Add(100);
            Calculator1.PrintResult(SaveInMemory);

            Calculator1.Subtract(20);
            Calculator1.PrintResult(PrintOnFile);
        }
    }
}