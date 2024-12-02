namespace CardyWasm.Classes;

public class CardTemplate
{
   public List<MaskCondition> Frames { get; set; } = [new ()];
   public List<MaskCondition> Masks { get; set; } = [new ()];
   public List<MaskCondition> Emblems { get; set; } = [new ()];
   public List<IconCondition> Icons { get; set; } = [new ()];
}