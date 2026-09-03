using System;
using System.Collections.Generic;

[Serializable]
public class NewPlay126MonsterRemouldStoneData : LocalSave.ICloneable<NewPlay126MonsterRemouldStoneData>
{
	public NewPlay126MonsterRemouldStoneDropData dropData;

	public List<NewPlay126MonsterRemouldStoneDropItemData> SelectRemouldStone;

	public List<NewPlay126MonsterRemouldStoneDropItemData> AllHaveRemouldStone;

	public void Clone(NewPlay126MonsterRemouldStoneData source)
	{
	}

	public void Init(bool isNewGame)
	{
	}

	public void Clear()
	{
	}

	public void AddRemouldStone(NewPlay126MonsterRemouldStoneDropItemData stoneData)
	{
	}

	public void ReplaceSelectRemouldStone(int index, NewPlay126MonsterRemouldStoneDropItemData stoneData)
	{
	}

	public int GetAllSlotCount()
	{
		return 0;
	}

	public int GetOriginSlotCount()
	{
		return 0;
	}
}
