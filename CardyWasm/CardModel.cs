namespace CardyWasm;

public class CardModel
{
    public string? Deity { get; }
    public string? Name { get; }
    public string? FollowerCost { get; }
    public string? PrayerCost { get; }
    public string? Type { get; }
    public string? Subtype { get; }
    public string? Species { get; }
    public string? Archetype { get; }
    public string? Rarity { get; }
    public string? Attack { get; }
    public string? Health { get; }
    public IList<string> Abilities { get; }
    public IList<string> PassiveEffects { get; }
    public IList<string> ActivatedEffects { get; }
    public string? ImgURL { get; }
    public string? Author { get; }

    // Primary constructor
    public CardModel(
        string? deity,
        string? name,
        string? followerCost,
        string? prayerCost,
        string? type,
        string? subtype,
        string? species,
        string? archetype,
        string? rarity,
        string? attack,
        string? health,
        string? abilities,
        string? passiveEffects,
        string? activatedEffects,
        string? imgURL,
        string? author)
    {
        Deity = deity;
        Name = name;
        FollowerCost = followerCost;
        PrayerCost = prayerCost;
        Type = type;
        Subtype = subtype;
        Species = species;
        Archetype = archetype;
        Rarity = rarity;
        Attack = attack;
        Health = health;
        Abilities = abilities is not null ? abilities.Split(" | ").ToList() : new List<string>();
        PassiveEffects = passiveEffects is not null ? passiveEffects.Split(" | ").ToList() : new List<string>();
        ActivatedEffects = activatedEffects is not null ? activatedEffects.Split(" | ").ToList() : new List<string>();
        ImgURL = imgURL;
        Author = author;
    }
    
    public CardModel(CSVModel other)
        : this(
            other.Deity,
            other.Name,
            other.FollowerCost,
            other.PrayerCost,
            other.Type,
            other.Subtype,
            other.Species,
            other.Archetype,
            other.Rarity,
            other.Attack,
            other.Health,
            other.Abilities,
            other.PassiveEffects,
            other.ActivatedEffects,
            other.ImgURL,
            other.Author)
    { }
    public string GetBottomText()
    {
        var bottomText = "";

        if (IsNotEmpty(Type))
        {
            bottomText += Type;
        }

        if (IsNotEmpty(Subtype))
        {
            bottomText += " " + Subtype;
        }

        if (IsNotEmpty(Species) || IsNotEmpty(Archetype))
        {
            bottomText += " " + "-";
        }

        if (IsNotEmpty(Species))
        {
            bottomText += " " + Species;
        }

        if (IsNotEmpty(Archetype))
        {
            bottomText += " " + Archetype;
        }

        return bottomText;
    }
    private bool IsNotEmpty(string? str)
    {
        return str is not null && str !=  "";
    }
}