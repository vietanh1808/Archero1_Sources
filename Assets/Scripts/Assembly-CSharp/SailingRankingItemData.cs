using System.Collections.Generic;
using GameProtocol;

public class SailingRankingItemData
{
	public ulong userid;

	public int rank;

	public string name;

	public ulong value;

	public int head;

	public int headBox;

	public long headTime;

	public int vip;

	public List<int> medals;

	public int skinid;

	public int heroid;

	public int wingid;

	public int wingStar;

	public int Peerage;

	public List<LocalSave.ArtifactOne> artiList;

	public SailingRankingItemData ParseData(CShipBattleBaseRank netData)
	{
		return null;
	}
}
