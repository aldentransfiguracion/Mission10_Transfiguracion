using System;
using System.Collections.Generic;

namespace Mission10_API.Data;

public partial class Team
{
    public int teamId { get; set; }

    public string teamName { get; set; } = null!;

    public int? captainId { get; set; }

    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();

    public virtual ICollection<TourneyMatch> TourneyMatchEvenLaneTeams { get; set; } = new List<TourneyMatch>();

    public virtual ICollection<TourneyMatch> TourneyMatchOddLaneTeams { get; set; } = new List<TourneyMatch>();
}
