using System.Collections.Generic;

public class MBPoolManager
{
	private static MBPoolManager _instance;

	public List<LocalSave.MonsterData> MonsterPool;

	public List<LocalSave.MonsterData> ActiveMonsterPool;

	public static MBPoolManager Instance => null;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	private void initMonsterPool()
	{
	}

	public bool IsInMeadowBattle(int monsterId)
	{
		return false;
	}

	public void Add2ActivePool(int monsterId)
	{
	}

	public void RemoveFromActivePool(int monsterId)
	{
	}
}
