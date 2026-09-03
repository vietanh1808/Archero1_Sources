using System.Collections.Generic;

public class SailingRankingData
{
	public List<SailingRankingItemData> RankLifeItemDatas;

	public List<SailingRankingItemData> RankTalentItemDatas;

	public List<SailingRankingItemData> RankFireItemDatas;

	public List<SailingRankingItemData> RankActivityItemDatas;

	public ulong LifeValue;

	public uint LifeRank;

	public ulong TalentValue;

	public uint TalentRank;

	public ulong FireValue;

	public uint FireRank;

	public ulong ActivityValue;

	public uint ActivityRank;

	public ushort ActivityType;

	public long StaminaEndTime;

	public long StaminaEndShowTime;

	public long SeasonFireEndTime;

	public long SeasonFireEndShowTime;

	public SailingRankingItemData self;
}
