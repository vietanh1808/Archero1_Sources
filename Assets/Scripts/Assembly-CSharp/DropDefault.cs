using System.Collections.Generic;

public class DropDefault : DropBase
{
	protected override void OnInit()
	{
	}

	protected override List<BattleDropData> OnGetDropDead()
	{
		return null;
	}

	protected override List<BattleDropData> OnGetHittedList(long hit)
	{
		return null;
	}
}
