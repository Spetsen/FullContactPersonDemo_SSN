namespace FullContactApi
{
    public class FullContactDemographics
    {
        public string LocationGeneral { get; set; }
        public FullContactLocationDeduced LocationDeduced { get; set; }

        public string Age { get; set; }
        public string Gender { get; set; }
        public string AgeRange { get; set; }
    }
}
