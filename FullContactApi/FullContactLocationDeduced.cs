namespace FullContactApi
{
    public class FullContactLocationDeduced
    {
        public class LocationDeduced {
            public string NormalizedLocation { get; set; }
            public string DeducedLocation { get; set; }
            public FullContactCity City { get; set; }
            public FullContactContinent Continent { get; set; }
            public FullContactCountry Country { get; set; }
            public FullContactCounty County { get; set; }
            public FullContactState State { get; set; }
            public double? Likelihood { get; set; }
        }
    }
}
