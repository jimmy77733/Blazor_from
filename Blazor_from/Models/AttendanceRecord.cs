namespace Blazor_from.Models
{
    public class AttendanceRecord
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime ClockInTime { get; set; }
        public DateTime? ClockOutTime { get; set; }
        public string Status => ClockOutTime.HasValue ? "已簽退" : "工作中";
    }
}

