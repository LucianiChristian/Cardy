namespace CardyWasm;

public class CardTemplate
{
   public List<MaskCondition> Frames { get; set; } = [];
   public List<MaskCondition> Masks { get; set; } = [];
   public List<MaskCondition> Emblems { get; set; } = [];
   public List<IconCondition> Icons { get; set; } = [];
}