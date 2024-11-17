

namespace _Tamrin_;
    class Proprime:calculator
    {
        public override bool IsTrue(uint number)
        {
            Console.WriteLine("proprime");
            bool check = true;

            for (int i = 2; (check && i < Math.Sqrt(number)); i++)
            if (number % i == 0)
                check = false;
                
            return check;
            
        }
    }

