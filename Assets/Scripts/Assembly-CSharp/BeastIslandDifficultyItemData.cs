using TableTool;

public class BeastIslandDifficultyItemData
{
	public int ID;

	public bool isFirst;

	public bool IsShow;

	public bool IsUnlock;

	public int ClearNum;

	public ShipStage_BagDifficulty Config => null;

	public bool isUnlockSweep => false;

	public bool GetIsSelect()
	{
		return false;
	}

	public void Select()
	{
	}
}
