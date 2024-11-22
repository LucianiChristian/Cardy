using CsvHelper.Configuration.Attributes;

namespace CardyWasm;

public class CardModel
{
    [Name("Deity")]
    public string? Deity { get; set; }
    
    [Name("Name")]
    public string? Name { get; set; }
    
    [Name("Follower Cost")]
    public string? FollowerCost { get; set; }
    
    [Name("Prayer Cost")]
    public string? PrayerCost { get; set; }
    
    [Name("Type")]
    public string? Type { get; set; }
    
    [Name("Subtype")]
    public string? Subtype { get; set; }
    
    [Name("Species")]
    public string? Species { get; set; }
    
    [Name("Archetype")]
    public string? Archetype { get; set; }
    
    [Name("Rarity")]
    public string? Rarity { get; set; }
    
    [Name("Attack")]
    public string? Attack { get; set; }
    
    [Name("Health")]
    public string? Health { get; set; }
    
    [Name("Abilities")]
    public string? Abilities { get; set; }
    
    [Name("Passive Effects")]
    public string? PassiveEffects { get; set; }
    
    [Name("Activated Effects")]
    public string? ActivatedEffects { get; set; }
    
    [Name("Starter Deck")]
    public string? StarterDeck { get; set; }
    
    [Name("Champion Exclusive")]
    public string? ChampionExclusive { get; set; }
    
    [Name("Image URL")]
    public string? ImgUrl { get; set; }
    
    [Name("Author")]
    public string? Author { get; set; }
    
    [Name("Version #")]
    public string? Version { get; set; }
}