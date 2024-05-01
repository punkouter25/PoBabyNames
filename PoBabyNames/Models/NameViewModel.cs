namespace PoBabyNames.Models
{
    public class NameViewModel
    {
        public string NameText { get; set; }
        public double AverageRating { get; set; }
        public Dictionary<string, int> UserRatings { get; set; } = new Dictionary<string, int>();
    }
}
