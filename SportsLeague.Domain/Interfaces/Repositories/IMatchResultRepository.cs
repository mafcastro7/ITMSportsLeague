using System;
using System.Collections.Generic;
using System.Text;

using SportsLeague.Domain.Entities;

namespace SportsLeague.Domain.Interfaces.Repositories;

public interface IMatchResultRepository : IGenericRepository<MatchResult>
{
    Task<MatchResult?> GetByMatchIdAsync(int matchId);
}

