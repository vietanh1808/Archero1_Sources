using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TableTool;

[Serializable]
public class NewPlay126MonsterRemouldStoneDropItemData
{
	public int DropID;

	public int UniqueID;

	[JsonIgnore]
	public bool IsValidStone => false;

	[JsonIgnore]
	public Daily_DIYChangeMonster Config => null;

	public static NewPlay126MonsterRemouldStoneDropItemData Create(int dropID)
	{
		return null;
	}

	public NewPlay126MonsterRemouldStoneDropItemData RandomDrop()
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetAttrs()
	{
		return null;
	}

	public List<int> GetSkills()
	{
		return null;
	}

	public void InstallStoneEffect(EntityBase entity)
	{
	}

	public void UnInstallStoneEffect()
	{
	}
}
