namespace Milabowl.Domain.Entities.Fantasy;

public class Lineup
{
    public Guid LineupId { get; set; }
    public Event Event { get; set; }
    public Guid FkEventId { get; set; }
    public User User { get; set; }
    public Guid FkUserId { get; set; }
    public IList<PlayerEventLineup> PlayerEventLineups { get; set; }
    public string? ActiveChip { get; set; }
    public int Points { get; set; }
    public int TotalPoints { get; set; }
    public int Rank { get; set; }
    public int RankSort { get; set; }
    public int OverallRank { get; set; }
    public int Bank { get; set; }
    public int Value { get; set; }
    public int EventTransfers { get; set; }
    public int EventTransferCost { get; set; }
    public int PointsOnBench { get; set; }
}