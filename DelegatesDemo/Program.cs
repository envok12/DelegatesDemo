using System;

namespace DelegatesDemo
{
    delegate void DispStrDelegate(string param);
    class Program
    {
        static void Capitalize(string text)
        {
            Console.WriteLine("Your input capatilized " + text.ToUpper());
        }

        static void LowerCased(string text)
        {
            Console.WriteLine("Your input lower cased " + text.ToLower());            
        }

        static void RunMyDelegate(DispStrDelegate del, string textParam)
        {
            del(textParam);
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter some text: ");
            String text = Console.ReadLine();

            DispStrDelegate saying1 = Capitalize;
            DispStrDelegate saying2 = LowerCased;
            DispStrDelegate saying3 = Console.WriteLine;

            saying1(text);
            saying2(text);
            saying3(text);

            DispStrDelegate sayings = new DispStrDelegate(Capitalize);
            sayings += new DispStrDelegate(LowerCased);
            sayings += new DispStrDelegate(Console.WriteLine);

            Console.WriteLine("Running multi cast directly: ");
            sayings(text);

            Console.WriteLine("Running by passing delegate to another method: ");

            RunMyDelegate(sayings, text); 
        }
    }
}
