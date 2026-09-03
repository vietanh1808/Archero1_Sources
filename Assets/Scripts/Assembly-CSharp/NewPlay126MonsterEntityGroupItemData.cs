using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TableTool;

[Serializable]
public class NewPlay126MonsterEntityGroupItemData
{
	public int MonsterId;

	[JsonIgnore]
	public Daily_ChangeMonsterConfig MonsterConfig => null;

	[JsonIgnore]
	public Character_Char CharacterConfig => null;

	[JsonIgnore]
	public string[] Args => null;

	[JsonIgnore]
	public int[] OriginSkill => null;

	public static NewPlay126MonsterEntityGroupItemData Create(int monsterID)
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
}
