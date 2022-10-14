using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Command
{
    internal class CommandeDin : ICommander
    {
        public enum Etats
        {
            Cree,
            Preparer
        }

        private ChefCuisine _chefCuisine;
        public string ContentCommand { get; set; }

        public Etats EtatCommande { get; set; }

        public CommandeDin(ChefCuisine chefCuisine, string contentCommand)
        {
            _chefCuisine = chefCuisine;

            EtatCommande = Etats.Cree;
            ContentCommand = contentCommand;
        }

        public void Execute()
        {
            _chefCuisine.CusinerDiner(ContentCommand);
            EtatCommande = Etats.Preparer;
        }
    }
}
