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
                on bowlers.teamId equals teams.teamId
                where teams.teamName == "Marlins" || teams.teamName == "Sharks"
                select new
                {
                TeamId = bowlers.teamId,
                BowlerId = bowlers.bowlerId,
                BowlerFirstName = bowlers.bowlerFirstName,
                BowlerMiddleInit = bowlers.bowlerMiddleInit,
                BowlerLastName = bowlers.bowlerLastName,
                TeamName = teams.teamName,
                BowlerAddress = bowlers.bowlerAddress,
                BowlerCity = bowlers.bowlerCity,
                BowlerState = bowlers.bowlerState,
                BowlerZip = bowlers.bowlerZip,
                BowlerPhoneNumber = bowlers.bowlerPhoneNumber
                };
        return blah;
        }
    }
}