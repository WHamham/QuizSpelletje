using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSpelletje
{
    class Quiz
    {   // nieuwe lijst
        List<Vraag> VragenLijst = new List<Vraag>();   
 
        public void AddVraag(Vraag v)
    {
        VragenLijst.Add(v);
    }

        
        // keuze categorie of mode
        public void ChoseCatOrMode(int input)
    {
        if (input == 1)
        {
            int i = 1;

            foreach (Vraag v in VragenLijst.Distinct())
            {
                Console.WriteLine($"{i}: {v.Categorie}");
                i++;
            }

            Console.WriteLine();
        }
        else if (input == 2)
        {
            Console.WriteLine("Mode: Hard, Normal, Easy \n");
        }
        else { Environment.Exit(0); }
    }
        // filters per categorie
        public void FilterCategorie()
        {
            Console.Write("Wat voor categorie zou u willen zien? \n" + "Voer de gewenste categorie in: ");
            
            string input = Console.ReadLine();
          
            while(input.GetType() == typeof(Int32)) {
                Console.WriteLine("Voer de categorie letterlijk in: ");
                input = Console.ReadLine();
            }

            Console.WriteLine();

            var QuestionWithCategorie = VragenLijst.Where(v => v.Categorie.ToLower() == input.ToLower()).ToList();

            int i = 1;
            foreach (Vraag v in QuestionWithCategorie)
            {
                Console.WriteLine($"{i}: {v}");
                i++;
            }
            ChoseVraag(QuestionWithCategorie);
        }

        // filter per moeilijkheidsgraad/modus
        public void FilterMode()
        {
            Console.Write("Hoe moeilijk wilt u uw vragen hebben? Voer de Modus letterlijk in: ");

            string input = Console.ReadLine();
            while(input.GetType() == typeof(Int32))
            {
                Console.WriteLine("Voer de mode letterlijk in: ");
                input = Console.ReadLine();
            }
          
            
            var QuestionWithMode = VragenLijst.Where(v => v.Mode == input).ToList();

            int i = 1;
            foreach (Vraag v in QuestionWithMode)
            {
                Console.WriteLine($"{i}: {v}");
                i++;
            }
            ChoseVraag(QuestionWithMode);
        }

        public void ChoseVraag(List<Vraag> inputvragen)
        {
            Console.WriteLine();
            Console.Write("Kies een vraag: ");
            int input = Int32.Parse(Console.ReadLine());

            Vraag vraagkeuze = inputvragen[input - 1];

            Console.Write("Uw antwoord: ");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Het goede antwoord is: " + vraagkeuze.CheckAntwoord(antwoord));
        }
    }
}

