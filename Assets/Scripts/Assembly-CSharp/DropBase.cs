using System.Collections.Generic;
using TableTool;

public abstract class DropBase
{
	protected Soldier_soldier m_Data;

	protected int m_nGuid;

	protected List<BattleDropData> mList;

	protected long MaxHP;

	protected long currentHP;

	public void Init(int guid, Soldier_soldier data, long hp)
	{
	}

	public List<BattleDropData> GetDropDead()
	{
		return null;
	}

	public List<BattleDropData> GetHittedList(long hit)
	{
		return null;
	}

	protected abstract void OnInit();

	protected abstract List<BattleDropData> OnGetDropDead();

	protected abstract List<BattleDropData> OnGetHittedList(long hit);
}
