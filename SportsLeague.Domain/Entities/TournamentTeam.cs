namespace SportsLeague.Domain.Entities;

//Tournament Team es la tabla intermedia que representa la relación muchos a muchos entre Torneos y Equipos.
//Contiene información adicional como la fecha de registro del equipo en el torneo.
public class TournamentTeam : AuditBase
{
    public int TournamentId { get; set; }
    public int TeamId { get; set; }
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public Tournament Tournament { get; set; } = null!;
    public Team Team { get; set; } = null!;
}
