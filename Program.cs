namespace Generator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string volwes = "aeiou";
            string consonants = "qQwWrRtTyYpPñÑlLkKJjHhGgFfDdSsZzxCXcvVBbnNMm";
            string charSpecial = "@#/$?¿_-.";
            Random rand = new();
            List<string> pass = new();
            for (int i = 0; i < 4; i++)
            {
                int numberAleatory = rand.Next(0, consonants.Length);
                string letter = consonants[numberAleatory].ToString();
                pass.Add(letter);
            }

            for (int i = 0; i < 4; i++)
            {
                int numberAleatory = rand.Next(0, volwes.Length);
                pass.Add(volwes[numberAleatory].ToString());

            }

            for (int i = 0; i <3; i++)
            {
                int numberAleatory = rand.Next(0, 9);
                pass.Add(numberAleatory.ToString());

            }

            pass.Add(charSpecial[rand.Next(0, charSpecial.Length)].ToString());
            pass.Add(charSpecial[rand.Next(0, charSpecial.Length)].ToString());

            pass = pass.OrderBy(x => rand.Next()).ToList();

            string password = string.Join("", pass);

            Console.WriteLine(password);
        }


    }
}