using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; 

namespace Mission10_API.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;

        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> GetBowlersWithTeams()
        {
            return _context.Bowlers
                .Include(a => a.Team)
                .ToList();
        }
    }
}
