using Microsoft.EntityFrameworkCore;

namespace Mission10_API.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;

        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }

        public IEnumerable<object> GetBowlersWithTeams()
        {
        var blah = from bowlers in _context.Bowlers
                join teams in _context.Teams
                on bowlers.TeamId equals teams.TeamId
                where teams.TeamName == "Marlins" || teams.TeamName == "Sharks"
                select new
                {
                TeamId = bowlers.TeamId,
                BowlerId = bowlers.BowlerId,
                BowlerFirstName = bowlers.BowlerFirstName,
                BowlerMiddleInit = bowlers.BowlerMiddleInit,
                BowlerLastName = bowlers.BowlerLastName,
                TeamName = teams.TeamName,
                BowlerAddress = bowlers.BowlerAddress,
                BowlerCity = bowlers.BowlerCity,
                BowlerState = bowlers.BowlerState,
                BowlerZip = bowlers.BowlerZip,
                BowlerPhoneNumber = bowlers.BowlerPhoneNumber
                };
        return blah;
        }
    }
}