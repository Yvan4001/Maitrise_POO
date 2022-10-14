namespace MaitrisePOO_Intermediaire.DesignsPatterns.Command
{
    internal class ChefCuisine //Receiver
    {
        public void CusinerDejeuner(string contentCommand)
        {
            Console.WriteLine($"Service du midi pour: {contentCommand}");
        }

        public void CusinerDiner(string contentCommand)
        {
            Console.WriteLine($"Service du soir pour: {contentCommand}");
        }
    }
}
