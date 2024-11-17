using _Tamrin_;


while (true)
{
    char key = keyboard.GetHomeKey();
    Console.Clear();
    uint number;
    switch (key)
    {
        case 'A' or 'a':
            number = keyboard.GetNumer();
            if (number >= 1000)
            {
                Proprime pp = new Proprime();
                bool res = pp.IsTrue(number);
                Console.WriteLine(res);
            }
            else
            {
                Simpleprim sp = new Simpleprim();
                bool res = sp.IsTrue(number);
                Console.WriteLine(res);
            }
            break;
        case 'B' or 'b':
            number = keyboard.GetNumer();
            Palindrome Pal = new Palindrome();
            bool resPal = Pal.IsTrue(number);
            Console.WriteLine(resPal);
            break;
        case 'C' or 'c':
            DT.dt();
            break;
    }
    Console.WriteLine();
    Console.WriteLine("Bemonim ?");
    var ans = keyboard.GetYOrN();
    Console.Clear();
    if (ans)
    {
        continue;
    }
    else
    {
        break;
    }
    
}

