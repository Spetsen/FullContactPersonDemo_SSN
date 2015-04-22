namespace FullContactApi
{
    public class FullContactContactInfo
    {
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string FullName { get; set; }
        public string[] MiddleNames { get; set; }
        public FullContactWebsite[] Websites { get; set; }
        public FullContactChat[] Chats { get; set; }
    }
}
