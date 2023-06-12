namespace DDD_Library.Models;
public class ReservationRequestItem
{
    public long Id { get; set; }

    public long BookRequestId { get; set; }

    public ReservationRequestStatus RequestStatus { get; set; }

    public IReadOnlyList<long> LibCardsCollection { get; set; }
}