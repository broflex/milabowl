﻿using Microsoft.EntityFrameworkCore;
using Milabowl.Infrastructure.Contexts;
using Milabowl.Infrastructure.Models;
using Milabowl.Repositories;

namespace Milabowl.Infrastructure.Repositories
{
    public class ProcessingRepository: IProcessingRepository
    {
        private readonly FantasyContext _context;

        public ProcessingRepository(FantasyContext context)
        {
            _context = context;
        }

        public async Task<IList<Event>> GetEventsToProcess()
        {
            return await this._context.Events
                .Include(e => e.Lineups)
                    .ThenInclude(l => l.PlayerEventLineups)
                        .ThenInclude(pel => pel.PlayerEvent)
                .Where(e => e.Finished && e.DataChecked)
                .OrderBy(g => g.GameWeek)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IList<User>> GetUserToProcess(Guid evtId)
        {
            return await this._context.Users
                .Include(u => u.Lineups)
                    .ThenInclude(l => l.PlayerEventLineups)
                    .ThenInclude(pel => pel.PlayerEvent)
                    .ThenInclude(pel => pel.Player)
                .Include(u => u.Lineups)
                    .ThenInclude(l => l.Event)
                .Include(u => u.HeadToHeadEvents)
                    .ThenInclude(hu => hu.Event)
                .Where(u => u.Lineups.Any(l => l.Event.EventId == evtId))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<bool> IsEventAlreadyCalculated(string eventName, string userEntryName)
        {
            return await this._context.MilaGWScores.AsNoTracking().AnyAsync(m =>
                m.GW == eventName &&
                m.TeamName == userEntryName);
        }

        public async Task<(Player? mostTradedIn, Player? mostTradedOut)> GetMostTradedPlayers(Guid eventId)
        {
            var mostTradedInPlayer = await this._context.PlayerEvents
                .Where(pe => pe.FkEventId == eventId)
                .OrderByDescending(pe => pe.TransfersIn)
                .Select(pe => pe.Player)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            var mostTradedOutPlayer = await this._context.PlayerEvents
                .Where(pe => pe.FkEventId == eventId)
                .OrderByDescending(pe => pe.TransfersOut)
                .Select(pe => pe.Player)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return (mostTradedInPlayer, mostTradedOutPlayer);
        }

        public async Task<UserHeadToHeadEvent?> GetOpponentHeadToHead(int userHeadToHeadEventId, Guid userId)
        {
            return await _context.UserHeadToHeadEvents.AsNoTracking().FirstOrDefaultAsync(h =>
                h.FantasyUserHeadToHeadEventID == userHeadToHeadEventId
                && h.FkUserId != userId);
        }

        public async Task AddMilaGwScores(IList<MilaGWScore> milaGwScores)
        {
            await _context.AddRangeAsync(milaGwScores);
            await _context.SaveChangesAsync();
        }
    }
}
