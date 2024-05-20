using PoBabyNames.Data;

namespace PoBabyNames.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string UserId { get; set; }
        public int NameId { get; set; }
        public int GroupId { get; set; }
        public int RatingValue { get; set; }
        public Name Name { get; set; }  // Navigation property
        public ApplicationUser User { get; set; }  // Navigation property
    }
}
