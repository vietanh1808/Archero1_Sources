using System;
using System.Collections.Generic;

[Serializable]
public class NewPlay126MonsterEntityGroupData : LocalSave.ICloneable<NewPlay126MonsterEntityGroupData>
{
	public List<NewPlay126MonsterEntityGroupItemData> AllMonster;

	public NewPlay126MonsterEntityGroupItemData CreateMonster;

	public void Clone(NewPlay126MonsterEntityGroupData source)
	{
	}

	public void Init(bool isNewGame)
	{
	}

	public void SetCreateMonsterData(NewPlay126MonsterEntityGroupItemData monsterData)
	{
	}

	public bool HaveCreateMonsterData()
	{
		return false;
	}

	public void Clear()
	{
	}
}
