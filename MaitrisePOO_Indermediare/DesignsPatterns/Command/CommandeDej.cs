using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Command
{
    internal class CommandeDej : ICommander
    {        
        public enum Etats
        {
            Cree,
            Preparer
        }
        
        private ChefCuisine _chefCuisine;
        public string ContentCommand { get; set; }

        public Etats EtatCommande { get; set; }

        public CommandeDej(ChefCuisine chefCuisine, string contentCommand)
        {
            _chefCuisine = chefCuisine;
            ContentCommand = contentCommand;
            EtatCommande = Etats.Cree;
        }

        public void Execute()
        {
            _chefCuisine.CusinerDejeuner(ContentCommand);
            EtatCommande = Etats.Preparer;
        }
    }
}
