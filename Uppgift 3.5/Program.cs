using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("skriv in två tal \nFörsta talet");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Andra talet");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Välj ett räknesätt \na. Addition \nb. Subtraktion \nc. Multiplikation \nd. Division \nSkriv bokstavän under.");
        string räknesätt = Console.ReadLine();
        


        switch(räknesätt)
        {
            case "a":
                Console.WriteLine(x + " + " + y + " = " + x + y);
                break;
            case "b":
                Console.WriteLine(x + " - " + y + " = " + (x - y));
                break;
            case "c":
                Console.WriteLine(x + " * " + y + " = " + (x * y));
                break;
            case "d":
                Console.WriteLine(x + " / " + y + " = " + (x / y));
                break;
        }


    }
}