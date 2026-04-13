using SportsLeague.Domain.Enums;

namespace SportsLeague.API.DTOs.Response;

public class TournamentSponsorResponseDTO
{
    public int TournamentId { get; set; }
    public int SponsorId { get; set; }
    public string SponsorName { get; set; } = string.Empty;
    public SponsorCategory Category { get; set; }
    public decimal ContractAmount { get; set; }
    public DateTime CreatedAt { get; set; }
}

