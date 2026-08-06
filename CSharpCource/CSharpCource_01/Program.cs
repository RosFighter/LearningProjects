namespace CSharpCource_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            nameConcat = "My " + "name " + "is " + "John";
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "Hi there! ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 3);   // удалит 3 символа, начиная с 0
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            replaced = nameConcat.Replace("John", "Ivan!");
            Console.WriteLine(replaced);

            string data = "67584;87068;5687345;132,8907,35453";
            string[] splitData = data.Split(";");
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[5]);
            Console.WriteLine(nameConcat[5]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);
            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John! ";
            Console.WriteLine(john.Trim());
        }

        static void TestEnter()
        {
            string data = null;
            data = Console.ReadLine();
            
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
