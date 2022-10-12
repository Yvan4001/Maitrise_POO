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
            double earthRadius = 6371; //Kilometers
            double dLat = ToRadians(other._latitude - this._latitude);
            double dLon = ToRadians(other._longitude - this._longitude);

            double sinLat = Math.Asin(dLat / 2);
            double sinLon = Math.Asin(dLon / 2);

            double a = Math.Pow(sinLat, 2) + Math.Pow(sinLon, 2)
                * Math.Cos(ToRadians(this._latitude)) * Math.Cos(ToRadians(other._latitude));

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = earthRadius * c;

            return Convert.ToInt32(distance);
        }

        private static double ToRadians(double angle) => (Math.PI / 180) * angle;
    }
}