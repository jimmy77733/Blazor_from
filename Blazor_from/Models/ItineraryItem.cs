namespace Blazor_from.Models
{
    public class ItineraryItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public DateTime DueDate { get; set; } = DateTime.Now;
        public bool IsDone { get; set; } = false;
    }
}

