using System.Collections.Generic;
using TableTool;

public class PiggyBankActData
{
	public int Tag;

	public long OpenTime;

	public long EndTime;

	public long RefreshTime;

	public int Day;

	public bool IsGetFreeBox;

	public int TotalBattle;

	public List<Drop_DropModel.DropData> FreeRewards;

	public List<PiggyBankItemData> PiggyBankItems;

	public void Clear()
	{
	}
}
