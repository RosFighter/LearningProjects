using System.Text;

namespace CSharpCource_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }

        static void FormatString()
        {
            // форматировнаие строк
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1} years old.", name, age);
            // Console.WriteLine(str1);

            str1 = "My name is " + name + " and I'm " + age + "yars old.";
            // Console.WriteLine(str1);

            string str2 = $"My name is {name} and I'm {age} years old.";
            // Console.WriteLine(str2);

            // перевод каретки на новую строку
            string str3 = "My name is \nJohn";  // для винды
            str3 = "My name is \r\nJohn";   // для некоторых платформ (пока не знаю, каких именно)
            str3 = $"My name is {Environment.NewLine}John";     // одинаково для любой платформы

            // экранирование спец.символов
            // \" - кавычка
            // \n - новая строка
            // \t - табуляция
            // \\ - одинарный слеш
            string str4 = "C:\\tmp\\test_files.txt";
            string str5 = @"C:\tmp\test_files.txt";     // @ перед кавычкой заставит показать строку "как есть", экранирование не требуется


            Console.WriteLine(str5);

        }
        static void String_Builder()
        {
            // построитель строк; выгоден при конкатенации (объединении) более чем 7 строк
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);

        }

        static void StringEditing()
        {
            // методы изменения строк
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
