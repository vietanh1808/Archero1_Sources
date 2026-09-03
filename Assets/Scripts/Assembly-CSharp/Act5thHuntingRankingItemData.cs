using System.Collections.Generic;
using TableTool;

public class Act5thHuntingRankingItemData : RecycleData<Act5thHuntingRankingItemConfigData>
{
	private Act5thHuntingRankingItemConfigData ConfigData { get; set; }

	public ulong UserID => 0uL;

	public int RealRanking => 0;

	public long Score => 0L;

	public string Name => null;

	public int HeadID => 0;

	public int HeadFrame => 0;

	public long HeadFrameTime => 0L;

	public int VIPLevel => 0;

	public List<int> MedalData => null;

	public int GroupIndex => 0;

	public int ListRanking(int index)
	{
		return 0;
	}

	public float ShowRanking(int index)
	{
		return 0f;
	}

	public List<Drop_DropModel.DropData> Reward(int index)
	{
		return null;
	}

	public string BoxIconName(int index)
	{
		return null;
	}

	public float PercentageRanking(int index)
	{
		return 0f;
	}

	public static Act5thHuntingRankingItemData Create(Act5thHuntingRankingItemConfigData configData)
	{
		return null;
	}

	private Act5thHuntingRankConfigData GetHuntingRankingItemConfig(int index)
	{
		return null;
	}

	private float GetPercentageRanking(int index)
	{
		return 0f;
	}

	private List<Drop_DropModel.DropData> GetReward(int index)
	{
		return null;
	}

	private string GetBoxIconName(int index)
	{
		return null;
	}
}
