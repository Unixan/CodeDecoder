namespace CodeDecoder
{
    internal class Program
    {
        static void Main()
        {
            char[] letters = new[]
            {
                ' ','!','.','?',',','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','Æ','Ø','Å' };
            char[] cipher = new char[34];
            Console.WriteLine(cipher.Length);
            string input = "Noe";
            while (input.Length > 0)
            {
                Console.WriteLine("Skriv inn tekst som skal kodes:");
                input = Console.ReadLine();
                Console.WriteLine();
                string upper = input.ToUpper();
                string code = "";
                string original = "";
                foreach (var letter in upper)
                {
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (letters[i] == letter)
                        {
                            code += cipher[i];
                        }
                    }
                }
                Console.WriteLine("Kodet tekst:");
                Console.WriteLine(code);
                Console.WriteLine();
                foreach (var letter in code)
                {
                    for (int i = 0; i < cipher.Length; i++)
                    {
                        if (cipher[i] == letter)
                        {
                            original += letters[i];
                        }
                    }
                }
                Console.WriteLine("Original tekst:");
                Console.WriteLine(original);
                Console.WriteLine(letters.Length);
                Console.WriteLine();
            }


        }
    }
}