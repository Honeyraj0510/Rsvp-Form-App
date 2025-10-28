namespace RsvpApp.Models
{
    public class Rsvp
    {
        public int Id { get; set; }  // Primary key
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public bool WillAttend { get; set; }
    }
}
