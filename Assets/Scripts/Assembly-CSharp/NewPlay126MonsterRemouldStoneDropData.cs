using System;
using System.Collections.Generic;

[Serializable]
public class NewPlay126MonsterRemouldStoneDropData : LocalSave.ICloneable<NewPlay126MonsterRemouldStoneDropData>
{
	public float SoliderDropData;

	public float BossDropData;

	public List<NewPlay126MonsterRemouldStoneDropItemData> AllDropItem;

	public int MaxUniqueID;

	public void Clone(NewPlay126MonsterRemouldStoneDropData source)
	{
	}

	public static NewPlay126MonsterRemouldStoneDropData Create(List<NewPlay126MonsterRemouldStoneDropItemData> allDropItem)
	{
		return null;
	}

	public int GetUniqueID()
	{
		return 0;
	}

	public void ResetAllDropData()
	{
	}

	public float GetDiyDropRate(bool isBoss)
	{
		return 0f;
	}

	public NewPlay126MonsterRemouldStoneDropItemData PickDiyEquip(bool isBoss)
	{
		return null;
	}

	public void Clear()
	{
	}
}
