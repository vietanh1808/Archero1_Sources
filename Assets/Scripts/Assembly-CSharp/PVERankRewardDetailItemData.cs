using System.Collections.Generic;

public class PVERankRewardDetailItemData
{
	private PVERankRewardDetailItemConfigData ConfigData { get; set; }

	public int ShowRanking => 0;

	public (int, int) RealRanking => default;

	public int TabType => 0;

	public int Area => 0;

	public bool IsLast => false;

	public List<string> Reward => null;

	public static PVERankRewardDetailItemData Create(PVERankRewardDetailItemConfigData configData)
	{
		return null;
	}
}
