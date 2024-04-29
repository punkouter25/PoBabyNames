namespace PoBabyNames.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string UserId { get; set; }  // Link to IdentityUser
        public int NameId { get; set; }
        public int GroupId { get; set; }
        public int RatingValue { get; set; }
    }
}
