﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFiller
{
    public class RandomFiller
    {
        private Random rnd;
        private string[] namesIta = { "Francesco", "Alessandro", "Andrea", "Lorenzo", "Matteo", "Mattia", "Gabriele", "Leonardo", "Riccardo", "Davide", "Tommaso", "Giuseppe", "Marco", "Luca", "Federico", "Antonio", "Simone", "Samuele", "Pietro", "Giovanni", "Filippo", "Alessio", "Edoardo", "Diego", "Christian", "Nicoló", "Gabriel", "Emanuele", "Cristian", "Michele" };
        private string[] surnamesIta = { "Rossi", "Ferrari", "Russo", "Bianchi", "Esposito", "Colombo", "Romano", "Ricci", "Gallo", "Greco", "Conti", "Marino", "De Luca", "Bruno", "Costa", "Giordano", "Mancini", "Lombardi", "Barbieri", "Moretti", "Fontana", "Rizzo", "Santoro", "Caruso", "Mariani", "Martini", "Ferrara", "Galli", "Rinaldi", "Leone", "Serra", "Conte", "Villa", "Marini", "Ferri", "Bianco", "Monti" };
        private string[] namesSpa = { "Luciano", "Esteban", "Mariano", "Carlos", "Fernando", "Jose", "Juan", "Luis", "Carlito", "Inacio","Diego","Antonio","Pablo","Juan","Andrés","Luis","Enrique","Emilio" };
        private string[] surnamesSpa = { "Lopez", "Almagro", "Barros", "Duque", "Fernandez", "Garzon", "Ibanez", "Lamas", "Montero", "García","González", "Rodríguez", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez", "Martín", "Jiménez", "Ruiz", "Hernández", "Diáz", "Moreno" };
        private string[] roles = { "PT", "DC", "DD", "DS", "CC", "CD", "CS", "AD","AS","AC" };
        public string[] modules = { "4-4-2", "4-3-3", "4-5-1", "4-2-4", "3-5-2", "3-4-3", "3-3-4", "5-4-1", "5-3-2" };

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

        public int getAge()
        {
            return getInt(15, 39);
        }

        public int getAvgSkill()
        {
            return getInt(40, 100);
        }

        public string getName()
        {
            return namesIta[rnd.Next(0, namesIta.Count())];
        }
        public string getSurname()
        {
            return surnamesIta[rnd.Next(0, surnamesIta.Count())];
        }



        public string getName(string n)
        {
            if (n == "Spain")
            {
                return namesSpa[rnd.Next(0, namesSpa.Count())];
            }

            return namesIta[rnd.Next(0, namesIta.Count())];

        }

        public string getSurname(string n)
        {
            if (n == "Spain")
            {
                return surnamesSpa[rnd.Next(0, surnamesSpa.Count())];
            }

            return surnamesIta[rnd.Next(0, surnamesIta.Count())];

        }

        public string getRole()
        {
            return roles[rnd.Next(0, roles.Count())];
        }

        public string getModules()
        {
            return modules[rnd.Next(0, modules.Count())];
        }

        public string getCity()
        {
            string[] cities = {"Aosta","Torino","Padova","Biella","Milano","Varese","Bergamo","Pavia","Venezia","Vicenza","Udine","Trieste","Trento","Firenze","Livorno","Prato","Bologna","Reggio Emilia","Rimini","Pescara","Roma","Viterbo","Salerno","Napoli","Chieti","Foggia","Bari","Taranto","Catanzaro","Palermo","Catania","Cagliari","Sassari"};
            return cities[rnd.Next(0, cities.Count())];
        }

        public string getTeamName()
        {
            string[] pre = { "Real", "Sporting", "Atletico"};
            string[] suf = { "AC", "FC", "AS", "UTD", "Calcio"};
            string temp = "";
            if (getInt(100) > 50) temp += pre[getInt(0, pre.Count())] + " ";
            temp += getCity();
            if (getInt(100) > 50) temp +=" "+ suf[getInt(0, suf.Count())];

            return temp;
        }
    }
}
