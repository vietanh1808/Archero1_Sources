using System.Collections.Generic;
using TableTool;

public class SailingAchievementItemData
{
	public int type;

	public int progress;

	public int count;

	public List<ShipBattle_ShipAchieve> achList;

	public bool canGet => false;

	public bool finished => false;

	public ShipBattle_ShipAchieve CurrentAchiDataOne => null;
}
