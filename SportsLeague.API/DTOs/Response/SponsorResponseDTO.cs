using SportsLeague.Domain.Enums;

namespace SportsLeague.API.DTOs.Response;

public class SponsorResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public SponsorCategory Category { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int TournamentsCount { get; set; }
}