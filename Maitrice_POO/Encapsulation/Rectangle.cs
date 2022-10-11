namespace Maitrice_POO.Encapsulation
{
    public class Rectangle
    {
		private long _longeur;
        private long _largeur;
       
        public long Longeur
		{
			get { return _longeur; }
			private set 
			{
                if (value > 0)
                    _longeur = value;
                else
                    throw new ArgumentOutOfRangeException("Longeur", "La longeur du rectangle doit être supérieur à 0");
            }
		}

		public long Largeur
		{
			get { return _largeur; }
			private set 
			{
                if (value > 0)
                    _largeur = value; 
                else
                    throw new ArgumentOutOfRangeException("Largeur", "La largeur du rectangle doit être supérieur à 0");
            }
		}

        public Rectangle(long longeur, long largeur)
        {
            Longeur = longeur;
            Largeur = largeur;
        }

        public Rectangle()
        {
            Longeur = 1;
            Largeur = 1;
        }
        
        public double Aire
        {
            get { return _longeur * _largeur; }
        }

        public double Perimetre
        {
            get { return 2 * (_longeur + _largeur); }
        }

        public void Redim(long longeur, long largeur)
        {
            Longeur = longeur;
            Largeur = largeur;
        }
    }
}
