namespace FullContactApi
{
    class FullContactPersonResponse
    {
        public FullContactContactInfo ContactInfo { get; set; }
        public FullContactDemographics Demographics { get; set; }
        public FullContactDigitalFootprint DigitalFootprint { get; set; }
        public double? Likelihood { get; set; }
        public FullContactOrganization[] Organizations { get; set; }
        public FullContactPhoto[] Photos { get; set; }
        public string RequestId { get; set; }
        public FullContactSocialProfile[] SocialProfiles { get; set; }
        public int? Status { get; set; }
    }
}
