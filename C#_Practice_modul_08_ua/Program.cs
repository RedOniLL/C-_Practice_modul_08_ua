namespace C__Practice_modul_08_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice");
            int c = int.Parse( Console.ReadLine());
            switch (c)
            {
                case 0:
                    Fraction frac1 = new Fraction { Numerator = 1, Denominator = 2 };
                    Fraction frac2 = new Fraction { Numerator = 3, Denominator = 4 };

                    Console.WriteLine($"Sum of fractions: {frac1.Add(frac2)}");
                    Console.WriteLine($"Difference of fractions: {frac1.Subtract(frac2)}");
                    Console.WriteLine($"Product of fractions: {frac1.Multiply(frac2)}");
                    Console.WriteLine($"Quotient of fractions: {frac1.Divide(frac2)}");
                    break;
                case 1:
                    ComplexNumber num1 = new ComplexNumber { RealPart = 1, ImaginaryPart = 2 };
                    ComplexNumber num2 = new ComplexNumber { RealPart = 3, ImaginaryPart = 4 };

                    
                    ComplexNumber sum = num1.Add(num2);
                    Console.WriteLine($"Sum: {sum}");

                    
                    ComplexNumber difference = num1.Subtract(num2);
                    Console.WriteLine($"Difference: {difference}");

                   
                    ComplexNumber product = num1.Multiply(num2);
                    Console.WriteLine($"Product: {product}");

                    
                    ComplexNumber quotient = num1.Divide(num2);
                    Console.WriteLine($"Quotient: {quotient}");
                    break ;
                case 2:
                    Birthday personBirthday = new Birthday();
                    personBirthday.SetBirthday(1, 4, 2000); 
                    string dayOfWeekOfBirth = personBirthday.GetDayOfWeekOfBirth();
                    Console.WriteLine($"Day of the week of birth: {dayOfWeekOfBirth}");
                   
                    string dayOfWeekOfFutureBirthday = personBirthday.GetDayOfWeekOfFutureBirthday(2025);
                    Console.WriteLine($"Day of the week of the future birthday: {dayOfWeekOfFutureBirthday}");

                    int daysUntilBirthday = personBirthday.GetDaysUntilBirthday();
                    Console.WriteLine($"Days until birthday: {daysUntilBirthday}");
                    break;
            }
        }
    }
}
