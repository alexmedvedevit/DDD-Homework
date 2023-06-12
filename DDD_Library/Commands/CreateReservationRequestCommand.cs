using DDD_Library.Models;
using MediatR;

namespace DDD_Library.Commands;

public class CreateReservationRequestCommand : IRequest<long>, IItemsModel<ReservationRequestDto>
{
    public IReadOnlyList<ReservationRequestDto> Items { get; set; }
}
