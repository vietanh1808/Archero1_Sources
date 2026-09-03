using System.Collections.Generic;

public class DropEndless : DropBase
{
	private List<BattleDropData> m_listDrops;

	public void AddDrop(BattleDropData drop)
	{
	}

	private bool find_same_equip(int equipid, ref LocalSave.EquipOne result)
	{
		return false;
	}

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
