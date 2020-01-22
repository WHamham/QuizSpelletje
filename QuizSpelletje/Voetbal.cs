using System;


namespace QuizSpelletje
{
    class Voetbal
    {
        static void Main(string[] args)
        {   // nieuw object met 3 verschillende vragen, elk met een eigen Modus/Mode.
            Quiz QuizOverVoetbal = new Quiz();

            QuizOverVoetbal.AddVraag(new Vraag("Hard", "Wie is Virgil van Dijk?", "Een verdediger van de Nederlandse elftal", "Spelers"));
            QuizOverVoetbal.AddVraag(new Vraag("Normal", "Wie is Jaap Stam?", "Een trainer van een voetbal club", "Trainers"));
            QuizOverVoetbal.AddVraag(new Vraag("Easy", "Wie is C. Ronaldo?", "Een trainer van een Legende", "Legende"));

            Console.WriteLine("Goedendag Voetbalfan! \n");

            Console.WriteLine("Dit is de Legendarische VoetbalQuiz \n" + "Er volgt nu een keuzemenu");
            // met while een keuzemenu.
            while (true)
            {
                Console.WriteLine("1: Categorie \n" + "2: Modus \n" + "3: Exit \n");

                Console.Write("Toets 1 in als u Categorie kiest, Toets 2 in als u Modus kiest, Toets 3 als u de quiz wilt verlaten: ");
                // cijfer input
                int input = Int32.Parse(Console.ReadLine());

                Console.WriteLine();

                QuizOverVoetbal.ChoseCatOrMode(input);

                // 1 = categorie en 2 = mode
                if (input == 1)
                {
                    QuizOverVoetbal.FilterCategorie();
                }
                else if (input == 2)
                {
                    QuizOverVoetbal.FilterMode();
                }

                Console.WriteLine();
            }

        }
    }
}


