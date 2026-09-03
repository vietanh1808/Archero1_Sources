using System.Collections.Generic;

public class SailingTalentPersonalProgressData : RecycleData<SailingTalentProgressConfigData>
{
	public List<SailingTalentPersonalProgressItemData> ProgressItemData => null;

	public int MaxProgressItemCount => 0;

	public SailingTalentPersonalProgressItemData GetProgressItemData(int row, int col)
	{
		return null;
	}

	public SailingTalentPersonalProgressItemData GetProgressItemData(int id)
	{
		return null;
	}

	public void TalentUpgrade(int id)
	{
	}
}
