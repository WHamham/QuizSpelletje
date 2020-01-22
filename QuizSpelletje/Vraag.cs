using System;
using System.Linq;

namespace QuizSpelletje
{
    class Vraag : IEquatable<Vraag>
    {
        public string Mode;
        public string VraagText;
        public string Antwoord;
        public string Categorie;

       // Gebruiker kan kiezen tussen Hard, Normal of Easy vragen.
        public Vraag(string mode, string vraagtext, string antwoord, string categorie)
        {
            if (new string[] { "Hard", "Normal", "Easy" }.Contains(mode))
            {
                Mode = mode;
            }
          
           this.VraagText = vraagtext;
           this.Antwoord = antwoord;
           this.Categorie = categorie;
        }
       

        public bool CheckAntwoord(string GoedeAntwoord)
        {
            return Antwoord == GoedeAntwoord;
        }

        public bool Equals (Vraag other)
        {
            return Categorie == other.Categorie;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return ($"{VraagText}"); ;
        }
    }
}



