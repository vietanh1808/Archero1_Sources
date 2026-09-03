using System;
using System.Collections.Generic;

[Serializable]
public class BattleSystemProfile
{
	public int ID;

	public string Notes;

	public List<int> BindDailyIds;

	public List<int> BindStageChapterIds;

	public List<BattleSystemProfileRule> Rules;

	public BattleSystemProfileRule GetRule(int systemId)
	{
		return null;
	}

	public BattleSystemProfileRule GetOrCreateRule(int systemId)
	{
		return null;
	}
}
