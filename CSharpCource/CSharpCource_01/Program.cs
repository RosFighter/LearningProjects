namespace CSharpCource_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            
            Console.WriteLine("Привет, " + data + "!");

            // временное изменение

        }

        static void TestStrings()
        { 
            string name = "abrakadabra";

            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            bool startWithAbra = name.StartsWith("abra");
            Console.WriteLine(endsWithAbra);
            Console.WriteLine(startWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);
        }
    }
}
