namespace Domain
{
    public class SchoolMembership
    {
        public Guid SchoolId { get; set; }   // Id della scuola e dello studente
        public Guid UserID { get; set; }
        public string Role { get; set; }

        public SchoolMembership(string role)
        {
            
            Role = role;
            Guid SchoolID = Guid.NewGuid();
            Guid UserID = Guid.NewGuid();
        }
    }
}
