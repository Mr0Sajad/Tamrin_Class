
namespace _Tamrin_;

     class Palindrome:calculator
    {
        public override bool IsTrue(uint number)
        {
            Console.WriteLine("palindrome");

            uint tmp_number = number;
            uint reverse = 0;
            bool check = false;
            while (tmp_number != 0)
            {
                reverse = (reverse * 10) + tmp_number % 10;
                tmp_number /= 10;
            }

            if (number == reverse)
                check = true;
            else
                check = false;
            return check;
        }
    } 
