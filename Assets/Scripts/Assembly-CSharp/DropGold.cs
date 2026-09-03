using System.Collections.Generic;

public class DropGold : DropBase
{
	private List<BattleDropData> mHittedList;

	private int listcount;

	private int allcount;

	protected override void OnInit()
	{
	}

	protected override List<BattleDropData> OnGetHittedList(long hit)
	{
		return null;
	}

	protected override List<BattleDropData> OnGetDropDead()
	{
		return null;
	}
}
