using Domain.Entity;
using Domain.Enum;

namespace Application.CardCQ.ViewModels;

public record CarInfoViewModel
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime? Deadline { get; set; }
    public StatusCardEnum Status { get; set; }
}