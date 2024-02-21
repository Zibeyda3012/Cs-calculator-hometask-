
using System.ComponentModel;

int select = 1;

do
{
    Console.Clear();

    if (select == 1)
    {
        Console.WriteLine("\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\t\t\t=> Calculator");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t\t\t=> Exit");
        Console.WriteLine("\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }

    else if (select == 2)
    {
        Console.WriteLine("\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("\t\t\t\t=> Calculator");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\t\t\t=> Exit");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }

    ConsoleKeyInfo info = Console.ReadKey(true);

    if (info.Key == ConsoleKey.UpArrow)
    {
        if (select == 1) select = 2;
        else select--;
    }

    else if (info.Key == ConsoleKey.DownArrow)
    {
        if (select == 2) select = 1;
        else select++;
    }

    else if (info.Key == ConsoleKey.Enter)
    {
        if (select == 1)
        {
            Console.Clear();
            double num1, num2;
            Console.Write("Enter num1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Calculator(num1, num2);



        }

        else if (select == 2)
        {
            Console.Clear();
            break;
        }
    }





} while (true);

void Calculator(double num1, double num2)
{
    int choice = 1;

    do
    {
        Console.Clear();

        switch (choice)
        {
            case 1:
                Console.Write($"{num1} + {num2} = ");
                Add(num1, num2);
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Addition(+)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Subtraction(-)");
                Console.WriteLine("Multiplication(*)");
                Console.WriteLine("Division(/)");
                break;

            case 2:

                Console.Write($"{num1} - {num2} = ");
                Subtraction(num1, num2);
                Console.WriteLine("\n");

                Console.WriteLine("Addition(+)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Subtraction(-)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Multiplication(*)");
                Console.WriteLine("Division(/)");
                break;

            case 3:
                Console.Write($"{num1} * {num2} = ");
                Multiplication(num1, num2);
                Console.WriteLine("\n");

                Console.WriteLine("Addition(+)");
                Console.WriteLine("Subtraction(-)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Multiplication(*)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Division(/)");
                break;

            case 4:
                try
                {
                    Console.Write($"{num1} / {num2} = ");
                    Division(num1, num2);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("\n"+ex.Message);
                }

                Console.WriteLine("\n");

                Console.WriteLine("Addition(+)");
                Console.WriteLine("Subtraction(-)");
                Console.WriteLine("Multiplication(*)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Division(/)");
                Console.ForegroundColor = ConsoleColor.White;
                break;

        }

        ConsoleKeyInfo button=Console.ReadKey(true);

        if(button.Key==ConsoleKey.UpArrow)
        {
            if (choice == 1) choice = 4;
            else
                choice--;
        }

        if (button.Key == ConsoleKey.DownArrow)
        {
            if (choice == 4) choice = 1;
            else
                choice++;
        }

        else if (button.Key == ConsoleKey.Backspace)
            return;


    } while (true);

}

void Add(double num1, double num2)
{
    double result = num1 + num2;
    Console.WriteLine(result);
}

void Subtraction(double num1, double num2)
{
    double result = num1 - num2;
    Console.WriteLine(result);

}

void Multiplication(double num1, double num2)
{
    double result = num1 * num2;
    Console.WriteLine(result);

}

void Division(double num1, double num2)
{
    double result;
    if (num2 != 0)
    {
        result = num1 / num2;
        Console.WriteLine(result);
    }
    else
    {
        throw new Exception("Division to zero is not possible");
    }

}

