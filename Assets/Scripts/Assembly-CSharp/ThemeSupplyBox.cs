using System.Collections.Generic;
using TableTool;

public abstract class ThemeSupplyBox
{
	public enum Type
	{
		HERO = 0,
		GEM = 1
	}

	public string productId;

	public List<Drop_DropModel.DropData> secondaryRewards;

	public int buyCount;

	public abstract Type GetBoxType();

	public abstract Drop_DropModel.DropData GetMainReward();
}
