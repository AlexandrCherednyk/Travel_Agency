namespace DAL.Entities
{
    public enum DistanceFromTheSea
    {
        FirstCoastline,
        SecondCoastline,
        ThirdCoastline
    }
    public class BeachHotel : Hotel
    {
        public DistanceFromTheSea DistanceFromTheSea { get; set; }
        public BeachHotel() { }
        public BeachHotel(string name, string country, StarCategory starRating, DistanceFromTheSea coastLine) : base(name, country, starRating)
        {
            DistanceFromTheSea = coastLine;
        }
    }
}
