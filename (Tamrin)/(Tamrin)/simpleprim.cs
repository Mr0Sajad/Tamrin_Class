 

namespace _Tamrin_;

    class Simpleprim:calculator
    {
        public override bool IsTrue(uint number)
        {
            Console.WriteLine("simple prime");
            bool check = true;

                for (int i = 2; (check && i < number); i++)
                    if (number % i == 0)
                        check = false;

                return check;
        }
    }

