using System;
using System.Collections.Generic;
using System.Text;

using SportsLeague.Domain.Entities;

namespace SportsLeague.Domain.Interfaces.Services;
//This service is unique for matchresult, goals and cards. Objective: avoid code duplication.
public interface IMatchEventService
{
    // MatchResult
    Task<MatchResult> RegisterResultAsync(int matchId, MatchResult result);
    Task<MatchResult?> GetResultByMatchAsync(int matchId);

    // Goals
    Task<Goal> RegisterGoalAsync(int matchId, Goal goal);
    Task<IEnumerable<Goal>> GetGoalsByMatchAsync(int matchId);
    Task DeleteGoalAsync(int goalId);

    // Cards
    Task<Card> RegisterCardAsync(int matchId, Card card);
    Task<IEnumerable<Card>> GetCardsByMatchAsync(int matchId);
    Task DeleteCardAsync(int cardId);
}
