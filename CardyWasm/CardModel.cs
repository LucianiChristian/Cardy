namespace CardyWasm;

public class CardModel
{
    public string? Deity { get; set; }
    public string? CardName { get; set; }
    public int FollowerCost { get; set; }
    public int PrayerCost { get; set; }
    public string? Type { get; set; }
    public string? Subtype { get; set; }
    public string? Species { get; set; }
    public string? Archetype { get; set; }
    public string? Rarity { get; set; }
    public int Attack { get; set; }
    public int Health { get; set; }
    public string? Abilities { get; set; }
    public string? PassiveEffects { get; set; }
    public string? ActivatedEffects { get; set; }
    public string? StarterDeck { get; set; }
    public string? ChampionExclusive { get; set; }
    public string? ImageUrl { get; set; }
    public string? Author { get; set; }
    public int VersionNumber { get; set; }
}