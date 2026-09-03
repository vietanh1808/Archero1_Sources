public class Act5thHuntingArrowData : Act5thHuntingEntityData
{
	public int BowID;

	public Act5thHuntingArrowType ArrowType { get; set; }

	public float Width { get; set; }

	public float Length { get; set; }

	public Act5thHuntingBowConfigData BowConfigData => null;

	public Act5thHuntingArrowData SetData(int bowID, Act5thHuntingArrowType arrowType)
	{
		return null;
	}
}
