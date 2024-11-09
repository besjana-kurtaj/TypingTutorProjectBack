namespace TypingTutor.API.Dto
{
    public class UserProgressDto
    {
        public int UserProgressId { get; set; }
        public string UserId { get; set; }
        public int LevelId { get; set; }
        public double Speed { get; set; }
        public double Accuracy { get; set; }
        public DateTime CompletionDate { get; set; } = DateTime.UtcNow;
    }
}
