namespace GuuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            string Guess = "";
            int GuessCount = 0;
            int GuessLimit = 5;
            bool OutofGuesses = false;

            Console.WriteLine("Ingresa la palabra secreta: ");
            string SecretWord = Console.ReadLine();

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("|");
            }

            while (Guess != SecretWord && !OutofGuesses)
            {
                if (GuessCount < GuessLimit)
                {
                    Console.WriteLine("Ingrese una palabra: ");
                    Guess = Console.ReadLine();
                    GuessCount++;
                } else
                {
                    OutofGuesses = true;
                }

            } 
            if (OutofGuesses)
            {
                Console.WriteLine("¡Perdio el juego!");
            }else
            {
                Console.WriteLine("¡Gano el juego!")
;            }
        }
    }
}
