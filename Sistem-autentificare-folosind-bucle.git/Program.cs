using System;

class Program
{
    const string UserValid = "utilizator";
    const string ParolaValida = "parola123";

    static void Main()
    {
        while (true)
        {
            Console.Write("Introduceti username: ");
            string username = Console.ReadLine();

            Console.Write("Introduceti parola: ");
            string parola = Console.ReadLine();

            if (Autentificare(username, parola))
            {
                Console.WriteLine($"Bine ai venit, {username}!");
            }
            else
            {
                Console.WriteLine("Autentificare esuata. Incercati din nou.");
            }
        }
    }

    static bool Autentificare(string username, string parola)
    {
        return username == UserValid && parola == ParolaValida;
    }
}
