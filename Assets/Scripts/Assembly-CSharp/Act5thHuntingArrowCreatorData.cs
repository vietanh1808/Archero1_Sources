using System.Collections.Generic;

public class Act5thHuntingArrowCreatorData
{
	public int BowID { get; set; }

	public List<Act5thHuntingArrowData> ArrowData { get; set; }

	public int ArrowCount => 0;

	public float ArrowSendInterval => 0f;

	public bool IsArrowDisabled => false;

	public float Scale => 0f;

	public static Act5thHuntingArrowCreatorData Create(int bowID, List<Act5thHuntingArrowData> arrowData)
	{
		return null;
	}
}
