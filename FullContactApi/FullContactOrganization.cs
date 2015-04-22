namespace FullContactApi
{
    public class FullContactOrganization
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }  // formatted as "YYYY-MM"
        public string EndDate { get; set; }   // formatted as "YYYY-MM"
        public bool? IsPrimary { get; set; }
        public bool? Current { get; set; }
    }
}
