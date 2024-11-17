
namespace _Tamrin_;

class keyboard
{
    public static uint GetNumer()
    {
        Console.WriteLine("please Enter Number:");

        char key;
        uint number = 0;
        do
        {

            do
            {
                key = Console.ReadKey(true).KeyChar;


            } while (!char.IsDigit(key) && key != '\r');

            if (key != '\r')
            {
                Console.Write(key);
                number = (uint)(number * 10 + Convert.ToInt32(key.ToString()));
            }


        } while (key != '\r');

        Console.WriteLine();
        Console.WriteLine(number);


        return number;
    }

    public static bool GetYOrN()
    {

        Console.WriteLine("please Enter y or n:");

        char key;
        do
        {
            key = Console.ReadKey(true).KeyChar;


        } while (key is not ('y' or 'Y' or 'n' or 'N'));

        Console.WriteLine(key);

        return key != 'n' && key != 'N';
    }

    public static char GetHomeKey()
    {
        Console.WriteLine("prime:  A");
        Console.WriteLine("palindrome:  B");
        Console.WriteLine("DT:  C");
        char key = Console.ReadKey().KeyChar;
        
        return key;
    }
}
    

