namespace Grafik.Data;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid PlanningSessionId { get; set; }
    public ReservationType Type { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string? Comment { get; set; }
}
