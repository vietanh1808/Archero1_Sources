using System;
using System.Collections.Generic;

public class GameFormManager
{
	public class WeightData
	{
		public int EventID;

		public int Weight;

		public int AdvancedWeight;

		public int[] CloseActivity;
	}

	private Dictionary<string, List<WeightData>> weightList;

	public const string AngelSkill = "AngelSkill";

	public const string DemonSkill = "DemonSkill";

	public const string GameTurntable = "GameTurntable";

	public const string GreedySkillBig = "GreedySkillBig";

	public const string GreedySkillSmall = "GreedySkillSmall";

	public const string LevelDropIn = "LevelDropIn";

	private void Init()
	{
	}

	public void InitData()
	{
	}

	public void RemoveAngelSkill(int skillid)
	{
	}

	public void RemoveDemonSkill(int skillid)
	{
	}

	private int GetSum(List<WeightData> list, Func<int, long> func = null, Func<int, float> func2 = null, bool useAdvancedWeight = false)
	{
		return 0;
	}

	public int GetRandomID(string name)
	{
		return 0;
	}

	public void RemoveID(string name, int EventID)
	{
	}

	public void Release()
	{
	}
}
