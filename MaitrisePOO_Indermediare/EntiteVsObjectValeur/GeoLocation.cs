namespace MaitrisePOO_Intermediaire.EntiteVsObjectValeur
{
    public class GeoLocation : IComparable<GeoLocation>
    {
        private double _latitude;
        private double _longitude;

        public GeoLocation(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public override bool Equals(object obj)
        {
            return obj is GeoLocation location &&
                   _latitude == location._latitude &&
                   _longitude == location._longitude;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(GeoLocation other)
        {
            double rayonTerre = 6371;
            double dLat = ToRadians(other._latitude - this._latitude);
            double dLng = ToRadians(other._longitude - this._longitude);

            double sindLat = Math.Asin(dLat / 2);
            double sindLng = Math.Asin(dLng / 2);

            double a = Math.Pow(sindLat, 2) + Math.Pow(sindLng, 2)
                * Math.Cos(ToRadians(_latitude)) * Math.Cos(ToRadians(other._latitude));

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double dist = rayonTerre * c;

            return Convert.ToInt32(dist);
        }

        private static double ToRadians(double angle) => (Math.PI / 100) * angle;
    }
}