namespace PG_LIFE_UU.Models
{
    public class CleaningTask
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public DateTime ScheduledAt { get; set; }
    }
}
