//namespace Mission10_API.Data
//{
//    public interface IBowlingRepository
//    {
//        IEnumerable<Bowler> Bowlers { get; }
//    }
//}
namespace Mission10_API.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> GetBowlersWithTeams();
    }
}
