using System.Text.Json.Serialization;

namespace Milabowl.Domain.Import.FantasyDTOs;

public record EntryRootDTO(
    [property: JsonPropertyName("current")] IList<EntryCurrentResultDTO> Current,
    [property: JsonPropertyName("past")] IList<EntryPastResultDTO> Past
);

public record EntryCurrentResultDTO(
    [property: JsonPropertyName("event")] int Event,
    [property: JsonPropertyName("points")] int Points,
    [property: JsonPropertyName("total_points")] int TotalPoints,
    [property: JsonPropertyName("rank")] int Rank,
    [property: JsonPropertyName("rank_sort")] int RankSort,
    [property: JsonPropertyName("overall_rank")] int OverallRank,
    [property: JsonPropertyName("bank")] int Bank,
    [property: JsonPropertyName("value")] int Value,
    [property: JsonPropertyName("event_transfers")] int EventTransfers,
    [property: JsonPropertyName("event_transfers_cost")] int EventTransferCosts,
    [property: JsonPropertyName("points_on_bench")] int PointsOnBench
);

public record EntryPastResultDTO(
    [property: JsonPropertyName("season_name")] string SeasonName,
    [property: JsonPropertyName("total_points")] int TotalPoints,
    [property: JsonPropertyName("rank")] int Rank
);
    