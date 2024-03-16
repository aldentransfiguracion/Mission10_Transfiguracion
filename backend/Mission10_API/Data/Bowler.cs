using System;
using System.Collections.Generic;

namespace Mission10_API.Data;

public partial class Bowler
{
    public int bowlerId { get; set; }

    public string? bowlerLastName { get; set; }

    public string? bowlerFirstName { get; set; }

    public string? bowlerMiddleInit { get; set; }

    public string? bowlerAddress { get; set; }

    public string? bowlerCity { get; set; }

    public string? bowlerState { get; set; }

    public string? bowlerZip { get; set; }

    public string? bowlerPhoneNumber { get; set; }

    public int? teamId { get; set; }

    public virtual ICollection<BowlerScore> BowlerScores { get; set; } = new List<BowlerScore>();

    public virtual Team? Team { get; set; }
}
