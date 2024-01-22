using System;
using System.Threading;
using MethodLibraryHeroisvsMonstrell;
namespace M03UF2PR1
{
    public class HeroisVsMonstre2
    {


        public static void Main()
        {
            const string Play = "Què vols fer? \n1. Iniciar una nova batalla\n0. Sortir", Difficulty = "Selecciona una dificultat \n1. Fàcil\n2. Difícil\n3. Personalitzat\n4. Aleatori";

            int play, difficulty, errors = 0;


            Console.WriteLine(Play);
            play = Convert.ToInt32(Console.ReadLine());
            while ((play != 0 && play != 1) || errors == 3)
            {
                errors++;
                Console.WriteLine(Play);
                play = Convert.ToInt32(Console.ReadLine());
            }
            if (play == 1)
            {
                do
                {
                    Console.WriteLine(Difficulty);
                    difficulty = Convert.ToInt32(Console.ReadLine());
                } while (difficulty != 1 && difficulty != 2 && difficulty != 3 && difficulty != 4);
                errors = 0;
            }
        }
    }
}