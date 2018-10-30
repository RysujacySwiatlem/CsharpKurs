using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Imie();
                Wiek();
                Koniec();
            }
        }

        private static void Koniec()
        {
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// podanie wieku, działanie zależne od wieku
        /// </summary>
        private static void Wiek()
        {
            Console.Write("Podaj swój wiek: ");
            int wiek;
            bool wynik = int.TryParse(Console.ReadLine(), out wiek);
            if (wiek >= 18)
            {
                Console.WriteLine("Masz, napij się browara");
            }
            else if (wynik == false)
            {
                Console.WriteLine("Musisz wprowadzić liczbę");
            }
            else
            {
                Console.WriteLine("Proszę, oto Twoja herbata");
            }
        }
        /// <summary>
        /// Prośba o padanie imienia
        /// </summary>
        private static void Imie()
        {
            Console.Write("Wpisz swoje imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Witaj " + imie);
        }
    }
}
