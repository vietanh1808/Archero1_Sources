using System.Collections.Generic;
using TableTool;

public class ThemeSupplyBoxHero : ThemeSupplyBox
{
	public List<Drop_DropModel.DropData> mainRewards;

	public int selectedIndex;

	public int lastSelectedIndex;

	public override Type GetBoxType()
	{
		return Type.HERO;
	}

	public override Drop_DropModel.DropData GetMainReward()
	{
		return null;
	}
}
