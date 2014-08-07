using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsManager.Models
{
    public class Module
    {
        private string selectedModule;
        public string[] modules = { "4-4-2","4-3-3","4-5-1","4-2-4","3-5-2","3-4-3","3-3-4","5-4-1","5-3-2"};
        private List<string> roles = new List<string>(){ "PT", "DC", "DD", "DS", "CC", "CD", "CS", "AD", "AS", "AC" };
        private int[] nplayr = { 0,0,0,0,0,0,0,0,0,0};
        private string p;

        public Module(string p)
        {
            // TODO: Complete member initialization
            this.selectedModule = p;
        }
        public string SelectedModule
        {
            set { selectedModule = value;}
            get { return selectedModule;}
        }

        //fare in modo che per ogni modulo ci siano degli interi che descrivono quanti giocatori servono per
        //ciascun ruolo

        public bool check(Team t, Module m)
        {
           
            foreach (Player pl in t.getPlayers())
            {
                int i = roles.IndexOf(pl.Role);
                if (i >= 0) nplayr[i] += 1;
            }
            int length = nplayr.Count();
            int[] needed = playerForRolesForModule(m.SelectedModule);
            for (int i = 0; i < length; i++)
            {
                if (nplayr[i] < needed[i]) return false;
            }

            return true;
        }

        private int[] playerForRolesForModule(string mod)
        {
            if (modules.Contains(mod))
            {
                switch (mod)
                {
                    //{ "PT", "DC", "DD", "DS", "CC", "CD", "CS", "AD", "AS", "AC" };
                    case "4-4-2":
                        return new List<int>() { 1, 2, 1, 1, 2, 1, 1, 0, 0, 2 }.ToArray();
                    case "4-3-3":
                        return new List<int>() { 1, 2, 1, 1, 3, 0, 0, 1, 1, 1 }.ToArray();
                    case "4-5-1":
                        return new List<int>() { 1, 2, 1, 1, 3, 1, 1, 0, 0, 1 }.ToArray();
                    case "4-2-4":
                        return new List<int>() { 1, 2, 1, 1, 0, 1, 1, 1, 1, 2 }.ToArray();
                   case "3-5-2":
                        return new List<int>() { 1, 3, 0, 0, 3, 1, 1, 0, 0, 2 }.ToArray();
                    case "3-4-3":
                        return new List<int>() { 1, 3, 0, 0, 2, 1, 1, 1, 1, 1 }.ToArray();
                    case "3-3-4":
                        return new List<int>() { 1, 3, 0, 0, 1, 1, 1, 1, 1, 2 }.ToArray();
                    case "5-4-1":
                        return new List<int>() { 1, 3, 1, 1, 2, 1, 1, 0, 0, 1 }.ToArray();
                    case "5-3-2":
                        return new List<int>() { 1, 3, 1, 1, 3, 0, 0, 0, 0, 2 }.ToArray();
                    default:
                        return new List<int>() { 0 }.ToArray();
                        
                }



            }
            else
            {
                throw new InvalidOperationException("Modulo non esistente");
            }
        }
    }
}
