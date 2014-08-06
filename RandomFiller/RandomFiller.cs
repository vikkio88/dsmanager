using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFiller
{
    public class RandomFiller
    {
        private Random rnd;
        private string[] names = { "Francesco", "Alessandro", "Andrea", "Lorenzo", "Matteo", "Mattia", "Gabriele", "Leonardo", "Riccardo", "Davide", "Tommaso", "Giuseppe", "Marco", "Luca", "Federico", "Antonio", "Simone", "Samuele", "Pietro", "Giovanni", "Filippo", "Alessio", "Edoardo", "Diego", "Christian", "Nicoló", "Gabriel", "Emanuele", "Cristian", "Michele" };
        private string[] surnames = { "Rossi", "Ferrari", "Russo", "Bianchi", "Esposito", "Colombo", "Romano", "Ricci", "Gallo", "Greco", "Conti", "Marino", "De Luca", "Bruno", "Costa", "Giordano", "Mancini", "Lombardi", "Barbieri", "Moretti", "Fontana", "Rizzo", "Santoro", "Caruso", "Mariani", "Martini", "Ferrara", "Galli", "Rinaldi", "Leone", "Serra", "Conte", "Villa", "Marini", "Ferri", "Bianco", "Monti" };
        public RandomFiller()
        {
            rnd = new Random();
        }

        public int getInt(){
            return rnd.Next(0, int.MaxValue);
        }

        public int getInt(int low, int max)
        {
            return rnd.Next(low, max);
        }

        public int getInt(int max)
        {
            return rnd.Next(0, max);
        }

        public string getName()
        {
            return names[rnd.Next(0, names.Count())];
        }
        public string getSurname()
        {
            return surnames[rnd.Next(0, surnames.Count())];
        }

    }
}
